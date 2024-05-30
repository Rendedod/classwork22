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

namespace WPF22._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearZ_Click(object sender, RoutedEventArgs e)
        {
            DoList.Items.Clear();
        }

        private void ListZ_Click(object sender, RoutedEventArgs e)
        {
            if(DoList.Visibility == Visibility.Visible)
            {
                DoList.Visibility = Visibility.Hidden;
            }
            else
            {
                DoList.Visibility = Visibility.Visible;
            }
        }

        private void AddZ_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text != "")
            {
                DoList.Items.Add(tb.Text);
                tb.Text = "";
            }
        }
    }
}
