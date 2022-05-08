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
    /// FindWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FindWindow : System.Windows.Window
    {
        public FindWindow()
        {
            InitializeComponent();
 
        }

        public Student FindStudent()
        {
            var p1 = Data.studentsList.Find(delegate (Student temp)
            {
                return temp.Name == TextName.Text || temp.Id.ToString() == TextId.Text;
            });
            if (p1.GetType() == typeof(Student))
            {
                return p1;
            }
            else
            {
                return null;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var p1=FindStudent();
            if(p1 ==null )
            {
                TextFindOut.Text = "未查询到此人!";
            }
            else
            {
                TextFindOut.Text = "姓名" + p1.Name + "\t" + "学号" + p1.Id + "\t" + "学分绩" + p1.Gpa + "\t" + "排名" + p1.Rank + "\t\r\n";
            
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var p1 = FindStudent();
            if(p1 !=null)
            {
                Data.studentsList.Remove(p1);
                MessageBox.Show("删除成功");
            }
        }
    }
}
