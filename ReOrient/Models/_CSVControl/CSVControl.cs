using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class MarkCustCSVControl : ICSVControl<IMarkCust>
	{
		private readonly string[] _markCustColumns;

		public MarkCustCSVControl()
		{
			_markCustColumns = new string[]
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
		}
		public IEnumerable<IMarkCust> GetObjectsFromCSV(string csvPath)
		{
			try
			{
				ObservableCollection<MarkCust> markCusts = new ObservableCollection<MarkCust>();

				string[] lines = GetCSVLines(csvPath);

				Dictionary<string, int> ColumnDictionary = GetColumnDictionary(lines[0]);
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
			catch (IOException ex)
			{

				throw ex;
			}
			throw new Exception(nameof(GetObjectsFromCSV));
		}

		public string[] GetCSVLines(string csvPath)
		{
			FileStream fileStream;
			try
			{
				fileStream = new FileStream(csvPath, FileMode.Open);
				StreamReader streamReader = new StreamReader(fileStream);
				string wholeText = streamReader.ReadToEnd();
				wholeText = wholeText.Replace("\r\n", "NeVeRoDdOrEvEn").Replace("\r", ";").Replace("NeVeRoDdOrEvEn", "\n");

				string[] lines = wholeText.Split('\n');
				streamReader.Dispose();
				streamReader = null;
				return lines;
			}
			catch (IOException ex)
			{
				
				throw ex;
			}

			throw new Exception(nameof(GetCSVLines));
		


		}

		public Dictionary<string, int> GetColumnDictionary(string headerLine)
		{
			Dictionary<string, int> keyValues = new Dictionary<string, int>();
			string[] headerArray = headerLine.Split(',');



			for (int i = 0; i < headerArray.Count(); i++)
			{
				if (_markCustColumns.Contains(headerArray[i].ToLower()))
				{
					keyValues.Add(headerArray[i].ToLower(), i);
				}
			}

			return keyValues;
		}
	}
}

