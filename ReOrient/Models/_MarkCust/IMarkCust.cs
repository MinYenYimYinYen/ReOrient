using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public interface IMarkCust
	{
		string StreetNo { get; }
		string PreDir { get; set; }
		string StreetNm { get; }
		string Suffix { get; }
		string PostDir { get; set; }
		string Zip { get; }

		double Latitude { get; set; }
		double Longitude { get; set; }

		double? Size { get; set; }
	}
}
