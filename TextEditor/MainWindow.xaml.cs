using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TextEditor
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

		private void BtnCopy_Click(object sender, RoutedEventArgs e)
		{
			textBox.Copy();
		}
		private void BtnPaste_Click(object sender, RoutedEventArgs e)
		{
			textBox.Paste();
		}
		private void BtnCut_Click(object sender, RoutedEventArgs e)
		{
			textBox.Cut();
		}
	}
}
