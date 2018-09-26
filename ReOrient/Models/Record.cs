using Microsoft.Maps.MapControl.WPF;
using ReOrient.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class Record
	{


		public Record()
		{
			Size77701 = new Command(_Size77701, _Size77701Exec); //Commercial, Apartments, PolyPlex
			Size77799 = new Command(_Size77799, _Size77799Exec); //Unmeasureable Under 24
			Size99 = new Command(_Size99, _Size99Exec); //Over 24 
			Size0 = new Command(_Size0, _Size0Exec); //Unmeasured
			Size77707 = new Command(_Size77707, _Size77707Exec); //Not Found
		}


		public Command Size77701 { get; set; }
		public Command Size77799 { get; set; }
		public Command Size99 { get; set; }
		public Command Size0 { get; set; }
		public Command Size77707 { get; set; }

		#region Commands
		private void _Size77701(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.size = (decimal)777.01;
			MainWindow.sa.SaveChanges();
			
		}
		private bool _Size77701Exec(object RecordObj)
		{
			return true;
		}
		private void _Size77799(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.size = (decimal)777.99;
			MainWindow.sa.SaveChanges();
		}
		private bool _Size77799Exec(object RecordObj)
		{
			return true;
		}
		private void _Size99(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.size = (decimal)99;
			MainWindow.sa.SaveChanges();
		}
		private bool _Size99Exec(object RecordObj)
		{
			return true;
		}

		private void _Size0(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.size = (decimal)0;
			MainWindow.sa.SaveChanges();
		}
		private bool _Size0Exec(object RecordObj)
		{
			return true;
		}
		private void _Size77707(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.size = (decimal)777.07;
			MainWindow.sa.SaveChanges();
		}
		private bool _Size77707Exec(object RecordObj)
		{
			return true;
		}
		#endregion

		public SA.markcust MarkCust { get; set; }
		public string Address
		{
			get
			{
				var mark = MarkCust;
				StringBuilder str = new StringBuilder();
				str.Append(mark.streetno);
				str.Append(' ');

				if (!string.IsNullOrWhiteSpace(mark.predir))
				{
					str.Append(mark.predir);
					str.Append(' ');
				}
				str.Append(mark.streetnm);
				str.Append(' ');
				str.Append(mark.suffix);


				if (!string.IsNullOrWhiteSpace(mark.postdir))
				{
					str.Append(' ');
					str.Append(mark.postdir);
				}

				return str.ToString();
			}
		}

		public Location Location
		{
			get
			{
				return BingControl.getBingLocation(this, BingControl.MatchCode.Good, BingControl.Confidence.High);
			}
		}

		public decimal Size => (decimal)(MarkCust.size == null ? 0 : MarkCust.size);

	}
}
