using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public interface ICSVControl<TObj>
	{
		IEnumerable<TObj> GetObjectsFromCSV(string csvPath);
	}
}
