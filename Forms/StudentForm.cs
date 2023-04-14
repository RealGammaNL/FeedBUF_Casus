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
using System.Data.SqlClient;
using DAL;

namespace FeedBUF_Casus.Forms
{
    public partial class StudentForm : Form
    {
        public Student CurrentStudent;
        public static string FeedbackSelection;
        public List<Panel> panels = new List<Panel>();

        public StudentForm(Student student)
        {
            InitializeComponent();

            CurrentStudent = student;
            LoginStudent(student);
            dgvSubjects_Sync();

            panels.AddRange(new Panel[] { pnlFeedback, pnlFeedforward, pnlFeedup, pnlConclusion, pnlHome });
        }


        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                             Feedup panel code - Vigo                             //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //


        //
        // Syncing datagridviews
        //


        private void Feedup_SyncLearngoals()
        {
            if (cbxWeek.Text != "")
            {
                int weeknumber = determinePickedWeek();
                string Subjectname = cbxSubject.Text;
                List<LearnGoal> TotalLearngoal = LearnGoal.GetLearnGoals(CurrentStudent, weeknumber, Subjectname);
                dgvLearnGoals.Rows.Clear();

                foreach (LearnGoal goal in TotalLearngoal)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvLearnGoals);
                    row.Cells[0].Value = goal.LearnGoalID;
                    row.Cells[1].Value = goal.Goal;
                    dgvLearnGoals.Rows.Add(row);
                }
            }
        }


        private void Feedup_SyncActivities()
        {
            DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
            int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            List<Activity> TotalActivity = Activity.GetActivity(learngoalid);
            dgvActivities.Rows.Clear();

            foreach (Activity activity in TotalActivity)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvActivities);
                row.Cells[0].Value = activity.ActivityID;
                row.Cells[1].Value = activity.ActivityText;
                row.Cells[2].Value = activity.TimeEstimate;
                dgvActivities.Rows.Add(row);
                if (activity.TimeSpent != "")
                {
                    row.Cells[3].Value = true;
                    row.Cells[3].ReadOnly = true;
                }
            }
        }



        //
        // Switching panels
        //

        private void btnFeedup_SwitchLearngoal_Click(object sender, EventArgs e)
        {
            pnlActivity.Hide();
            pnlNewActivity.Hide();
            pnlLearngoal.Show();
            pnlAddLearngoal.Show();
            pnlUpdateLearngoal.Hide();
            pnlTimeSpent.Hide();
        }

        private void btnFeedup_SwitchActivity_Click(object sender, EventArgs e)
        {
            pnlActivity.Show();
            pnlNewActivity.Show();
            pnlUpdateActivity.Hide();
            pnlLearngoal.Hide();
            pnlTimeSpent.Hide();
        }

        private void btnUpdateLearnGoalpnl_Click(object sender, EventArgs e)
        {
            pnlAddLearngoal.Hide();
            pnlUpdateLearngoal.Show();
        }
        private void btnBackLearngoal_Click(object sender, EventArgs e)
        {
            pnlUpdateLearngoal.Hide();
            pnlAddLearngoal.Show();
        }

        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            pnlNewActivity.Hide();
            pnlUpdateActivity.Show();
        }

        private void btnActivityBack_Click(object sender, EventArgs e)
        {
            pnlNewActivity.Show();
            pnlUpdateActivity.Hide();
        }

        //
        // CRUD to database
        //


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
        private void btnAddLearngoal_Click(object sender, EventArgs e)
        {
            string learngoal = txbFeedup_AddLearngoal.Text;
            if (learngoal != "")
            {
                string[] attributes = cbxWeek.Text.Split(' ');
                int weeknumber = Int32.Parse(attributes[1]);
                LearnGoal learnGoal = new LearnGoal(CurrentStudent.ID, cbxSubject.Text, weeknumber, learngoal) { };
                LearnGoal.AddLearngoal(learnGoal);
                txbFeedup_AddLearngoal.Clear();
                Feedup_SyncLearngoals();
            }
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            string activityStr = tbxNewActivity.Text;
            if (dgvLearnGoals.CurrentRow != null && activityStr != "")
            {
                string timeEstimation = txbFeedup_TimeEstimation.Text;
                DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
                int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Activity activity = new Activity(learngoalid, activityStr, timeEstimation);
                Activity.AddActivity(activity);
                tbxNewActivity.Clear();
                txbFeedup_TimeEstimation.Clear();
                Feedup_SyncActivities();
            }
        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvActivities.Rows[dgvActivities.CurrentCell.RowIndex];
            int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string newactivity = txbFeedup_SelectedActivitity.Text.ToString();
            Activity.UpdateActivity(activityid, newactivity);
            Feedup_SyncActivities();
            pnlUpdateActivity.Hide();
            pnlNewActivity.Show();
            txbFeedup_SelectedActivitity.Clear();
        }
        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (txbFeedup_SelectedActivitity.Text.ToString() != "")
            {
                DialogResult result = MessageBox.Show("U staat op het punt om een activiteit te verwijderen, weet u het zeker?", "Verwijderen", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvActivities.Rows[dgvActivities.CurrentCell.RowIndex];
                    int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                    Activity.RemoveActivity(activityid);
                    Feedup_SyncActivities();
                    pnlUpdateActivity.Hide();
                    pnlNewActivity.Show();
                    txbFeedup_SelectedActivitity.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Do nothing
                }
            }
        }

        private void btnSaveLearngoal_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
            int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            string learngoal = txbSelectedLearngoal.Text.ToString();
            LearnGoal.UpdateLearngoal(learngoalid, learngoal);
            Feedup_SyncLearngoals();
            Feedup_SyncActivities();
            pnlUpdateLearngoal.Hide();
            pnlAddLearngoal.Show();
            txbSelectedLearngoal.Clear();
        }

        private void btnDeleteLearngoal_Click(object sender, EventArgs e)
        {
            if (txbSelectedLearngoal.Text.ToString() != "")
            {
                DialogResult result = MessageBox.Show("U staat op het punt om een leerdoel te verwijderen, alle activiteiten die hierbij horen zullen ook verwijderd worden. Weet u het zeker?", "Verwijderen", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
                    int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                    LearnGoal.DeleteLearngoal(learngoalid);
                    Feedup_SyncLearngoals();
                    Feedup_SyncActivities();
                    pnlUpdateLearngoal.Hide();
                    pnlAddLearngoal.Show();
                    txbSelectedLearngoal.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Do nothing
                }
            }
        }

        //
        // UI interaction in Datagridview
        //

        private void dgvLearnGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Feedup_SyncActivities();
            DataGridViewRow selectedRow = dgvLearnGoals.Rows[dgvLearnGoals.CurrentCell.RowIndex];
            string learngoal = (selectedRow.Cells[1].Value.ToString());
            txbSelectedLearngoal.Text = learngoal;
        }

        private void dgvActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvActivities.Rows[dgvActivities.CurrentCell.RowIndex];
            string activity = (selectedRow.Cells[1].Value.ToString());
            txbFeedup_SelectedActivitity.Text = activity;
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
 
        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                             Feedback panel code - Max                            //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //

        //
        // Syncing Datagrids and Comboboxes
        //
        private void Feedback_SyncFeedback()
        {
            int weeknumber = determinePickedWeek();

            List<Feedback> TotalFeedback = Feedback.GetFeedback(CurrentStudent, weeknumber, cbxSubject.Text.ToString());
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
        private void Feedback_SyncLearngoals()
        {
            int weeknumber = determinePickedWeek();
            string Subjectname = cbxSubject.Text;
            List<LearnGoal> TotalLearngoal = LearnGoal.GetLearnGoals(CurrentStudent, weeknumber, Subjectname);
            cbxLearnGoal.Items.Clear();
            cbxLearnGoal.Text = "";
            foreach (LearnGoal learngoal in TotalLearngoal)
            {
                cbxLearnGoal.Items.Add(learngoal.Goal);
            }
        }

        private void Feedback_SyncActivities(LearnGoal learngoal)
        {
            List<Activity> TotalActivity = Activity.GetActivity(learngoal.LearnGoalID);
            cbxActivity.Items.Clear();
            cbxActivity.Text = "";
            foreach (Activity activity in TotalActivity)
            {
                cbxActivity.Items.Add(activity.ActivityText);
            }
        }



        //
        // Switching between panels and hiding information
        //

        private void btnRegisterFeedback_Click(object sender, EventArgs e)
        {
            pnlAskQuestion.Hide();
            pnlRegisterFeedback.Show();
            FeedbackSelection = "Register";
            dgvFeedback.ClearSelection();

            btnFeedbackAdd.Show();
            btnFeedbackUpdate.Hide();
            btnFeedbackDelete.Hide();

            // Reset the panel
            Feedback_SyncLearngoals();
            cbxActivity.Items.Clear(); cbxActivity.Text = "";
            txbFeedbackTeacher.Clear();
            txbFeedbackDescription.Clear();
            txbFeedbackTitle.Clear();
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
            Feedback_SyncLearngoals();

            btnSubmitQuestion.Show();
            btnUpdateQuestion.Hide();
            txbQuestion.Clear();
        }

        private void cbxLearnGoal_SelectedValueChanged(object sender, EventArgs e)
        {
            int weeknumber = determinePickedWeek();
            LearnGoal CurrentLearnGoal = LearnGoal.GetLearnGoalByName(CurrentStudent, weeknumber, cbxSubject.Text.ToString(), cbxLearnGoal.Text.ToString());
            Feedback_SyncActivities(CurrentLearnGoal);
        }

        private void dgvFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // This function handles selecting a row in the Feedback Datagridview
            //

            foreach (DataGridViewRow row in dgvFeedback.SelectedRows)
            {
                int selFeedbackID = determineFeedbackID();

                if (selFeedbackID != -1)
                {
                    // Clever trick where when clicking on "Registreer Feedback" or "Vraag Stellen" it changes the way this function will work.
                    if (FeedbackSelection == "Question")
                    {
                        txbQuestionTitle.Text = (string)row.Cells[2].Value;
                        txbQuestionDescription.Text = (string)row.Cells[3].Value;
                        lblQuestionTeacher.Text = (string)row.Cells[1].Value;
                        txbQuestion.Clear();

                        string question = FeedbackDAL.GetFeedbackQuestion(selFeedbackID);

                        if (question != "")
                        {
                            btnSubmitQuestion.Hide();
                            btnUpdateQuestion.Show();

                            txbQuestion.Text = question;
                        }

                        else
                        {
                            btnSubmitQuestion.Show();
                            btnUpdateQuestion.Hide();
                        }
                    }

                    if (FeedbackSelection == "Register")
                    {
                        Feedback SelectedFeedback = Feedback.GetFeedBackByID(selFeedbackID);
                        LearnGoal linkedLearnGoal = LearnGoal.GetLearnGoalByID(SelectedFeedback.LearngoalID);
                        Activity linkedActivity = Activity.GetActivityByID(SelectedFeedback.ActivityID);

                        // Format Learngoal Combobox
                        cbxLearnGoal.Items.Clear();
                        cbxLearnGoal.Items.Add(linkedLearnGoal.Goal);
                        cbxLearnGoal.SelectedItem = cbxLearnGoal.Items[0];

                        if (linkedActivity != null)
                        {
                            // Format Activity Combobox
                            cbxActivity.Items.Clear();
                            cbxActivity.Items.Add(linkedActivity.ActivityText);
                            cbxActivity.SelectedItem = cbxActivity.Items[0];
                        }
                        else
                        {
                            cbxActivity.Items.Clear();
                        }

                        // Fill in the rest of the textboxes on the screen.
                        txbFeedbackTeacher.Text = SelectedFeedback.Teacher;
                        txbFeedbackTitle.Text = SelectedFeedback.Title;
                        txbFeedbackDescription.Text = SelectedFeedback.Description;

                        btnFeedbackAdd.Hide();
                        btnFeedbackUpdate.Show();
                        btnFeedbackDelete.Show();
                    }
                }
            }
        }

        //
        // CRUD operations to database
        //

        private void btnFeedbackAdd_Click(object sender, EventArgs e)
        {
            int StudentID = CurrentStudent.ID;
            string LearnGoalText = cbxLearnGoal.Text.ToString();
            string Auteur = txbFeedbackTeacher.Text;
            string Title = txbFeedbackTitle.Text;
            string Description = txbFeedbackDescription.Text;
            string Subject = cbxSubject.Text;
            int weeknumber = determinePickedWeek();
            int ActivityID = 0;


            txbFeedbackTeacher.Clear();
            txbFeedbackTitle.Clear();
            txbFeedbackDescription.Clear();

            LearnGoal CurrentLearnGoal = LearnGoal.GetLearnGoalByName(CurrentStudent, weeknumber, Subject, LearnGoalText);

            // If there is an activity selected.
            if (cbxActivity.Text != "")
            {
                string activitytext = cbxActivity.Text.ToString();

                List<Activity> activities = Activity.GetActivity(CurrentLearnGoal.LearnGoalID);
                foreach (Activity activity in activities)
                {
                    if (activitytext == activity.ActivityText)
                    {
                        ActivityID = activity.ActivityID;
                    }
                }

                Feedback feedback = new Feedback(StudentID, CurrentLearnGoal.LearnGoalID, ActivityID, Auteur, Title, Description);
                DAL.FeedbackDAL.AddFeedback(feedback);
                Feedback_SyncFeedback();
            }

            // If there isn't an activity selected.
            if (cbxActivity.Text == "")
            {
                Feedback feedback = new Feedback(StudentID, CurrentLearnGoal.LearnGoalID, ActivityID, Auteur, Title, Description);
                DAL.FeedbackDAL.AddFeedback(feedback);
            }
        }

        private void btnSubmitQuestion_Click(object sender, EventArgs e)
        {
            if (determineFeedbackID() != -1)
            {
                Feedback.AddQuestion(determineFeedbackID(), txbQuestion.Text.ToString());
            }
            btnSubmitQuestion.Hide();
            btnUpdateQuestion.Show();
            dgvFeedforwardActivities.Rows.Clear();
        }

        private void btnFeedbackDelete_Click(object sender, EventArgs e)
        {
            if (determineFeedbackID() != -1)
            {
                Feedback.DeleteFeedback(determineFeedbackID());
            }

            // Reset the panel
            btnRegisterFeedback_Click(sender, e);
            Feedback_SyncFeedback();
        }

        private void btnFeedbackUpdate_Click(object sender, EventArgs e)
        {
            if (determineFeedbackID() != -1)
            {
                Feedback updatedFeedback = new Feedback(determineFeedbackID(), txbFeedbackTeacher.Text, txbFeedbackTitle.Text, txbFeedbackDescription.Text);
                FeedbackDAL.UpdateFeedback(updatedFeedback);
                Feedback_SyncFeedback();
            }
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            btnSubmitQuestion_Click(sender, e);
        }

        private int determineFeedbackID()
        {
            // FeedbackID gets assigned to the value in the first CELL of the selected ROW
            foreach (DataGridViewRow row in dgvFeedback.SelectedRows)
            {
                if (row.Cells[0].Value != null) { return (int)row.Cells[0].Value; }
            }

            return -1;

            // -1 can't be a number in the database so this is a safe "null" value.
            // We have to do this because this function returns an int so you cant actually return null.
        }



        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                               Home panel code - Max                              //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //

        private void dgvSubjects_Sync()
        {
            List<Subject> TotalSubjects = Subject.GetSubjects(CurrentStudent);
            dgvSubjects.Rows.Clear();
            cbxSubject.Items.Clear();

            foreach (Subject subject in TotalSubjects)
            {
                if (subject.Name != "")
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
        }

        //
        // CRUD Operations
        //


        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string name = txbAddSubject.Text;
            txbAddSubject.Clear();
            Subject Subject = new Subject(name, false);
            Subject.AddSubject(CurrentStudent, Subject);
            dgvSubjects_Sync();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedCells[0] is DataGridViewTextBoxCell)
            {
                string oldSubject = dgvSubjects.SelectedCells[0].Value.ToString();
                string newSubject = txbAddSubject.Text;
                Subject.UpdateSubjectName(CurrentStudent, oldSubject, newSubject);
                dgvSubjects_Sync();
                txbAddSubject.Clear();
                btnAddSubject.Show();
                btnUpdateSubject.Hide();
                dgvSubjects.ClearSelection();
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedCells[0] is DataGridViewTextBoxCell)
            {
                string subjectName = dgvSubjects.SelectedCells[0].Value.ToString();
                Subject.DeleteSubject(CurrentStudent, subjectName); 
                dgvSubjects_Sync();
                txbAddSubject.Clear();
                dgvSubjects.ClearSelection();
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

            if (dgvSubjects.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex >= 0)
            {
                txbAddSubject.Text = dgvSubjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                btnAddSubject.Hide();
                btnUpdateSubject.Show();
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







        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                              FeedforwardPanel - Jeroen                           //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //
        
     

        //
        // Syncing the Datagridviews
        //
        private void SyncFeedforwardFeedback()
        {
            List<Feedback> TotalFeedback = Feedback.GetFeedback(CurrentStudent, determinePickedWeek(), cbxSubject.Text);
            dgvFeedforwardFeedback.Rows.Clear();

            foreach (Feedback feedback in TotalFeedback)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFeedforwardFeedback);
                row.Cells[0].Value = feedback.FeedbackID;
                row.Cells[1].Value = feedback.Teacher;
                row.Cells[2].Value = feedback.Title;
                row.Cells[3].Value = feedback.Description;
                dgvFeedforwardFeedback.Rows.Add(row);
            }
        }

        private void SyncFeedforwardLearngoals()
        {
            if (cbxWeek.Text != "")
            {
                string[] attributes = cbxWeek.Text.Split(' ');
                int weeknumber = Int32.Parse(attributes[1]);
                string Subjectname = cbxSubject.Text;
                List<LearnGoal> TotalLearngoal = LearnGoal.GetLearnGoals(CurrentStudent, weeknumber, Subjectname);
                dgvFeedforwardLearnGoals.Rows.Clear();

                foreach (LearnGoal goal in TotalLearngoal)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvFeedforwardLearnGoals);
                    row.Cells[0].Value = goal.LearnGoalID;
                    row.Cells[1].Value = goal.Goal;
                    dgvFeedforwardLearnGoals.Rows.Add(row);
                }
            }
        }

        private void SyncFeedforwardActivities()
        {
            DataGridViewRow selectedRow = dgvFeedforwardLearnGoals.Rows[dgvFeedforwardLearnGoals.CurrentCell.RowIndex];
            int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            List<Activity> TotalActivity = Activity.GetActivity(learngoalid);
            dgvFeedforwardActivities.Rows.Clear();

            foreach (Activity activity in TotalActivity)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFeedforwardActivities);
                row.Cells[0].Value = activity.ActivityID;
                row.Cells[1].Value = activity.ActivityText;
                dgvFeedforwardActivities.Rows.Add(row);
            }
        }

        //
        // Clicking in the datagridviews
        //
        private void dgvFeedforwardLearngoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFeedforwardActivities.ClearSelection();
            dgvFeedforwardFeedback.ClearSelection();
            SyncLearnGoalNote();
            SyncFeedforwardActivities();
        }

        private void dgvFeedforwardActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFeedforwardLearnGoals.ClearSelection();
            dgvFeedforwardFeedback.ClearSelection();
            SyncActivityNote();
        }

        private void dgvFeedforwardFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFeedforwardLearnGoals.ClearSelection();
            dgvFeedforwardActivities.ClearSelection();
            SyncFeedbackNote();
        }

        //
        // Syncing the note textbox
        //

        private void SyncLearnGoalNote()
        {
            DataGridViewRow selectedRow = dgvFeedforwardLearnGoals.Rows[dgvFeedforwardLearnGoals.CurrentCell.RowIndex];
            int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            tbxFeedforwardNote.Clear();
            tbxFeedforwardNote.Text = LearnGoal.GetLearnGoalNote(learngoalid);
        }
        private void SyncActivityNote()
        {
            DataGridViewRow selectedRow = dgvFeedforwardActivities.Rows[dgvFeedforwardActivities.CurrentCell.RowIndex];
            int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            tbxFeedforwardNote.Clear();
            tbxFeedforwardNote.Text = Activity.GetActivityNote(activityid);
        }

        private void SyncFeedbackNote()
        {
            DataGridViewRow selectedRow = dgvFeedforwardFeedback.Rows[dgvFeedforwardFeedback.CurrentCell.RowIndex];
            int feedbackid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            tbxFeedforwardNote.Clear();
            tbxFeedforwardNote.Text = Feedback.GetFeedbackNote(feedbackid);
        }


        private void btnFeedforwardAddNote_Click(object sender, EventArgs e)
        {
            if (dgvFeedforwardFeedback.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardFeedback.Rows[dgvFeedforwardFeedback.CurrentCell.RowIndex];
                int feedbackid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Feedback.UpdateFeedbackNote(feedbackid, tbxFeedforwardNote.Text);
            }
            if (dgvFeedforwardLearnGoals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardLearnGoals.Rows[dgvFeedforwardLearnGoals.CurrentCell.RowIndex];
                int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                LearnGoal.UpdateLearnGoalNote(learngoalid, tbxFeedforwardNote.Text);
            }
            if (dgvFeedforwardActivities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardActivities.Rows[dgvFeedforwardActivities.CurrentCell.RowIndex];
                int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Activity.UpdateActivityNote(activityid, tbxFeedforwardNote.Text);
            }
        }

        private void btnFeedforwardDeleteNote_Click(object sender, EventArgs e)
        {
            if (dgvFeedforwardFeedback.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardFeedback.Rows[dgvFeedforwardFeedback.CurrentCell.RowIndex];
                int feedbackid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Feedback.DeleteFeedbackNote(feedbackid, tbxFeedforwardNote.Text);
            }
            if (dgvFeedforwardLearnGoals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardLearnGoals.Rows[dgvFeedforwardLearnGoals.CurrentCell.RowIndex];
                int learngoalid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                LearnGoal.DeleteLearnGoalNote(learngoalid, tbxFeedforwardNote.Text);
            }
            if (dgvFeedforwardActivities.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFeedforwardActivities.Rows[dgvFeedforwardActivities.CurrentCell.RowIndex];
                int activityid = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                Activity.DeleteActivityNote(activityid, tbxFeedforwardNote.Text);
            }
            tbxFeedforwardNote.Clear();
        }

        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                              ConclusiePanel - Soufian                            //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //
        private void SyncConclusion()
        {
            // Maak een instantie van de ConclusieDAL-klasse aan
            ConclusieDAL conclusieDAL = new ConclusieDAL();

            // De geselecteerde waarden ophalen
            int weeknumber = determinePickedWeek();
            string Subjectname = cbxSubject.Text;


            List<FeedbackData> feedbackDataList = conclusieDAL.GetFeedbackData(weeknumber, Subjectname);
            dgvConclusion.Rows.Clear();

            // Controleren of er resultaten zijn gevonden
            if (feedbackDataList.Any())
            {
                // De gevonden gegevens in de datatextbox plaatsen
                StringBuilder sb = new StringBuilder();

                foreach (FeedbackData feedbackData in feedbackDataList)
                {

                    dgvConclusion.Rows.Add(feedbackData.LearnGoal, feedbackData.Activity, feedbackData.Title, feedbackData.Question, feedbackData.Note, feedbackData.TimeEstimate, feedbackData.TimeSpent);
                }

                dgvConclusion.Text = sb.ToString();
            }
            else
            {
                dgvConclusion.Text = "Geen data gevonden voor de geselecteerde combinatie van week en vak.";
            }
        }

        //                                                                                  //
        // -------------------------------------------------------------------------------- //
        //                              Header panel code - Max                             //
        //--------------------------------------------------------------------------------- //
        //                                                                                  //
        private int determinePickedWeek()
        {
            if (cbxWeek.Text != "")
            {
                string[] attributes = cbxWeek.Text.Split(' ');
                int weeknumber = Int32.Parse(attributes[1]);
                return weeknumber;
            }
            else { return -1; }
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Closes the studentform
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }


        // Eventhandler for SelectionChanged on the cbxWeek
        private void WeekChanged(object sender, EventArgs e)
        {
            SyncPanels();
        }

        // Eventhandler for SelectionChanged on the cbxSubject
        private void SubjectChanged(object sender, EventArgs e)
        {
            SyncPanels();
        }

        private void SyncPanels()
        {
            Feedup_SyncLearngoals();
            SyncFeedforwardFeedback();
            SyncConclusion();
            Feedback_SyncFeedback();
            cbxLearnGoal.Text = "";
            cbxActivity.Text = "";
            dgvActivities.Rows.Clear();
            SyncFeedforwardLearngoals();
            dgvFeedforwardActivities.Rows.Clear();
            txbQuestion.Clear();
            txbQuestionTitle.Clear();
            txbQuestionDescription.Clear();
            lblQuestionTeacher.Text = "Auteur";
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
            SyncPanels();
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

            txbAddSubject.Clear();
            btnAddSubject.Show();
            btnUpdateSubject.Hide();
            dgvSubjects.ClearSelection();
        }
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
