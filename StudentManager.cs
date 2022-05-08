using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_Status_Management_2._0
{
    internal class StudentManager
    {
        private List<Student> studentsList=new();

        public static void Add()
        {
            System.Windows.Window Addwindow  =new Window.AddWindow();
            Addwindow.ShowDialog();
        }

        public static void Find()
        {

        }

        public static void Show()
        {

        }

        public static void Sort()
        {

        }

        public static void Delete()
        {

        }


    }
}
