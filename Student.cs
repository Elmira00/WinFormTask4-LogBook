using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTask4_LogBook
{
    public class Student
    {
        public Student(int id, string fullName, DateTime lastEnterDate)
        {
            Id = id;
            FullName = fullName;
            LastEnterDate = lastEnterDate;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime LastEnterDate { get; set; }
        public int InspectionWork { get; set; } = 0;
        public int ClassWork { get; set; } = 0;
        public int CrystalCount { get; set; } = 0;
        public string Comment { get; set; } = "";
        public bool IsAtLesson { get; set; } = false;
    }
}
