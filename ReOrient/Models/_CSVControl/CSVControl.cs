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

			string[] lines = GetCSVLines(csvPath);

			Dictionary<string, int> ColumnDictionary = GetMarkCustColumns(lines[0]);
			for (int i = 1; i < lines.Count() - 1; i++)
			{
				markCusts.Add(new MarkCust(lines[i], ColumnDictionary)
				{
					CSVRowIndex = i,
					FilePath = csvPath
				});
			}

			return markCusts;
		}

		public static string[] GetCSVLines(string csvPath)
		{
			FileStream fileStream = new FileStream(csvPath, FileMode.Open);
			StreamReader streamReader = new StreamReader(fileStream);

			string wholeText = streamReader.ReadToEnd();
			wholeText = wholeText.Replace("\r\n", "~~~").Replace("\r", ";").Replace("~~~", "\n");

			string[] lines = wholeText.Split('\n');
			streamReader.Dispose();
			streamReader = null;
			return lines;
		}

		public static Dictionary<string, int> GetMarkCustColumns(string line)
		{
			Dictionary<string, int> keyValues = new Dictionary<string, int>();
			string[] header = line.Split(',');

			string[] columns =
				{
					nameof(MarkCust.Cust_No).ToLower(),
					nameof(MarkCust.PreDir).ToLower(),
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

