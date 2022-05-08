using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Status_Management_2._0
{
    internal class Student
    {
        private Student(int id, string name,int[] score)
        {
            this.Id = id;
            this.Name = name;
            this.score =score;
            this.gpa = 0;
            this.Rank = 0;
        }

        private int id;               //学号
        private int[]  score;         //成绩
        private double gpa;           //学分绩 
        private int rank;             //排名 

        public int Id { get => id; set => id = value; }
        public string Name { get; set; } = String.Empty;
        public double Gpa { get => gpa; set => gpa = value; }
        public int Rank { get => rank; set => rank = value; }
        public int[] Grade { get => score; set => score = value; }
    }
}
