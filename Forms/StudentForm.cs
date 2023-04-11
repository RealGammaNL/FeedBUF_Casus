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
            dgvSubjects_Sync();

            panels.AddRange(new Panel[] { pnlFeedback, pnlFeedforward, pnlFeedup, pnlConclusion, pnlHome });
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
                row.Cells[1].Value = feedback.Teacher;
                row.Cells[2].Value = feedback.Title;
                row.Cells[3].Value = feedback.Description;
                dgvFeedback.Rows.Add(row);
            }
        }
        private void SyncLearngoals()
        {
            if (cbxWeek.Text != "")
            {
                string[] attributes = cbxWeek.Text.Split(' ');
                int weeknumber = Int32.Parse(attributes[1]);
                string Subjectname = cbxSubject.Text;
                List<LearnGoal> TotalLearngoal = LearnGoal.GetLearnGoals(CurrentStudent, weeknumber, Subjectname);
                dgvLearnGoals.Rows.Clear();

                foreach (LearnGoal goal in TotalLearngoal)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvLearnGoals.Rows[0].Clone();
                    row.Cells[0].Value = goal.LearnGoalID;
                    row.Cells[1].Value = goal.Goal;
                    dgvLearnGoals.Rows.Add(row);
                }
            }
        }
        private void SyncActivities()
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
                    row.Cells[3].ReadOnly = true;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            cbxPanelSwitch.SelectedItem = null;
            cbxWeek.SelectedItem = null;
            cbxSubject.SelectedItem = null;
            HidePanels();
            pnlHome.Show();
            dgvLearnGoals.Rows.Clear();
        }

        private void pnlFeedup_Paint(object sender, PaintEventArgs e)
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
            txbFeedup_Learngoal.Clear();
            SyncLearngoals();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (dgvLearnGoals.CurrentRow != null)
            {
                string activityStr = txbFeedup_Activitity.Text;
                string timeEstimation = txbFeedup_TimeEstimation.Text;
                DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
                int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Activity activity = new Activity(learngoalid, activityStr, timeEstimation);
                Activity.AddActivity(activity);
                txbFeedup_Activitity.Clear();
                txbFeedup_TimeEstimation.Clear();
                SyncActivities();
            }
        }

        private void btnFeedbackAdd_Click(object sender, EventArgs e)
        {
            int StudentID = CurrentStudent.ID;
            int LearnGoalID = Int32.Parse(cbxLearnGoal.Text.ToString());
            string Auteur = txbFeedbackTeacher.Text;
            string Title = txbFeedbackTitle.Text;
            string Description = txbFeedbackDescription.Text;

            txbFeedbackTeacher.Clear();
            txbFeedbackTitle.Clear();
            txbFeedbackDescription.Clear();

            // If there is an activity selected.
            if (cbxActivity.Text != "")
            {
                int ActivityID = Int32.Parse(cbxActivity.Text.ToString());
                Feedback feedback = new Feedback(StudentID, LearnGoalID, ActivityID, Auteur, Title, Description);

                DAL.FeedbackDAL.AddFeedback(feedback);
            }

            // If there isn't an activity selected.
            if (cbxActivity.Text == "")
            {
                Feedback feedback = new Feedback(StudentID, LearnGoalID, 0, Auteur, Title, Description);
                DAL.FeedbackDAL.AddFeedback(feedback);
            }
        }

        private void btnVraagStellen_Click(object sender, EventArgs e)
        {
            pnlAskQuestion.Show();
            pnlRegisterFeedback.Hide();
            FeedbackSelection = "Question";
            dgvFeedback.ClearSelection();
            txbQuestionTitle.Clear();
            txbQuestionDescription.Clear();
            lblQuestionTeacher.Text = "Teacher";
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
            this.Hide();
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


        // Eventhandler for SelectionChanged on the cbxWeek
        private void WeekChanged(object sender, EventArgs e)
        {
            SyncLearngoals();
            dgvActivities.Rows.Clear();
        }

        private void SubjectChanged(object sender, EventArgs e)
        {
            SyncLearngoals();
            dgvActivities.Rows.Clear();
        }

        private void dgvLearnGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SyncActivities();
        }

        private void dgvActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Checks if the current cell selection is a dgvCheckBox
            if (dgvActivities.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                if (dgvActivities.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    //You can see [e.RowIndex] and [e.Columnindex] as Y, and X Coordinates. 
                    //Rowindex being the current row and column being which column.
                    //Upon finding the specified cell, it binds it to its datatype which is now usable in code.

                    pnlActivity.Hide();
                    pnlLearngoal.Hide();
                    pnlTimeSpent.Show();
                    dgvActivities.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    // Set the ReadOnly property of the cell to true to prevent the user from unchecking the checkbox
                    dgvActivities.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
                else
                {

                }
            }
        }


        private void btnSaveTimeSpent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvActivities.Rows[dgvActivities.CurrentCell.RowIndex];
            int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string TimeSpent = txbTimeSpent.Text;
            Activity.InsertTimeSpent(activityid, TimeSpent);
            pnlTimeSpent.Visible = false;
            pnlLearngoal.Show();
            txbTimeSpent.Clear();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string name = txbAddSubject.Text;
            txbAddSubject.Clear();
            Subject Subject = new Subject(name, false);
            Subject.AddSubject(CurrentStudent, Subject);
            dgvSubjects_Sync();
        }

        private void dgvSubjects_Sync()
        {
            List<Subject> TotalSubjects = Subject.GetSubjects(CurrentStudent);
            dgvSubjects.Rows.Clear();
            cbxSubject.Items.Clear();

            foreach (Subject subject in TotalSubjects)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = subject.Name });
                row.Cells.Add(new DataGridViewCheckBoxCell { Value = subject.Following });

                dgvSubjects.Rows.Add(row);

                //Add it to the UI subject selection combobox on the main header
                if (subject.Following == true)
                {
                    cbxSubject.Items.Add(subject.Name);
                }
            }
        }

        private void dvgSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Checks if the current cell selection is a dgvCheckBox
            if (dgvSubjects.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                //You can see [e.RowIndex] and [e.Columnindex] as Y, and X Coordinates. 
                //Rowindex being the current row and column being which column.
                //Upon finding the specified cell, it binds it to its datatype which is now usable in code.

                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewTextBoxCell textboxCell = (DataGridViewTextBoxCell)dgvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex - 1];

                //textboxCell is the cell which contains the name of the subject you've just selected.
                //CurrentSubject gets found by the method written in the Subject Class in combination with the StudentDAL.

                Subject CurrentSubject = Subject.findSubjectByName(CurrentStudent, textboxCell.Value.ToString());

                //CheckboxCell contains a boolean, either true or false. This represents either checked or not checked.

                CurrentSubject.Following = (bool)checkboxCell.Value;
                Subject.UpdateSubjects(CurrentStudent, CurrentSubject);
                dgvSubjects_Sync();
            }
        }

        //This was found on the internet, it solves the problem that when you are changing the checkbox state.
        //Say you would change the checkbox state twice, then the database wouldn't process the change correctly.
        //This code forces a change to happen immediately which prevents it from having an unprocessed change.
        private void dgvSubjects_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSubjects.IsCurrentCellDirty)
            {
                dgvSubjects.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
