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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowsManager.Add();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            WindowsManager.Find();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            WindowsManager.Show();
        }

        private void ButtonSort_Click(object sender, RoutedEventArgs e)
        {
            WindowsManager.Sort();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Data.SaveData();
            MessageBox.Show("保存成功");
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            Data.LoadData();
            MessageBox.Show("加载成功");
        }
    }
}
