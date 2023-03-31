﻿using DOMAIN;
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
        public List<Student> Students = new List<Student>();
        public List<Teacher> Teachers = new List<Teacher>();



        public LoginForm()
        {
            InitializeComponent();
            Student teststudent = new Student(2, "Bert", "123", "bert@mail.net");
            Teacher testteacher = new Teacher(3, "Jan", "321", "jan@mail.net");

            Students.Add(teststudent);
            Teachers.Add(testteacher);
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            foreach (Student student in Students)
            {
                if (student.Email == LoginEmail_Box.Text && student.Password == LoginPassword_Box.Text)
                {
                    Hide();
                    found = true;
                    StudentForm studentform = new StudentForm();
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
                    TeacherForm teacherform = new TeacherForm();
                    teacherform.Show();
                    break;
                }
            }

            if (!found)
            {
                LoginPassword_Box.Clear();
                IncorrectLabel.Show();
            }
        }
    }
}
