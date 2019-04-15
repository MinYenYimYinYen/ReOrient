using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class CSVControl
	{
		public static ObservableCollection<MarkCust> LoadMarkCustsFromCSV(string csvPath)
		{
			ObservableCollection<MarkCust> markCusts = new ObservableCollection<MarkCust>();

			FileStream fileStream = new FileStream(csvPath, FileMode.Open);
			StreamReader streamReader = new StreamReader(fileStream);

			string line = streamReader.ReadLine();
			var markCustColumns = GetMarkCustColumns(line);

			while((line = streamReader.ReadLine()) != null)
			{
				string[] lineSplit = line.Split(',');

				markCusts.Add(new MarkCust
				{
					PreDir = lineSplit[markCustColumns[nameof(MarkCust.PreDir)]],
					Latitude =Convert.ToDouble( lineSplit[markCustColumns[nameof(MarkCust.Latitude)]]),
					Longitude =Convert.ToDouble( lineSplit[markCustColumns[nameof(MarkCust.Longitude)]]),
					PostDir = lineSplit[markCustColumns[nameof(MarkCust.PostDir)]],
					Size = Convert.ToDouble( lineSplit[markCustColumns[nameof(MarkCust.Size)]]),
					StreetNm = lineSplit[markCustColumns[nameof(MarkCust.StreetNm)]],
					StreetNo = lineSplit[markCustColumns[nameof(MarkCust.StreetNo)]]
				});
			}

			return markCusts;
		}


		private static Dictionary<string, int> GetMarkCustColumns(string line)
		{
			Dictionary<string, int> keyValues = new Dictionary<string, int>();
			List<string> header = line.Split(',').ToList();
			throw new NotImplementedException();
		}
	}
}

