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
			AssignPostdir = new Command(_AssignPostDir, _AssignPostdirExec);
			AssignPredir = new Command(_AssignPredir, _AssignPredirExec);
		}


		public Command Size77701 { get; set; }
		public Command Size77799 { get; set; }
		public Command Size99 { get; set; }
		public Command Size0 { get; set; }
		public Command Size77707 { get; set; }
		public Command AssignPredir { get; set; }
		public Command AssignPostdir { get; set; }

		#region Commands

		private void _AssignPredir(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.postdir = null;
			rec.MarkCust.predir = rec.PreDir;
			MainWindow.sa.SaveChanges();
		}
		private bool _AssignPredirExec(object RecordObj)
		{
			return true;
		}


		private void _AssignPostDir(object RecordObj)
		{
			var rec = (Record)RecordObj;
			rec.MarkCust.predir = null;
			rec.MarkCust.postdir = rec.PostDir;
			MainWindow.sa.SaveChanges();
		}
		private bool _AssignPostdirExec(object RecordObj)
		{
			return true;
		}


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

				if (!string.IsNullOrWhiteSpace(mark.streetno))
				{
					str.Append(mark.streetno.Trim());
					str.Append(' ');
				}

				if (!string.IsNullOrWhiteSpace(mark.predir))
				{
					str.Append(mark.predir.Trim());
					str.Append(' ');
				}
				str.Append(mark.streetnm);
				str.Append(' ');
				if (mark.suffix != null) str.Append(mark.suffix.Trim());


				if (!string.IsNullOrWhiteSpace(mark.postdir))
				{
					str.Append(' ');
					str.Append(mark.postdir.Trim());
				}

				return str.ToString();


			}
		}

		public string HennepinModeCopy
		{
			get
			{
				var mark = MarkCust;
				StringBuilder str = new StringBuilder();

				if (!string.IsNullOrWhiteSpace(mark.streetno))
				{
					str.Append(mark.streetno.Trim());
					//str.Append(' ');
				}

			/*	if (!string.IsNullOrWhiteSpace(mark.predir))
				{
					str.Append(mark.predir.Trim());
					str.Append(' ');
				}
				str.Append(mark.streetnm);
				str.Append(' ');
				if (mark.suffix != null) str.Append(mark.suffix.Trim());


				if (!string.IsNullOrWhiteSpace(mark.postdir))
				{
					str.Append(' ');
					str.Append(mark.postdir.Trim());
				}*/

				return str.ToString();
			}
		}

		public Location Location
		{
			get
			{
				Location location = BingControl.getBingLocation(this, BingControl.MatchCode.Good, BingControl.Confidence.High);
				if (location != null)
				{
					MarkCust.latitude = (decimal)location.Latitude;
					MarkCust.longitude = (decimal)location.Longitude;
					MainWindow.sa.SaveChanges();
				}

				return location;
			}
		}

		public decimal Size => (decimal)(MarkCust.size == null ? 0 : MarkCust.size);


		private string preDir;
		public string PreDir
		{
			get { return preDir; }
			set
			{
				preDir = value;
			}
		}


		private string postDir;
		public string PostDir
		{
			get { return postDir; }
			set
			{
				string str = value.ToString();
				var len = str.Length;

				postDir = str.Substring(len - 2, 2).Trim();

			}
		}

		private decimal newSize;
		public decimal NewSize
		{
			get { return newSize; }
			set
			{
				newSize = value;
				MarkCust.size = newSize;
				MainWindow.sa.SaveChanges();
			}
		}

	}
}
