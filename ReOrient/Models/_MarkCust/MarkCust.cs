using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class MarkCust : IMarkCust
	{
		private double? _size;

		public MarkCust(string commaDelitedLine, Dictionary<string, int> columnDictionary)
		{
			string[] lineSplit = commaDelitedLine.Split(',');
			Cust_No = Convert.ToInt32(lineSplit[columnDictionary[nameof(Cust_No).ToLower()]].Replace("\"", ""));
			PreDir = lineSplit[columnDictionary[nameof(PreDir).ToLower()]].Replace("\"", "");
			Latitude = Convert.ToDouble(lineSplit[columnDictionary[nameof(Latitude).ToLower()]].Replace("\"", ""));
			Longitude = Convert.ToDouble(lineSplit[columnDictionary[nameof(Longitude).ToLower()]].Replace("\"", ""));
			PostDir = lineSplit[columnDictionary[nameof(PostDir).ToLower()]].Replace("\"", "");
			_size = Convert.ToDouble(lineSplit[columnDictionary[nameof(Size).ToLower()]].Replace("\"", ""));
			StreetNm = lineSplit[columnDictionary[nameof(StreetNm).ToLower()]].Replace("\"", "");
			StreetNo = lineSplit[columnDictionary[nameof(StreetNo).ToLower()]].Replace("\"", "");
			Suffix = lineSplit[columnDictionary[nameof(Suffix).ToLower()]].Replace("\"", "");
			Zip = lineSplit[columnDictionary[nameof(Zip).ToLower()]].Replace("\"", "");
		}


		public int Cust_No { get; set; }

		public string StreetNo { get; set; }

		public string PreDir { get; set; }

		public string StreetNm { get; set; }

		public string Suffix { get; set; }

		public string PostDir { get; set; }

		public string Zip { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public double? Size
		{
			get
			{
				return _size;
			}
			set
			{
				_size = value;
				if (canWriteChanges(value))
				{
					WriteChanges();
				}
			}
		}

		public string FilePath { get; set; }

		public int CSVRowIndex { get; set; }

		public DateTime LastChange { get; set; }

		public bool canWriteChanges(double? value)
		{
			if (value < 0) { return false; }
			return true;
		}

		public void WriteChanges()
		{
			MarkCustCSVControl cSVControl = new MarkCustCSVControl();

			string[] lines = cSVControl.GetCSVLines(FilePath);
			Dictionary<string, int> columnDict = cSVControl.GetColumnDictionary(lines[0]);

				if (Cust_No == new MarkCust(lines[CSVRowIndex], columnDict).Cust_No)
				{
					string[] elements = lines[CSVRowIndex].Split(',');
					int column = columnDict[nameof(Size).ToLower()];
					elements[column] = Size.ToString();
					lines[CSVRowIndex] = string.Join(",", elements);
				}


			StreamWriter writer = new StreamWriter(FilePath, append: false);
			for (int i = 0; i < lines.Count() - 1; i++)
			{
				writer.WriteLine(lines[i]);
			}
			writer.Dispose();
			
		}
	}
}
