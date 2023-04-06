using DAL;
using DOMAIN;
using FeedBUF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUF_Casus.Forms
{
    public partial class LoginForm : Form
    {
        public List<Student> Students = StudentDAL.GetStudents();
        public List<Teacher> Teachers = new List<Teacher>();



        public LoginForm()
        {
            InitializeComponent();
            this.btnPasswordHelp.FlatAppearance.BorderSize = 0;
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (Student student in Students)
            {
                if (student.Email == LoginEmail_Box.Text && student.Password == LoginPassword_Box.Text)
                {
                    this.Hide();
                    found = true;
                    StudentForm studentform = new StudentForm(student);
                    LoginEmail_Box.Clear();
                    LoginPassword_Box.Clear();
                    studentform.Show();
                    break;
                }
            }
              
            foreach (Teacher teacher in Teachers) 
            {
                if (teacher.Email == LoginEmail_Box.Text && teacher.Password == LoginPassword_Box.Text)
                {
                    Hide();
                    found = true;
                    //TeacherForm teacherform = new TeacherForm(teacher);
                    LoginEmail_Box.Clear();
                    LoginPassword_Box.Clear();
                    //teacherform.Show();
                    break;
                }
            }

            if (!found)
            {
                LoginPassword_Box.Clear();
                IncorrectLabel.Show();
            }
        }

        private void btnCreateAccountPanel_Click(object sender, EventArgs e)
        {
            LoginPanel.Hide();
            pnlCreateAccount.Show();
            lblStatus.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlCreateAccount.Hide();
            LoginPanel.Show();
            txbStudentNumber.Clear();
            txbGroup.Clear();
            txbName.Clear();
            txbNewEmail.Clear();
            txbNewPassword.Clear();
            txbNewPasswordRepeat.Clear();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txbNewPassword.Text == txbNewPasswordRepeat.Text)
            {
                Student student = new Student(Int32.Parse(txbStudentNumber.Text), txbGroup.Text, txbName.Text, txbNewEmail.Text, txbNewPasswordRepeat.Text);
                StudentDAL.AddStudent(student);
                txbStudentNumber.Clear();
                txbGroup.Clear();
                txbName.Clear();
                txbNewEmail.Clear();
                txbNewPassword.Clear();
                txbNewPasswordRepeat.Clear();
                lblStatus.Text = "Gelukt!";
                Students.Add(student);
            }
            else
            {
                lblStatus.Text = "Wachtwoord komt niet overeen";
            }
        }
    }
}
