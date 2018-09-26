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

		private ObservableCollection<Record> records;
		public ObservableCollection<Record> Records
		{
			get
			{
				if (records == null) records = new ObservableCollection<Record>();
				return records;
			}
			set
			{
				records = value;
			}
		}

		private decimal? sizeLo;
		public decimal? SizeLo
		{
			get
			{
				return sizeLo;
			}
			set
			{
				sizeLo = value;
				LoadRecords();
			}
		}

		private decimal? sizeHi;
		public decimal? SizeHi
		{
			get
			{
				return sizeHi;
			}
			set
			{
				sizeHi = value;
				LoadRecords();
			}
		}

		private string zipCode;
		public string ZipCode
		{
			get
			{
				return zipCode;
			}
			set
			{
				zipCode = value;
				LoadRecords();
			}
		}

		private void LoadRecords()
		{
			if (SizeLo != null && SizeHi != null)
			{
				if (zipCode.Length == 5)
				{
					using (var sa = new SA.SAEntities1())
					{
						var recs = new ObservableCollection<Record>();

						//Filter By Zip
						foreach (var mark in sa.markcusts
							.Where(m => m.zip.Trim().Substring(0, 5) == zipCode))

						{
							recs.Add(new Record { MarkCust = mark });
						}

						//Filter by Size
						var rMe = new ObservableCollection<Record>(); 
						var filterSize = recs.Where(r => r.Size >= SizeLo)
							.Where(r => r.Size <= SizeHi).ToList();

						foreach (var mark in filterSize)
						{
							rMe.Add(new Record { MarkCust = mark.MarkCust });
						}

						Records = rMe;
					}
				}
			}
		}
	}
}
