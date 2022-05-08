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

namespace Student_Status_Management_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StudentManager studentManager =new();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            StudentManager.Add();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            StudentManager.Find();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            StudentManager.Show();
        }

        private void ButtonSort_Click(object sender, RoutedEventArgs e)
        {
            StudentManager.Sort();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            StudentManager.Delete();
        }
    }
}
