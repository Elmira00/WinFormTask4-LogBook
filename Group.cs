using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTask4_LogBook
{
    public class Group
    {
        public Group(string name,string subject)
        {
            Name = name;
            Subject = subject;
        }

        public string Name { get; set; }
        public string Subject { get; set; }
        public string LessonName { get; set; } = "";
        public int CrystalCount { get; set; } = 5;
        public bool IsEveryoneAtLesson { get; set; } = false;
        public bool IsMainTeacher { get; set; } = true;
        public List<Student> students { get; set; } 

       
    }
}
