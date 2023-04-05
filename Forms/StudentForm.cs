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
        private void SyncLearngoals(Student student)
        {
            string[] attributes = cbxWeek.Text.Split(' ');
            int weeknumber = Int32.Parse(attributes[1]);
            string Subjectname = cbxSubject.Text;
            List<LearnGoal> TotalLearngoal = LearnGoal.GetLearnGoals(student, weeknumber, Subjectname);
            dgvLearnGoals.Rows.Clear();

            foreach (LearnGoal goal in TotalLearngoal)
            {
                DataGridViewRow row = (DataGridViewRow)dgvLearnGoals.Rows[0].Clone();
                row.Cells[0].Value = goal.LearnGoalID;
                row.Cells[1].Value = goal.Goal;
                dgvLearnGoals.Rows.Add(row);
            }
        }
        private void SyncActivities(Student student)
        {
            DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
            int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            List<Activity> TotalActivity = Activity.GetActivity(learngoalid);
            dgvActivities.Rows.Clear();

            foreach (Activity activity in TotalActivity)
            {
                DataGridViewRow row = (DataGridViewRow)dgvActivities.Rows[0].Clone();
                row.Cells[0].Value = activity.ActivityID;
                row.Cells[1].Value = activity.ActivityText;
                row.Cells[2].Value = activity.TimeEstimate;
                dgvActivities.Rows.Add(row);
                if(activity.TimeSpent != "")
                {
                    row.Cells[3].Value = true;
                }
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
            pnlTimeSpent.Hide();
        }

        private void btnFeedup_SwitchActivity_Click(object sender, EventArgs e)
        {
            pnlActivity.Show();
            pnlLearngoal.Hide();
            pnlTimeSpent.Hide();
        }

        private void btnAddLearnGoal_Click(object sender, EventArgs e)
        {
            string learngoal = txbFeedup_Learngoal.Text;
            string[] attributes = cbxWeek.Text.Split(' ');
            int weeknumber = Int32.Parse(attributes[1]);
            LearnGoal learnGoal = new LearnGoal(CurrentStudent.ID, cbxSubject.Text, weeknumber, learngoal) { };
            DAL.FeedupDAL.AddLearngoal(learnGoal);
            txbFeedup_Learngoal.Text = "";
            SyncLearngoals(CurrentStudent);
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (dgvLearnGoals.CurrentRow != null)
            {
                string Activity = txbFeedup_Activitity.Text;
                string TimeEstimation = txbFeedup_TimeEstimation.Text;
                DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
                int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Activity activity = new Activity(learngoalid, Activity, TimeEstimation);
                DAL.FeedupDAL.AddActivity(activity);
                txbFeedup_Activitity.Text = "";
                txbFeedup_TimeEstimation.Text = "";
                SyncActivities(CurrentStudent);
            }
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

        private void WeekChanged(object sender, EventArgs e)
        {
            SyncLearngoals(CurrentStudent);
            dgvActivities.Rows.Clear();
        }

        private void SubjectChanged(object sender, EventArgs e)
        {
            SyncLearngoals(CurrentStudent);
            dgvActivities.Rows.Clear();
        }

        private void dgvLearnGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SyncActivities(CurrentStudent);
        }

        private void dgvActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlActivity.Hide();
            pnlLearngoal.Hide();
            pnlTimeSpent.Show();
        }

        private void btnSaveTimeSpent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvActivities.Rows[dgvActivities.CurrentCell.RowIndex];
            int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string TimeSpent = txbTimeSpent.Text;
            Activity.InsertTimeSpent(activityid, TimeSpent);
            pnlTimeSpent.Visible = false;
            pnlLearngoal.Show();
        }
    }
}
