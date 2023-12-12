using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask4_LogBook
{
    public partial class StudentsUserControl : UserControl
    {
     

        //BINDING-class'in datasina colden bir shey yapishdirmaq.
        public int Id
        {
            set { numberLbl.Text = value.ToString(); }
        }
        public string FullName
        {
            get { return fullNameLbl.Text; }
            set { fullNameLbl.Text = value; }
        }

        public DateTime LastEnterDate
        {      
            set { lastEnterDateLbl.Text = value.ToShortDateString(); }
        }

        public int InspectionWork
        {
            get { return Convert.ToInt32(guna2ComboBox1.SelectedItem ); }
            set { InspectionWork = Convert.ToInt32(guna2ComboBox1.SelectedItem  ); }
        }
         public int ClassWork
        {
            get { return Convert.ToInt32(guna2ComboBox2.SelectedItem ); }
            set { ClassWork= Convert.ToInt32(guna2ComboBox2.SelectedItem ); }
        }
       
         public int CrystalCount
        {

            get
            {
                if (dimondBtn1.Checked)
                {
                    return 1;
                }
                else if (dimondBtn2.Checked)
                {
                    return 2;
                }
                else if(dimondBtn3.Checked)
                {
                    return 3;
                }
                else
                {
                    return 0;
                    //throw new Exception();
                }
            }

            set
            {
                CrystalCount = value;

            }
        }
      

        public bool IsAtLesson
        {
            get
            {
                if (guna2CustomRadioButton1.Checked || guna2CustomRadioButton2.Checked)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    guna2CustomRadioButton1.Checked = true;
                }

            }
        }


     

        public string Comment
        {
            get { return textBox.Text; }
            set { Comment = textBox.Text; }
        }




        public StudentsUserControl()
        {
            InitializeComponent();
            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> numberList2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            guna2ComboBox1.DataSource = numberList;
            guna2ComboBox1.SelectedIndex =-1;
             guna2ComboBox2.DataSource = numberList2;
            guna2ComboBox2.SelectedIndex = -1;

        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(InspectionWork.ToString());
        }
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
;
          // MessageBox.Show(ClassWork.ToString());
        }

        TextBox textBox = new TextBox();
        private void messageBtn_Click(object sender, EventArgs e)
        {
  
            textBox.Width = 215;
            
            textBox.Location=new Point(messageBtn.Location.X,messageBtn.Location.Y-18);
            this.Controls.Remove(messageBtn);
            textBox.Font = new Font("Segoe UI", 11);
            this.Controls.Add(textBox);
           
            Button comment = new Button();
            comment.AutoSize = true;
            comment.Text = "Rəy yazmaq";
            comment.BackColor = Color.RoyalBlue;
            comment.Font = new Font("Segoe UI", 11);
            comment.Location = new Point(textBox.Location.X, textBox.Location.Y + 32);
             Button cancel = new Button();
            cancel.AutoSize = true;
            cancel.Text = "Ləğv etmək";
            cancel.BackColor = Color.RoyalBlue;
            cancel.Font = new Font("Segoe UI", 11);
            cancel.Location = new Point(textBox.Location.X+120, textBox.Location.Y + 32);
            this.Controls.Add(comment);
            this.Controls.Add(cancel);
            cancel.Click += cancel_Click;
            comment.Click += comment_Click;
           void cancel_Click(object sender1,EventArgs e1)
            {
                textBox.Text = "";
            }
            void  comment_Click(object sender1,EventArgs e1)
            {              
               MessageBox.Show($"Comment : {Comment}");
            }


        }

            Button button = new Button();
        private void dimondBtn1_Click(object sender, EventArgs e)
        {
            button.Location =new Point(dimondBtn1.Location.X-6, dimondBtn1.Location.Y-8);
            this.Controls.Remove(dimondBtn1);
            button.BackgroundImage = Properties.Resources.myDimond;
            button.Size = new Size(33,40);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.BackColor = Color.White;
            this.Controls.Add(button);
           // CrystalCount = 1;
           // MessageBox.Show(CrystalCount.ToString());
          
        }

            Button button2 = new Button();
        private void dimondBtn2_Click(object sender, EventArgs e)
        {
            dimondBtn1_Click(sender, e);
            button2.Location = new Point(dimondBtn2.Location.X - 6, dimondBtn2.Location.Y - 8);
            this.Controls.Remove(dimondBtn2);
            button2.BackgroundImage = Properties.Resources.myDimond;
            button2.Size = new Size(33, 40);
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackColor = Color.White;
            this.Controls.Add(button2);
        }

            Button button3 = new Button();
        private void dimondBtn3_Click(object sender, EventArgs e)
        {
            dimondBtn1_Click(sender, e);
            dimondBtn2_Click(sender, e);
            button3.Location = new Point(dimondBtn3.Location.X - 6, dimondBtn3.Location.Y - 8);
            this.Controls.Remove(dimondBtn3);
            button3.BackgroundImage = Properties.Resources.myDimond;
            button3.Size = new Size(33, 40);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackColor = Color.White;
            this.Controls.Add(button3);
            //CrystalCount = 3;
        }
    }
}
