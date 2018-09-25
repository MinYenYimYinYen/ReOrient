using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOrient.Models
{
	public class MapController
	{
		public string MapCenter
		{
			get
			{
				return "20,20";
			}
		}
		public string MapMode { get; set; }
		public ObservableCollection<Record> Records { get; set; }
	}
}
