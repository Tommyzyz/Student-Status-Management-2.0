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
    /// AddWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddWindow : System.Windows.Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            int[] score=new int[] { int.Parse(ChineseText.Text),int.Parse(MathText.Text),int.Parse(EnglishText.Text),int.Parse(PhysicsText.Text),int.Parse(C_Text.Text)};
            Student st = new Student(int.Parse(IdText.Text),NameText.Text,score);
            Data.studentsList.Add(st);
            MessageBox.Show("添加成功");
        }
    }
}
