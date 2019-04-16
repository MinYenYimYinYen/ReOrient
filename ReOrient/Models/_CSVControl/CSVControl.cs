using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class CSVControl : ICSVControl
	{
		public IEnumerable<IMarkCust> GetMarkCustsFromCSV(string csvPath)
		{
			ObservableCollection<MarkCust> markCusts = new ObservableCollection<MarkCust>();

			FileStream fileStream = new FileStream(csvPath, FileMode.Open);
			StreamReader streamReader = new StreamReader(fileStream);

			string wholeText = streamReader.ReadToEnd();
			wholeText = wholeText.Replace("\r\n", "~~~").Replace("\r",";").Replace("~~~","\n");

			string[] lines = wholeText.Split('\n');
			
			Dictionary<string, int> ColumnDictionary = GetMarkCustColumns(lines[0]);
			for (int i = 1; i < lines.Count(); i++)
			{				 
				string[] lineSplit = lines[i].Split(',');

				if (lineSplit.Count() > 1)
				{
					markCusts.Add(new MarkCust
					{
						PreDir = lineSplit[ColumnDictionary[nameof(MarkCust.PreDir).ToLower()]].Replace("\"",""),
						Latitude = Convert.ToDouble(lineSplit[ColumnDictionary[nameof(MarkCust.Latitude).ToLower()]].Replace("\"", "")),
						Longitude = Convert.ToDouble(lineSplit[ColumnDictionary[nameof(MarkCust.Longitude).ToLower()]].Replace("\"", "")),
						PostDir = lineSplit[ColumnDictionary[nameof(MarkCust.PostDir).ToLower()]].Replace("\"", ""),
						Size = Convert.ToDouble(lineSplit[ColumnDictionary[nameof(MarkCust.Size).ToLower()]].Replace("\"", "")),
						StreetNm = lineSplit[ColumnDictionary[nameof(MarkCust.StreetNm).ToLower()]].Replace("\"", ""),
						StreetNo = lineSplit[ColumnDictionary[nameof(MarkCust.StreetNo).ToLower()]].Replace("\"", ""),
						Suffix = lineSplit[ColumnDictionary[nameof(MarkCust.Suffix).ToLower()]].Replace("\"", ""),
						Zip = lineSplit[ColumnDictionary[nameof(MarkCust.Zip).ToLower()]].Replace("\"", "")
					});
				}

			}

			return markCusts;
		}

		private Dictionary<string, int> GetMarkCustColumns(string line)
		{
			Dictionary<string, int> keyValues = new Dictionary<string, int>();
			string[] header = line.Split(',');

			string[] columns =
				{ nameof(MarkCust.PreDir).ToLower(),
					nameof(MarkCust.Latitude).ToLower(),
					nameof(MarkCust.Longitude).ToLower(),
					nameof(MarkCust.PostDir).ToLower(),
					nameof(MarkCust.Size).ToLower(),
					nameof(MarkCust.StreetNm).ToLower(),
					nameof(MarkCust.StreetNo).ToLower(),
					nameof(MarkCust.Suffix).ToLower(),
					nameof(MarkCust.Zip).ToLower()
				};

			for (int i = 0; i < header.Count(); i++)
			{
				if(columns.Contains(header[i]))
				{
					keyValues.Add(header[i].ToLower(), i);
				}
			}

			return keyValues;
		}
	}
}

