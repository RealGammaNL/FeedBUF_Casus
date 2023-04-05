using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;
using System.Windows.Forms;

namespace FeedBUF_Casus.Forms
{
    public partial class StudentForm : Form
    {
        public Student CurrentStudent;
        public static string FeedbackSelection;
        public StudentForm(Student student)
        {
            InitializeComponent();

            SyncFeedback();

            CurrentStudent = student;
            LoginStudent(student);

            panels.Add(pnlFeedback);
            panels.Add(pnlFeedforward);
            panels.Add(pnlFeedup);
            panels.Add(pnlConclusion);
        }

        public List<Panel> panels = new List<Panel>() { };
        // aanpassen met de panels in de form

        private void SyncFeedback()
        {
            List<Feedback> TotalFeedback = Feedback.GetFeedback();
            dgvFeedback.Rows.Clear();

            foreach (Feedback feedback in TotalFeedback)
            {
                DataGridViewRow row = (DataGridViewRow)dgvFeedback.Rows[0].Clone();
                row.Cells[0].Value = feedback.FeedbackID;
                row.Cells[1].Value = feedback.Auteur;
                row.Cells[2].Value = feedback.Title;
                row.Cells[3].Value = feedback.Description;
                dgvFeedback.Rows.Add(row);
            }
        }

        private void LoginStudent(Student student)
        {
            lblStudentName.Text = student.Fullname;
            lblStudentClass.Text = student.GroupID;
        }
        private void Switchpanel(object sender, EventArgs e)
        {
            string selectedChoice = cbxPanelSwitch.Text;
            string selectedPnl = "pnl" + selectedChoice;

            HidePanels();
            foreach (Panel panel in panels)
            {
                if (panel.Name == selectedPnl)
                {
                    panel.Show();
                }
            }
        }

        private void HidePanels()
        {
            foreach (Panel p in panels)
            {
                p.Hide();
            }
        }

        private void pnlFeedup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void txbFeedbackDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFeedup_SwitchLearngoal_Click(object sender, EventArgs e)
        {
            pnlActivity.Hide();
            pnlLearngoal.Show();
        }

        private void btnFeedup_SwitchActivity_Click(object sender, EventArgs e)
        {
            pnlActivity.Show();
            pnlLearngoal.Hide();
        }

        private void btnAddLearnGoal_Click(object sender, EventArgs e)
        {
            string learngoal = txbFeedup_Learngoal.Text;
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            string Activity = txbFeedup_Activitity.Text;
            string TimeEstimation = txbFeedup_TimeEstimation.Text;
        }

        private void btnFeedbackAdd_Click(object sender, EventArgs e)
        {
            string Teacher = txbFeedbackTeacher.Text;
            string Title = txbFeedbackTitle.Text;
            string Description = txbFeedbackDescription.Text;
        }

        private void btnVraagStellen_Click(object sender, EventArgs e)
        {
            pnlAskQuestion.Show();
            pnlRegisterFeedback.Hide();
            FeedbackSelection = "Question";
            dgvFeedback.ClearSelection();
            txbQuestionTitle.Clear();
            txbQuestionDescription.Clear();
            lblQuestionTeacher.Text = "Auteur";
        }

        private void btnRegisterFeedback_Click(object sender, EventArgs e)
        {
            pnlAskQuestion.Hide();
            pnlRegisterFeedback.Show();
            FeedbackSelection = "Register";
            dgvFeedback.ClearSelection();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Closes the studentform
            this.Close();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void dgvFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fills the questionpanel and feedbackpanel
            foreach (DataGridViewRow row in dgvFeedback.SelectedRows)
            {
                if (FeedbackSelection == "Question")
                {
                    txbQuestionTitle.Text = (string)row.Cells[2].Value;
                    txbQuestionDescription.Text = (string)row.Cells[3].Value;
                    lblQuestionTeacher.Text = (string)row.Cells[1].Value;
                }

                if (FeedbackSelection == "Register")
                {

                }
            }
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
