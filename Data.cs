using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Status_Management_2._0
{
    internal static class Data
    {
        internal static List<Student> studentsList = new();

        public static void SaveData()
        {
            List<string> fileList = new List<string>();
            for (int i = 0; i <studentsList .Count; i++)
            {
                fileList.Add(string.Format("{0}☆{1}☆{2}☆{3}☆{4}☆{5}☆{6}", studentsList[i].Id, studentsList[i].Name,studentsList[i].Grade[0], studentsList[i].Grade[1], studentsList[i].Grade[2], studentsList[i].Grade[3], studentsList[i].Grade[4]));
            }

            File.WriteAllLines("../data.ini", fileList.ToArray());
        }
        public static void LoadData()
        {
            try
            {
                string[] rfile = File.ReadAllLines("../data.ini");
                string[] sp = null;
                for (int i = 0; i < rfile.Length; i++)
                {
                    sp = rfile[i].Split('☆');
                    int[] score=new int[] { int.Parse(sp[2]), int.Parse(sp[3]), int.Parse(sp[4]), int.Parse( sp[5]), int.Parse( sp[6]) };
                    studentsList.Add(new Student(int.Parse(sp[0]), (sp[1]).ToString(), score));
                }

            }
            catch
            {
                return;
            }
        }

    }
}
