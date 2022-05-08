using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Status_Management_2._0
{
    public class WindowsManager
    {
        public static void Add()
        {
            System.Windows.Window Addwindow = new Window.AddWindow();
            Addwindow.ShowDialog();
        }

        public static void Find()
        {

        }

        public static void Show()
        {
            System.Windows.Window ShowWindow = new Window.ShowWindow();
            ShowWindow.ShowDialog();
            
        }

        public static void Sort()
        {
            Data.studentsList.Sort(delegate (Student p1, Student p2)
            {
                return p2.Gpa.CompareTo(p1.Gpa);//降序
            });
            int i = 1;
            foreach (Student p in Data.studentsList)
            {
                p.Rank = i;
                i++;
            }
           
            MessageBox.Show("排序成功");
        }

        public static void Delete()
        {

        }
    }
}
