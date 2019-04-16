using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class MarkCust : IMarkCust
	{
		public string StreetNo { get; set; }

		public string PreDir { get; set; }

		public string StreetNm  { get; set; }

		public string Suffix { get; set; }

		public string PostDir { get; set; }

		public string Zip { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public double? Size { get; set; }
	}
}
