using Microsoft.Maps.MapControl.WPF;
using ReOrient.Commands;
using ReOrient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
		[Obsolete]
		private string zipCode;
		private int _loadCount = 10;

		public MainWindow()
		{
			InitializeComponent();
		}

		public string MapCenter => "45.26653,-93.77274";
		//public string MapMode { get; set; }

		public IEnumerable<IMarkCust> MarkCusts => new CSVControl().GetMarkCustsFromCSV(CSVPath);


		private ObservableCollection<Record> records;
		public ObservableCollection<Record> Records
		{
			get
			{
				if (records == null)
				{
					records = new ObservableCollection<Record>();
				}

				return records;
			}
			set
			{

				records = value;
			}
		}

		private string _cSVPath = @"D:\SharePoint\GM Lawncare Inc\Boss Group - Documents\Big Data\Post Apocalypse\BLOCKLEADTEST.CSV";
		public string CSVPath
		{
			get
			{
				return _cSVPath;
			}
			set
			{
				_cSVPath = value;
			}
		}

		private double? sizeLo;
		public double? SizeLo
		{
			get
			{
				return sizeLo;
			}
			set
			{
				sizeLo = value;
			}
		}

		private double? sizeHi;
		public double? SizeHi
		{
			get
			{
				return sizeHi;
			}
			set
			{
				sizeHi = value;
			}
		}

		public int LoadCount
		{
			get
			{
				return _loadCount;
			}
			set
			{
				try
				{

					_loadCount = value;
					if (_loadCount < 1)
					{
						LoadCount = 1;
					}
				}
				catch (Exception)
				{
					_loadCount = 10;
					throw;
				}
			}
		}

		private static bool hennepinMode = false;
		public static bool HennepinMode
		{
			get { return hennepinMode; }
			set
			{
				hennepinMode = value;
			}
		}




		private void LoadRecords()
		{
			ObservableCollection<Record> recs = new ObservableCollection<Record>();
			foreach (IMarkCust mark in MarkCusts)
			{
				recs.Add(new Record { MarkCust = mark });
			}

			//Filter by Size
			IEnumerable<Record> filterSize = recs.Where(r => r.Size >= SizeLo)
				.Where(r => r.Size <= SizeHi).ToList()
				.Take(LoadCount);



			//Add the records
			Dispatcher.Invoke(() => Records.Clear());
			foreach (Record mark in filterSize)
			{
				Dispatcher.Invoke(() => Records.Add(new Record { MarkCust = mark.MarkCust }));
			}
		}

		private bool CanLoadRecords()
		{
			return SizeLo != null && SizeHi != null && File.Exists(CSVPath);
		}

		private void Disappear(object sender, RoutedEventArgs e)
		{
			DependencyObject btn = (DependencyObject)sender;

			try
			{
				TextBox sizeBox = (TextBox)sender;
				if(sizeBox.Name == "txt_Size")
				{
					if(string.IsNullOrWhiteSpace(sizeBox.Text) || sizeBox.Text  == "0")
					{
						return;
					}
				}
			}
			catch (Exception)			{			}

			DependencyObject x = VisualTreeHelper.GetParent(btn);
			DependencyObject y = VisualTreeHelper.GetParent(x);
			DependencyObject z = VisualTreeHelper.GetParent(y);
			DependencyObject a = VisualTreeHelper.GetParent(z);
			DependencyObject b = VisualTreeHelper.GetParent(a);

			Pushpin c = (Pushpin)VisualTreeHelper.GetParent(b);
			c.Visibility = Visibility.Collapsed;
		}

		private void btn_Address_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			Record record = (Record)button.DataContext;
			try
			{
				if (HennepinMode)
				{
					Clipboard.SetText(record.HennepinModeCopy);
				}
				else
				{
					Clipboard.SetText(record.Address);
				}
				//Clipboard.SetText(button.Content.ToString());
			}
			catch (Exception)
			{

			}

		}

		private void Btn_Load_Click(object sender, RoutedEventArgs e)
		{
			if (CanLoadRecords())
			{
				LoadRecords();
			}
		}
	}
}
