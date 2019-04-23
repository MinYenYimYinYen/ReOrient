using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReOrient
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{
			if (e.Handled)
			{
				MessageBox.Show("A handled exception has occured.  Everything should be fine, though.", e.Exception.Message, MessageBoxButton.OK, MessageBoxImage.Information);
				throw e.Exception;
			}
			else
			{
				MessageBox.Show("An unhandled exception has occured.  Set a break point in App.xaml.cs before proceeding.  If this makes not sense, don't worry about it.  But, the program is probably about to crash.", e.Exception.Message, MessageBoxButton.OK, MessageBoxImage.Stop);
				throw e.Exception;
			}
		}
	}
}
