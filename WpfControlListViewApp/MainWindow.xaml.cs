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

namespace WpfControlListViewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBox list = new ListBox();
            list.Items.Add("Computer");
            list.Items.Add("Notebook");
            list.Items.Add("Printer");
            list.Items.Add("Phone");
            list.Items.Add("Sacnner");
            list.HorizontalAlignment = HorizontalAlignment.Left;

            TabItem tab4 = new TabItem();
            tab4.Header = "Products";
            tab4.Content = list;

            tabs.Items.Add(tab4);
        }
    }
}
