using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace WinFormTask4_LogBook
{
    public partial class Form1 : Form
    {
        Group myGroup = new Group("FBGS_1345_az","Windows Forms and WPF (CT-3)");
        public Form1()
        {
            #region
            InitializeComponent();
            DateTime dateTime = new DateTime(2023, 09, 7);
            Student student1 = new Student(1, "Elmira Ahmadova Ramil", dateTime.AddDays(1));
            Student student2 = new Student(2, "Aytan Qambarli Nuraddin", dateTime.AddDays(3));
            Student student3 = new Student(3, "Rahim Sariyev Togrul", dateTime.AddDays(2));
            Student student4 = new Student(4, "Fazil Aliyev Alakbar", dateTime.AddDays(3));
            Student student5 = new Student(5, "Aga Maliyev Bayram", dateTime.AddDays(2));
            Student student6 = new Student(6, "Firangiz Sabziyev Ali", dateTime.AddDays(3));
            Student student7 = new Student(7, "Shirali Nuriyev Abdulla", dateTime.AddDays(4));


            myGroup.students = new List<Student> { student1, student2,student3,student4,student5,student6,student7 };
          
          

            #endregion
        }






        private Stack<Control> _Stack = new Stack<Control>();
       



        private void Form1_Load(object sender, EventArgs e)
        {
            groupNameLbl.Text = myGroup.Name;
            subjectNameLbl.Text = myGroup.Subject;
            int y = 292;
            foreach (var student in myGroup.students)
            {
                var uc = new StudentsUserControl();
               
                uc.Location = new Point(11, y);
                uc.Id = student.Id;
                uc.FullName = student.FullName;
                uc.IsAtLesson = student.IsAtLesson;
                uc.LastEnterDate = student.LastEnterDate;
                student.InspectionWork = uc.InspectionWork;
                student.ClassWork = uc.ClassWork;
                student.Comment = uc.Comment;
                student.CrystalCount = uc.CrystalCount;
                y += 76;
                this.Controls.Add(uc);
                _Stack.Push(uc);
                
            }
        }
        private void mainTeacherRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!mainTeacherRBtn.Checked)
            {
                myGroup.IsMainTeacher = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myGroup.LessonName = lessonTxtb.Text;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            lessonTxtb.Clear();
            myGroup.LessonName = lessonTxtb.Text;
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
             myGroup.IsEveryoneAtLesson = true;
            foreach (var student in myGroup.students)
            {
                student.IsAtLesson = true;
                var lastAddedControl = _Stack.Peek();
                //Remove the control
                this.Controls.Remove(lastAddedControl);
                //Remove the reference to the control from the stack
                _Stack.Pop();
            }
            this.InitializeComponent();
            Form1_Load(sender, e);
        }


    }
}
