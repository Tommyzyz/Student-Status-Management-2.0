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
using System.Windows.Shapes;

namespace Student_Status_Management_2._0.Window
{
    /// <summary>
    /// ShowWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ShowWindow :System.Windows.Window
    {
        public ShowWindow()
        {
            InitializeComponent();
            ShowText.Text = "姓名\t学号\t学分绩\t排名\t\r\n";
            foreach (Student student in Data.studentsList)
            {
                ShowText.Text += student.Name+"\t"+student.Id + "\t" +student.Gpa.ToString("F2") + "\t" +student.Rank+ "\r\n";
            }
            
        }
    }
}
