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
			Record rec = (Record)RecordObj;
			rec.MarkCust.PostDir = null;
			rec.MarkCust.PreDir = rec.PreDir;
			
		}
		private bool _AssignPredirExec(object RecordObj)
		{
			return true;
		}


		private void _AssignPostDir(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.PreDir = null;
			rec.MarkCust.PostDir = rec.PostDir;
		}
		private bool _AssignPostdirExec(object RecordObj)
		{
			return true;
		}


		private void _Size77701(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.CustSize = 777.01;
		}
		private bool _Size77701Exec(object RecordObj)
		{
			return true;
		}


		private void _Size77799(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.CustSize = 777.99;
		}
		private bool _Size77799Exec(object RecordObj)
		{
			return true;
		}


		private void _Size99(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.CustSize = 99;
		}
		private bool _Size99Exec(object RecordObj)
		{
			return true;
		}


		private void _Size0(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.CustSize = 0;
		}
		private bool _Size0Exec(object RecordObj)
		{
			return true;
		}


		private void _Size77707(object RecordObj)
		{
			Record rec = (Record)RecordObj;
			rec.MarkCust.CustSize = 777.07;
		}
		private bool _Size77707Exec(object RecordObj)
		{
			return true;
		}
		#endregion

		public IMarkCust MarkCust { get; set; }
		public string Address
		{
			get
			{
				IMarkCust mark = MarkCust;
				StringBuilder str = new StringBuilder();

				if (!string.IsNullOrWhiteSpace(mark.StreetNo))
				{
					str.Append(mark.StreetNo.Trim());
					str.Append(' ');
				}

				if (!string.IsNullOrWhiteSpace(mark.PreDir))
				{
					str.Append(mark.PreDir.Trim());
					str.Append(' ');
				}
				str.Append(mark.StreetNm);
				str.Append(' ');
				if (mark.Suffix != null)
				{
					str.Append(mark.Suffix.Trim());
				}

				if (!string.IsNullOrWhiteSpace(mark.PostDir))
				{
					str.Append(' ');
					str.Append(mark.PostDir.Trim());
				}

				return str.ToString();


			}
		}

		public string HennepinModeCopy
		{
			get
			{
				IMarkCust mark = MarkCust;
				StringBuilder str = new StringBuilder();

				if (!string.IsNullOrWhiteSpace(mark.StreetNo))
				{
					str.Append(mark.StreetNo.Trim());
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
				Location location = BingControl.getBingLocation(Address, MarkCust.Zip, BingControl.MatchCode.Good, BingControl.Confidence.High);
				if (location != null)
				{
					MarkCust.Latitude = location.Latitude;
					MarkCust.Longitude = location.Longitude;
				}

				return location;
			}
		}

		public double Size => (double)(MarkCust.CustSize == null ? 0 : MarkCust.CustSize);


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
				int len = str.Length;

				postDir = str.Substring(len - 2, 2).Trim();

			}
		}

		private double newSize;
		public double NewSize
		{
			get { return newSize; }
			set
			{
				newSize = value;
				MarkCust.CustSize = newSize;
			}
		}

	}
}
