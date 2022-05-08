using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public static void Delete()
        {

        }
    }
}
