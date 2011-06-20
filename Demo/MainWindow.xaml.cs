using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Lazy<Views.Home> HomePage = new Lazy<Views.Home>(() => new Views.Home());
		private Lazy<Views.Core> CorePage = new Lazy<Views.Core>(() => new Views.Core());
		//private Lazy<Views.Home> SDKPage = new Lazy<Views.Home>(() => new Views.Home());
		//private Lazy<Views.Home> ToolkitPage = new Lazy<Views.Home>(() => new Views.Home());

		public MainWindow()
		{
			InitializeComponent();

			ContentFrame.Content = HomePage.Value;
		}

		private void ButtonHome_Click(object sender, RoutedEventArgs e)
		{
			if (ContentFrame.Content != HomePage.Value)
				ContentFrame.Content = HomePage.Value;
		}
		private void ButtonCore_Click(object sender, RoutedEventArgs e)
		{
			if (ContentFrame.Content != CorePage.Value)
				ContentFrame.Content = CorePage.Value;
		}
		private void ButtonSDK_Click(object sender, RoutedEventArgs e)
		{
		}
		private void ButtonToolkit_Click(object sender, RoutedEventArgs e)
		{
		}
	}
}
