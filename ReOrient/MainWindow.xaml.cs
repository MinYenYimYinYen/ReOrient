using Microsoft.Maps.MapControl.WPF;
using ReOrient.Commands;
using ReOrient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReOrient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()



		{
			InitializeComponent();
		}
		public static SA.SADBContext sa = new SA.SADBContext();
		public string MapCenter
		{
			get
			{
				return "45.26653,-93.77274";
			}
		}
		//public string MapMode { get; set; }

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
				LoadRecordsOnThread();
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
				LoadRecordsOnThread();
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
				LoadRecordsOnThread();
			}
		}


		private static bool hennepinMode = false;
		public static bool HennepinMode
		{
			get { return hennepinMode; }
			set
			{
				hennepinMode = value ;
			}
		}
		private void LoadRecordsOnThread()
		{
			Thread t = new Thread(new ThreadStart(this.LoadRecords));
			t.Start();
		}

		private void LoadRecords()
		{
			if (SizeLo != null && SizeHi != null)
			{
				if (zipCode.Length == 5)
				{

					var recs = new ObservableCollection<Record>();

					//Filter By Zip
					foreach (var mark in sa.markcusts
						.Where(m => m.zip.Trim().Substring(0, 5) == zipCode))

					{
						recs.Add(new Record { MarkCust = mark });
					}

					//Filter by Size
					//var rMe = new ObservableCollection<Record>();
					var filterSize = recs.Where(r => r.Size >= SizeLo)
						.Where(r => r.Size <= SizeHi).ToList()
						.Take(500);

					//Filter IsDupes
					//int IsDupe = 685;
					//var custFlag = MainWindow.sa.custflags.Where(cf => cf.flag == IsDupe);


					//Add the records
					this.Dispatcher.Invoke(() => Records.Clear());
					foreach (var mark in filterSize)
					{
						this.Dispatcher.Invoke(() => Records.Add(new Record { MarkCust = mark.MarkCust }));
					}
				}
			}
		}

		private void Disappear(object sender, RoutedEventArgs e)
		{
			var btn = (DependencyObject)sender;
			var x = VisualTreeHelper.GetParent(btn);
			var y = VisualTreeHelper.GetParent(x);
			var z = VisualTreeHelper.GetParent(y);
			var a = VisualTreeHelper.GetParent(z);
			var b = VisualTreeHelper.GetParent(a);

			Pushpin c = (Pushpin)VisualTreeHelper.GetParent(b);
			c.Visibility = Visibility.Collapsed;
		}

		private void btn_Address_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			Record record = (Record)button.DataContext;
			try
			{
				if(HennepinMode)				Clipboard.SetText(record.HennepinModeCopy);
				else Clipboard.SetText(record.Address);
				//Clipboard.SetText(button.Content.ToString());
			}
			catch (Exception)
			{

			}

		}


	}
}
