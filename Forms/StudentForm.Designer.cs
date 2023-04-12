﻿using System.Windows.Forms;

namespace FeedBUF_Casus.Forms
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.cbxWeek = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cbxPanelSwitch = new System.Windows.Forms.ComboBox();
            this.pnlFeedup = new System.Windows.Forms.Panel();
            this.btnFeedup_SwitchActivity = new System.Windows.Forms.Button();
            this.btnFeedup_SwitchLearngoal = new System.Windows.Forms.Button();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.clnFeedupActivitiesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFeedupActivitiesActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTimeEstimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvLearnGoals = new System.Windows.Forms.DataGridView();
            this.clnFeedupLearnGoalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFeedupLearnGoalLearnGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblLearnGoals = new System.Windows.Forms.Label();
            this.pnlLearngoal = new System.Windows.Forms.Panel();
            this.pnlAddLearngoal = new System.Windows.Forms.Panel();
            this.btnAddLearngoal = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbFeedup_AddLearngoal = new System.Windows.Forms.TextBox();
            this.btnUpdateLearnGoalpnl = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlUpdateLearngoal = new System.Windows.Forms.Panel();
            this.btnBackLearngoal = new System.Windows.Forms.Button();
            this.btnDeleteLearngoal = new System.Windows.Forms.Button();
            this.btnSaveLearngoal = new System.Windows.Forms.Button();
            this.txbSelectedLearngoal = new System.Windows.Forms.TextBox();
            this.lblUpdateLearngoal = new System.Windows.Forms.Label();
            this.pnlTimeSpent = new System.Windows.Forms.Panel();
            this.btnSaveTimeSpent = new System.Windows.Forms.Button();
            this.txbTimeSpent = new System.Windows.Forms.TextBox();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            this.pnlUpdateActivity = new System.Windows.Forms.Panel();
            this.btnActivityBack = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.btnSaveActivity = new System.Windows.Forms.Button();
            this.txbFeedup_SelectedActivitity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlNewActivity = new System.Windows.Forms.Panel();
            this.txbFeedup_TimeEstimation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNewActivity = new System.Windows.Forms.Button();
            this.lblNewActivity = new System.Windows.Forms.Label();
            this.tbxNewActivity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnVraagStellen = new System.Windows.Forms.Button();
            this.btnRegisterFeedback = new System.Windows.Forms.Button();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.FeedbackID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedbackTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedbackTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeedbackDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.pnlRegisterFeedback = new System.Windows.Forms.Panel();
            this.btnFeedbackAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxActivity = new System.Windows.Forms.ComboBox();
            this.cbxLearnGoal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFeedbackAuteur = new System.Windows.Forms.Label();
            this.txbFeedbackTeacher = new System.Windows.Forms.TextBox();
            this.pcbUserIcon = new System.Windows.Forms.PictureBox();
            this.txbFeedbackDescription = new System.Windows.Forms.TextBox();
            this.txbFeedbackTitle = new System.Windows.Forms.TextBox();
            this.lblRegisterFeedback = new System.Windows.Forms.Label();
            this.pnlAskQuestion = new System.Windows.Forms.Panel();
            this.lblQuestionTeacher = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbQuestion = new System.Windows.Forms.TextBox();
            this.txbQuestionDescription = new System.Windows.Forms.TextBox();
            this.txbQuestionTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFeedforward = new System.Windows.Forms.Panel();
            this.dgvFeedback2 = new System.Windows.Forms.DataGridView();
            this.clnFeedforwardFeedbackID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFeedforwardFeedbackFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFeedback2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnFeedforwardConclusionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFeedforwardConclusionConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLearnGoals2 = new System.Windows.Forms.DataGridView();
            this.clnFeedforwardLearnGoalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFeedforwardLearngoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblLearnGoals2 = new System.Windows.Forms.Label();
            this.pnlConclusion = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.clnConclusionConclusionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnConclusionConclusionConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Following = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNewSubject = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.lblBeheerVakken = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblNewSubject_ = new System.Windows.Forms.Label();
            this.txbAddSubject = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lblManageSubjects = new System.Windows.Forms.Label();
            this.lblHome_ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals)).BeginInit();
            this.pnlLearngoal.SuspendLayout();
            this.pnlAddLearngoal.SuspendLayout();
            this.pnlUpdateLearngoal.SuspendLayout();
            this.pnlTimeSpent.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.pnlUpdateActivity.SuspendLayout();
            this.pnlNewActivity.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.pnlRegisterFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserIcon)).BeginInit();
            this.pnlAskQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFeedforward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals2)).BeginInit();
            this.pnlConclusion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(13, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 57);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Controls.Add(this.lblStudentClass);
            this.groupBox1.Controls.Add(this.cbxSubject);
            this.groupBox1.Controls.Add(this.cbxWeek);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.cbxPanelSwitch);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Location = new System.Drawing.Point(-4, -10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1459, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Orange;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(1369, 19);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(50, 57);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(1271, 47);
            this.lblStudentClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(27, 13);
            this.lblStudentClass.TabIndex = 5;
            this.lblStudentClass.Text = "Klas";
            // 
            // cbxSubject
            // 
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Items.AddRange(new object[] {
            "Introduction to Development",
            "Datastructure Basics",
            "Project Management"});
            this.cbxSubject.Location = new System.Drawing.Point(317, 33);
            this.cbxSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(228, 28);
            this.cbxSubject.TabIndex = 3;
            this.cbxSubject.SelectedValueChanged += new System.EventHandler(this.SubjectChanged);
            // 
            // cbxWeek
            // 
            this.cbxWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWeek.FormattingEnabled = true;
            this.cbxWeek.Items.AddRange(new object[] {
            "Week 1 ",
            "Week 2 ",
            "Week 3 "});
            this.cbxWeek.Location = new System.Drawing.Point(212, 33);
            this.cbxWeek.Margin = new System.Windows.Forms.Padding(2);
            this.cbxWeek.Name = "cbxWeek";
            this.cbxWeek.Size = new System.Drawing.Size(92, 28);
            this.cbxWeek.TabIndex = 2;
            this.cbxWeek.SelectedIndexChanged += new System.EventHandler(this.WeekChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(1271, 33);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(70, 13);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Studentnaam";
            // 
            // cbxPanelSwitch
            // 
            this.cbxPanelSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPanelSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPanelSwitch.FormattingEnabled = true;
            this.cbxPanelSwitch.Items.AddRange(new object[] {
            "Feedup",
            "Feedback",
            "Feedforward",
            "Conclusion"});
            this.cbxPanelSwitch.Location = new System.Drawing.Point(81, 33);
            this.cbxPanelSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPanelSwitch.Name = "cbxPanelSwitch";
            this.cbxPanelSwitch.Size = new System.Drawing.Size(120, 28);
            this.cbxPanelSwitch.TabIndex = 1;
            this.cbxPanelSwitch.SelectedValueChanged += new System.EventHandler(this.Switchpanel);
            // 
            // pnlFeedup
            // 
            this.pnlFeedup.Controls.Add(this.btnFeedup_SwitchActivity);
            this.pnlFeedup.Controls.Add(this.btnFeedup_SwitchLearngoal);
            this.pnlFeedup.Controls.Add(this.dgvActivities);
            this.pnlFeedup.Controls.Add(this.dgvLearnGoals);
            this.pnlFeedup.Controls.Add(this.lblActivities);
            this.pnlFeedup.Controls.Add(this.lblLearnGoals);
            this.pnlFeedup.Controls.Add(this.pnlLearngoal);
            this.pnlFeedup.Controls.Add(this.pnlTimeSpent);
            this.pnlFeedup.Controls.Add(this.pnlActivity);
            this.pnlFeedup.Location = new System.Drawing.Point(9, 85);
            this.pnlFeedup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(1406, 743);
            this.pnlFeedup.TabIndex = 3;
            this.pnlFeedup.Visible = false;
            this.pnlFeedup.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFeedup_Paint);
            // 
            // btnFeedup_SwitchActivity
            // 
            this.btnFeedup_SwitchActivity.Location = new System.Drawing.Point(949, 12);
            this.btnFeedup_SwitchActivity.Name = "btnFeedup_SwitchActivity";
            this.btnFeedup_SwitchActivity.Size = new System.Drawing.Size(142, 36);
            this.btnFeedup_SwitchActivity.TabIndex = 7;
            this.btnFeedup_SwitchActivity.Text = "Activiteit toevoegen";
            this.btnFeedup_SwitchActivity.UseVisualStyleBackColor = true;
            this.btnFeedup_SwitchActivity.Click += new System.EventHandler(this.btnFeedup_SwitchActivity_Click);
            // 
            // btnFeedup_SwitchLearngoal
            // 
            this.btnFeedup_SwitchLearngoal.Location = new System.Drawing.Point(793, 12);
            this.btnFeedup_SwitchLearngoal.Name = "btnFeedup_SwitchLearngoal";
            this.btnFeedup_SwitchLearngoal.Size = new System.Drawing.Size(142, 36);
            this.btnFeedup_SwitchLearngoal.TabIndex = 6;
            this.btnFeedup_SwitchLearngoal.Text = "Leerdoel toevoegen";
            this.btnFeedup_SwitchLearngoal.UseVisualStyleBackColor = true;
            this.btnFeedup_SwitchLearngoal.Click += new System.EventHandler(this.btnFeedup_SwitchLearngoal_Click);
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedupActivitiesID,
            this.clnFeedupActivitiesActivity,
            this.dgcTimeEstimation,
            this.Completed});
            this.dgvActivities.Location = new System.Drawing.Point(420, 68);
            this.dgvActivities.Margin = new System.Windows.Forms.Padding(2);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(350, 650);
            this.dgvActivities.TabIndex = 3;
            this.dgvActivities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellClick);
            this.dgvActivities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivities_CellContentClick);
            // 
            // clnFeedupActivitiesID
            // 
            this.clnFeedupActivitiesID.HeaderText = "ID";
            this.clnFeedupActivitiesID.MinimumWidth = 6;
            this.clnFeedupActivitiesID.Name = "clnFeedupActivitiesID";
            this.clnFeedupActivitiesID.ReadOnly = true;
            this.clnFeedupActivitiesID.Width = 50;
            // 
            // clnFeedupActivitiesActivity
            // 
            this.clnFeedupActivitiesActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFeedupActivitiesActivity.HeaderText = "Activiteit";
            this.clnFeedupActivitiesActivity.MinimumWidth = 6;
            this.clnFeedupActivitiesActivity.Name = "clnFeedupActivitiesActivity";
            this.clnFeedupActivitiesActivity.ReadOnly = true;
            // 
            // dgcTimeEstimation
            // 
            this.dgcTimeEstimation.HeaderText = "Tijdsinschatting";
            this.dgcTimeEstimation.MinimumWidth = 8;
            this.dgcTimeEstimation.Name = "dgcTimeEstimation";
            this.dgcTimeEstimation.ReadOnly = true;
            this.dgcTimeEstimation.Width = 85;
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Voltooid";
            this.Completed.MinimumWidth = 8;
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.ToolTipText = "Vink aan als de activiteit voltooid is";
            this.Completed.Width = 60;
            // 
            // dgvLearnGoals
            // 
            this.dgvLearnGoals.AllowUserToAddRows = false;
            this.dgvLearnGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedupLearnGoalID,
            this.clnFeedupLearnGoalLearnGoal});
            this.dgvLearnGoals.Location = new System.Drawing.Point(29, 68);
            this.dgvLearnGoals.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLearnGoals.MultiSelect = false;
            this.dgvLearnGoals.Name = "dgvLearnGoals";
            this.dgvLearnGoals.ReadOnly = true;
            this.dgvLearnGoals.RowHeadersVisible = false;
            this.dgvLearnGoals.RowHeadersWidth = 51;
            this.dgvLearnGoals.RowTemplate.Height = 24;
            this.dgvLearnGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLearnGoals.Size = new System.Drawing.Size(350, 650);
            this.dgvLearnGoals.TabIndex = 2;
            this.dgvLearnGoals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLearnGoals_CellClick);
            // 
            // clnFeedupLearnGoalID
            // 
            this.clnFeedupLearnGoalID.HeaderText = "ID";
            this.clnFeedupLearnGoalID.MinimumWidth = 6;
            this.clnFeedupLearnGoalID.Name = "clnFeedupLearnGoalID";
            this.clnFeedupLearnGoalID.ReadOnly = true;
            this.clnFeedupLearnGoalID.Width = 50;
            // 
            // clnFeedupLearnGoalLearnGoal
            // 
            this.clnFeedupLearnGoalLearnGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFeedupLearnGoalLearnGoal.HeaderText = "Leerdoel";
            this.clnFeedupLearnGoalLearnGoal.MinimumWidth = 6;
            this.clnFeedupLearnGoalLearnGoal.Name = "clnFeedupLearnGoalLearnGoal";
            this.clnFeedupLearnGoalLearnGoal.ReadOnly = true;
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.ForeColor = System.Drawing.Color.Orange;
            this.lblActivities.Location = new System.Drawing.Point(415, 12);
            this.lblActivities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(128, 29);
            this.lblActivities.TabIndex = 1;
            this.lblActivities.Text = "Activiteiten";
            // 
            // lblLearnGoals
            // 
            this.lblLearnGoals.AutoSize = true;
            this.lblLearnGoals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals.Location = new System.Drawing.Point(25, 11);
            this.lblLearnGoals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLearnGoals.Name = "lblLearnGoals";
            this.lblLearnGoals.Size = new System.Drawing.Size(137, 29);
            this.lblLearnGoals.TabIndex = 0;
            this.lblLearnGoals.Text = "Leerdoelen";
            // 
            // pnlLearngoal
            // 
            this.pnlLearngoal.Controls.Add(this.btnUpdateLearnGoalpnl);
            this.pnlLearngoal.Controls.Add(this.label12);
            this.pnlLearngoal.Controls.Add(this.pnlUpdateLearngoal);
            this.pnlLearngoal.Controls.Add(this.pnlAddLearngoal);
            this.pnlLearngoal.Location = new System.Drawing.Point(801, 68);
            this.pnlLearngoal.Name = "pnlLearngoal";
            this.pnlLearngoal.Size = new System.Drawing.Size(590, 659);
            this.pnlLearngoal.TabIndex = 10;
            // 
            // pnlAddLearngoal
            // 
            this.pnlAddLearngoal.Controls.Add(this.btnAddLearngoal);
            this.pnlAddLearngoal.Controls.Add(this.label11);
            this.pnlAddLearngoal.Controls.Add(this.txbFeedup_AddLearngoal);
            this.pnlAddLearngoal.Location = new System.Drawing.Point(4, 51);
            this.pnlAddLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddLearngoal.Name = "pnlAddLearngoal";
            this.pnlAddLearngoal.Size = new System.Drawing.Size(580, 147);
            this.pnlAddLearngoal.TabIndex = 12;
            // 
            // btnAddLearngoal
            // 
            this.btnAddLearngoal.BackColor = System.Drawing.Color.Orange;
            this.btnAddLearngoal.Location = new System.Drawing.Point(7, 72);
            this.btnAddLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLearngoal.Name = "btnAddLearngoal";
            this.btnAddLearngoal.Size = new System.Drawing.Size(142, 45);
            this.btnAddLearngoal.TabIndex = 9;
            this.btnAddLearngoal.Text = "Toevoegen";
            this.btnAddLearngoal.UseVisualStyleBackColor = false;
            this.btnAddLearngoal.Click += new System.EventHandler(this.btnAddLearngoal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(2, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nieuw leerdoel";
            // 
            // txbFeedup_AddLearngoal
            // 
            this.txbFeedup_AddLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_AddLearngoal.Location = new System.Drawing.Point(6, 38);
            this.txbFeedup_AddLearngoal.Name = "txbFeedup_AddLearngoal";
            this.txbFeedup_AddLearngoal.Size = new System.Drawing.Size(561, 29);
            this.txbFeedup_AddLearngoal.TabIndex = 6;
            // 
            // btnUpdateLearnGoalpnl
            // 
            this.btnUpdateLearnGoalpnl.Location = new System.Drawing.Point(431, 10);
            this.btnUpdateLearnGoalpnl.Name = "btnUpdateLearnGoalpnl";
            this.btnUpdateLearnGoalpnl.Size = new System.Drawing.Size(142, 36);
            this.btnUpdateLearnGoalpnl.TabIndex = 11;
            this.btnUpdateLearnGoalpnl.Text = "Leerdoel beheren";
            this.btnUpdateLearnGoalpnl.UseVisualStyleBackColor = true;
            this.btnUpdateLearnGoalpnl.Click += new System.EventHandler(this.btnUpdateLearnGoalpnl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "Leerdoel";
            // 
            // pnlUpdateLearngoal
            // 
            this.pnlUpdateLearngoal.Controls.Add(this.btnBackLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.btnDeleteLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.btnSaveLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.txbSelectedLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.lblUpdateLearngoal);
            this.pnlUpdateLearngoal.Location = new System.Drawing.Point(5, 51);
            this.pnlUpdateLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdateLearngoal.Name = "pnlUpdateLearngoal";
            this.pnlUpdateLearngoal.Size = new System.Drawing.Size(581, 138);
            this.pnlUpdateLearngoal.TabIndex = 13;
            this.pnlUpdateLearngoal.Visible = false;
            // 
            // btnBackLearngoal
            // 
            this.btnBackLearngoal.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackLearngoal.Location = new System.Drawing.Point(423, 83);
            this.btnBackLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackLearngoal.Name = "btnBackLearngoal";
            this.btnBackLearngoal.Size = new System.Drawing.Size(142, 45);
            this.btnBackLearngoal.TabIndex = 13;
            this.btnBackLearngoal.Text = "Terug";
            this.btnBackLearngoal.UseVisualStyleBackColor = false;
            this.btnBackLearngoal.Click += new System.EventHandler(this.btnBackLearngoal_Click);
            // 
            // btnDeleteLearngoal
            // 
            this.btnDeleteLearngoal.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteLearngoal.Location = new System.Drawing.Point(152, 83);
            this.btnDeleteLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLearngoal.Name = "btnDeleteLearngoal";
            this.btnDeleteLearngoal.Size = new System.Drawing.Size(142, 45);
            this.btnDeleteLearngoal.TabIndex = 12;
            this.btnDeleteLearngoal.Text = "Verwijderen";
            this.btnDeleteLearngoal.UseVisualStyleBackColor = false;
            this.btnDeleteLearngoal.Click += new System.EventHandler(this.btnDeleteLearngoal_Click);
            // 
            // btnSaveLearngoal
            // 
            this.btnSaveLearngoal.BackColor = System.Drawing.Color.Orange;
            this.btnSaveLearngoal.Location = new System.Drawing.Point(6, 83);
            this.btnSaveLearngoal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveLearngoal.Name = "btnSaveLearngoal";
            this.btnSaveLearngoal.Size = new System.Drawing.Size(142, 45);
            this.btnSaveLearngoal.TabIndex = 11;
            this.btnSaveLearngoal.Text = "Opslaan";
            this.btnSaveLearngoal.UseVisualStyleBackColor = false;
            this.btnSaveLearngoal.Click += new System.EventHandler(this.btnSaveLearngoal_Click);
            // 
            // txbSelectedLearngoal
            // 
            this.txbSelectedLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectedLearngoal.Location = new System.Drawing.Point(6, 42);
            this.txbSelectedLearngoal.Name = "txbSelectedLearngoal";
            this.txbSelectedLearngoal.Size = new System.Drawing.Size(561, 29);
            this.txbSelectedLearngoal.TabIndex = 10;
            // 
            // lblUpdateLearngoal
            // 
            this.lblUpdateLearngoal.AutoSize = true;
            this.lblUpdateLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateLearngoal.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateLearngoal.Location = new System.Drawing.Point(3, 9);
            this.lblUpdateLearngoal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateLearngoal.Name = "lblUpdateLearngoal";
            this.lblUpdateLearngoal.Size = new System.Drawing.Size(162, 24);
            this.lblUpdateLearngoal.TabIndex = 9;
            this.lblUpdateLearngoal.Text = "Leerdoel beheren";
            // 
            // pnlTimeSpent
            // 
            this.pnlTimeSpent.Controls.Add(this.btnSaveTimeSpent);
            this.pnlTimeSpent.Controls.Add(this.txbTimeSpent);
            this.pnlTimeSpent.Controls.Add(this.lblCompleted);
            this.pnlTimeSpent.Location = new System.Drawing.Point(797, 68);
            this.pnlTimeSpent.Name = "pnlTimeSpent";
            this.pnlTimeSpent.Size = new System.Drawing.Size(355, 158);
            this.pnlTimeSpent.TabIndex = 11;
            this.pnlTimeSpent.Visible = false;
            // 
            // btnSaveTimeSpent
            // 
            this.btnSaveTimeSpent.BackColor = System.Drawing.Color.Orange;
            this.btnSaveTimeSpent.Location = new System.Drawing.Point(12, 90);
            this.btnSaveTimeSpent.Name = "btnSaveTimeSpent";
            this.btnSaveTimeSpent.Size = new System.Drawing.Size(101, 43);
            this.btnSaveTimeSpent.TabIndex = 2;
            this.btnSaveTimeSpent.Text = "Opslaan";
            this.btnSaveTimeSpent.UseVisualStyleBackColor = false;
            this.btnSaveTimeSpent.Click += new System.EventHandler(this.btnSaveTimeSpent_Click);
            // 
            // txbTimeSpent
            // 
            this.txbTimeSpent.Location = new System.Drawing.Point(16, 54);
            this.txbTimeSpent.Name = "txbTimeSpent";
            this.txbTimeSpent.Size = new System.Drawing.Size(100, 20);
            this.txbTimeSpent.TabIndex = 1;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCompleted.Location = new System.Drawing.Point(15, 16);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(328, 20);
            this.lblCompleted.TabIndex = 0;
            this.lblCompleted.Text = "Hoe lang heeft u over deze activiteit gedaan?";
            // 
            // pnlActivity
            // 
            this.pnlActivity.Controls.Add(this.btnUpdateActivity);
            this.pnlActivity.Controls.Add(this.label3);
            this.pnlActivity.Controls.Add(this.pnlUpdateActivity);
            this.pnlActivity.Controls.Add(this.pnlNewActivity);
            this.pnlActivity.Location = new System.Drawing.Point(801, 68);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(590, 659);
            this.pnlActivity.TabIndex = 4;
            this.pnlActivity.Visible = false;
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.Location = new System.Drawing.Point(431, 8);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(151, 34);
            this.btnUpdateActivity.TabIndex = 15;
            this.btnUpdateActivity.Text = "Activiteit beheren";
            this.btnUpdateActivity.UseVisualStyleBackColor = true;
            this.btnUpdateActivity.Click += new System.EventHandler(this.btnUpdateActivity_Click);
            // 
            // pnlUpdateActivity
            // 
            this.pnlUpdateActivity.Controls.Add(this.btnActivityBack);
            this.pnlUpdateActivity.Controls.Add(this.btnDeleteActivity);
            this.pnlUpdateActivity.Controls.Add(this.btnSaveActivity);
            this.pnlUpdateActivity.Controls.Add(this.txbFeedup_SelectedActivitity);
            this.pnlUpdateActivity.Controls.Add(this.label8);
            this.pnlUpdateActivity.Location = new System.Drawing.Point(0, 47);
            this.pnlUpdateActivity.Name = "pnlUpdateActivity";
            this.pnlUpdateActivity.Size = new System.Drawing.Size(576, 140);
            this.pnlUpdateActivity.TabIndex = 14;
            this.pnlUpdateActivity.Visible = false;
            // 
            // btnActivityBack
            // 
            this.btnActivityBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnActivityBack.Location = new System.Drawing.Point(422, 75);
            this.btnActivityBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivityBack.Name = "btnActivityBack";
            this.btnActivityBack.Size = new System.Drawing.Size(142, 45);
            this.btnActivityBack.TabIndex = 14;
            this.btnActivityBack.Text = "Terug";
            this.btnActivityBack.UseVisualStyleBackColor = false;
            this.btnActivityBack.Click += new System.EventHandler(this.btnActivityBack_Click);
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteActivity.Location = new System.Drawing.Point(152, 75);
            this.btnDeleteActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(142, 45);
            this.btnDeleteActivity.TabIndex = 13;
            this.btnDeleteActivity.Text = "Verwijderen";
            this.btnDeleteActivity.UseVisualStyleBackColor = false;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // btnSaveActivity
            // 
            this.btnSaveActivity.BackColor = System.Drawing.Color.Orange;
            this.btnSaveActivity.Location = new System.Drawing.Point(5, 75);
            this.btnSaveActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveActivity.Name = "btnSaveActivity";
            this.btnSaveActivity.Size = new System.Drawing.Size(142, 45);
            this.btnSaveActivity.TabIndex = 12;
            this.btnSaveActivity.Text = "Opslaan";
            this.btnSaveActivity.UseVisualStyleBackColor = false;
            this.btnSaveActivity.Click += new System.EventHandler(this.btnSaveActivity_Click);
            // 
            // txbFeedup_SelectedActivitity
            // 
            this.txbFeedup_SelectedActivitity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_SelectedActivitity.Location = new System.Drawing.Point(6, 32);
            this.txbFeedup_SelectedActivitity.Name = "txbFeedup_SelectedActivitity";
            this.txbFeedup_SelectedActivitity.Size = new System.Drawing.Size(558, 29);
            this.txbFeedup_SelectedActivitity.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(2, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Activiteit";
            // 
            // pnlNewActivity
            // 
            this.pnlNewActivity.Controls.Add(this.txbFeedup_TimeEstimation);
            this.pnlNewActivity.Controls.Add(this.label15);
            this.pnlNewActivity.Controls.Add(this.btnNewActivity);
            this.pnlNewActivity.Controls.Add(this.lblNewActivity);
            this.pnlNewActivity.Controls.Add(this.tbxNewActivity);
            this.pnlNewActivity.Location = new System.Drawing.Point(2, 47);
            this.pnlNewActivity.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNewActivity.Name = "pnlNewActivity";
            this.pnlNewActivity.Size = new System.Drawing.Size(580, 185);
            this.pnlNewActivity.TabIndex = 13;
            // 
            // txbFeedup_TimeEstimation
            // 
            this.txbFeedup_TimeEstimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_TimeEstimation.Location = new System.Drawing.Point(5, 92);
            this.txbFeedup_TimeEstimation.Name = "txbFeedup_TimeEstimation";
            this.txbFeedup_TimeEstimation.Size = new System.Drawing.Size(563, 29);
            this.txbFeedup_TimeEstimation.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(1, 65);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tijdsinschatting";
            // 
            // btnNewActivity
            // 
            this.btnNewActivity.BackColor = System.Drawing.Color.Orange;
            this.btnNewActivity.Location = new System.Drawing.Point(2, 130);
            this.btnNewActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewActivity.Name = "btnNewActivity";
            this.btnNewActivity.Size = new System.Drawing.Size(142, 45);
            this.btnNewActivity.TabIndex = 9;
            this.btnNewActivity.Text = "Toevoegen";
            this.btnNewActivity.UseVisualStyleBackColor = false;
            this.btnNewActivity.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // lblNewActivity
            // 
            this.lblNewActivity.AutoSize = true;
            this.lblNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewActivity.ForeColor = System.Drawing.Color.Black;
            this.lblNewActivity.Location = new System.Drawing.Point(2, 5);
            this.lblNewActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewActivity.Name = "lblNewActivity";
            this.lblNewActivity.Size = new System.Drawing.Size(133, 24);
            this.lblNewActivity.TabIndex = 8;
            this.lblNewActivity.Text = "Nieuw activiteit";
            // 
            // tbxNewActivity
            // 
            this.tbxNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewActivity.Location = new System.Drawing.Point(6, 32);
            this.tbxNewActivity.Name = "tbxNewActivity";
            this.tbxNewActivity.Size = new System.Drawing.Size(561, 29);
            this.tbxNewActivity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activiteiten";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnVraagStellen);
            this.pnlFeedback.Controls.Add(this.btnRegisterFeedback);
            this.pnlFeedback.Controls.Add(this.dgvFeedback);
            this.pnlFeedback.Controls.Add(this.lblFeedback);
            this.pnlFeedback.Controls.Add(this.pnlRegisterFeedback);
            this.pnlFeedback.Controls.Add(this.pnlAskQuestion);
            this.pnlFeedback.Location = new System.Drawing.Point(9, 85);
            this.pnlFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(1414, 743);
            this.pnlFeedback.TabIndex = 4;
            this.pnlFeedback.Visible = false;
            // 
            // btnVraagStellen
            // 
            this.btnVraagStellen.Location = new System.Drawing.Point(442, 627);
            this.btnVraagStellen.Name = "btnVraagStellen";
            this.btnVraagStellen.Size = new System.Drawing.Size(150, 85);
            this.btnVraagStellen.TabIndex = 7;
            this.btnVraagStellen.Text = "Vraag Stellen";
            this.btnVraagStellen.UseVisualStyleBackColor = true;
            this.btnVraagStellen.Click += new System.EventHandler(this.btnVraagStellen_Click);
            // 
            // btnRegisterFeedback
            // 
            this.btnRegisterFeedback.Location = new System.Drawing.Point(29, 627);
            this.btnRegisterFeedback.Name = "btnRegisterFeedback";
            this.btnRegisterFeedback.Size = new System.Drawing.Size(150, 85);
            this.btnRegisterFeedback.TabIndex = 6;
            this.btnRegisterFeedback.Text = "Registreer Feedback";
            this.btnRegisterFeedback.UseVisualStyleBackColor = true;
            this.btnRegisterFeedback.Click += new System.EventHandler(this.btnRegisterFeedback_Click);
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFeedback.ColumnHeadersHeight = 34;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeedbackID,
            this.FeedbackTeacher,
            this.FeedbackTitle,
            this.FeedbackDescription});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFeedback.Location = new System.Drawing.Point(29, 68);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersVisible = false;
            this.dgvFeedback.RowHeadersWidth = 51;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFeedback.RowTemplate.Height = 24;
            this.dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedback.Size = new System.Drawing.Size(563, 544);
            this.dgvFeedback.TabIndex = 2;
            this.dgvFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            // 
            // FeedbackID
            // 
            this.FeedbackID.FillWeight = 30F;
            this.FeedbackID.HeaderText = "ID";
            this.FeedbackID.MinimumWidth = 8;
            this.FeedbackID.Name = "FeedbackID";
            this.FeedbackID.Width = 50;
            // 
            // FeedbackTeacher
            // 
            this.FeedbackTeacher.HeaderText = "Auteur";
            this.FeedbackTeacher.MinimumWidth = 8;
            this.FeedbackTeacher.Name = "FeedbackTeacher";
            this.FeedbackTeacher.Width = 150;
            // 
            // FeedbackTitle
            // 
            this.FeedbackTitle.HeaderText = "Titel";
            this.FeedbackTitle.MinimumWidth = 8;
            this.FeedbackTitle.Name = "FeedbackTitle";
            this.FeedbackTitle.Width = 150;
            // 
            // FeedbackDescription
            // 
            this.FeedbackDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeedbackDescription.DefaultCellStyle = dataGridViewCellStyle7;
            this.FeedbackDescription.FillWeight = 5F;
            this.FeedbackDescription.HeaderText = "Descriptie";
            this.FeedbackDescription.MinimumWidth = 8;
            this.FeedbackDescription.Name = "FeedbackDescription";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedback.Location = new System.Drawing.Point(25, 11);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(121, 29);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Feedback";
            // 
            // pnlRegisterFeedback
            // 
            this.pnlRegisterFeedback.Controls.Add(this.btnFeedbackAdd);
            this.pnlRegisterFeedback.Controls.Add(this.label7);
            this.pnlRegisterFeedback.Controls.Add(this.label6);
            this.pnlRegisterFeedback.Controls.Add(this.cbxActivity);
            this.pnlRegisterFeedback.Controls.Add(this.cbxLearnGoal);
            this.pnlRegisterFeedback.Controls.Add(this.label5);
            this.pnlRegisterFeedback.Controls.Add(this.label4);
            this.pnlRegisterFeedback.Controls.Add(this.lblFeedbackAuteur);
            this.pnlRegisterFeedback.Controls.Add(this.txbFeedbackTeacher);
            this.pnlRegisterFeedback.Controls.Add(this.pcbUserIcon);
            this.pnlRegisterFeedback.Controls.Add(this.txbFeedbackDescription);
            this.pnlRegisterFeedback.Controls.Add(this.txbFeedbackTitle);
            this.pnlRegisterFeedback.Controls.Add(this.lblRegisterFeedback);
            this.pnlRegisterFeedback.Location = new System.Drawing.Point(642, 68);
            this.pnlRegisterFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegisterFeedback.Name = "pnlRegisterFeedback";
            this.pnlRegisterFeedback.Size = new System.Drawing.Size(752, 644);
            this.pnlRegisterFeedback.TabIndex = 5;
            this.pnlRegisterFeedback.Visible = false;
            // 
            // btnFeedbackAdd
            // 
            this.btnFeedbackAdd.Location = new System.Drawing.Point(534, 275);
            this.btnFeedbackAdd.Name = "btnFeedbackAdd";
            this.btnFeedbackAdd.Size = new System.Drawing.Size(180, 133);
            this.btnFeedbackAdd.TabIndex = 14;
            this.btnFeedbackAdd.Text = "Nieuwe Feedback";
            this.btnFeedbackAdd.UseVisualStyleBackColor = true;
            this.btnFeedbackAdd.Click += new System.EventHandler(this.btnFeedbackAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Activiteit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Leerdoel";
            // 
            // cbxActivity
            // 
            this.cbxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(284, 91);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(225, 32);
            this.cbxActivity.TabIndex = 11;
            // 
            // cbxLearnGoal
            // 
            this.cbxLearnGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLearnGoal.FormattingEnabled = true;
            this.cbxLearnGoal.Location = new System.Drawing.Point(37, 92);
            this.cbxLearnGoal.Name = "cbxLearnGoal";
            this.cbxLearnGoal.Size = new System.Drawing.Size(225, 32);
            this.cbxLearnGoal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titel";
            // 
            // lblFeedbackAuteur
            // 
            this.lblFeedbackAuteur.AutoSize = true;
            this.lblFeedbackAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAuteur.Location = new System.Drawing.Point(37, 126);
            this.lblFeedbackAuteur.Name = "lblFeedbackAuteur";
            this.lblFeedbackAuteur.Size = new System.Drawing.Size(70, 24);
            this.lblFeedbackAuteur.TabIndex = 7;
            this.lblFeedbackAuteur.Text = "Docent";
            // 
            // txbFeedbackTeacher
            // 
            this.txbFeedbackTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedbackTeacher.Location = new System.Drawing.Point(37, 153);
            this.txbFeedbackTeacher.Name = "txbFeedbackTeacher";
            this.txbFeedbackTeacher.Size = new System.Drawing.Size(472, 29);
            this.txbFeedbackTeacher.TabIndex = 6;
            // 
            // pcbUserIcon
            // 
            this.pcbUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbUserIcon.Image")));
            this.pcbUserIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbUserIcon.InitialImage")));
            this.pcbUserIcon.Location = new System.Drawing.Point(534, 91);
            this.pcbUserIcon.Name = "pcbUserIcon";
            this.pcbUserIcon.Size = new System.Drawing.Size(180, 178);
            this.pcbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserIcon.TabIndex = 5;
            this.pcbUserIcon.TabStop = false;
            // 
            // txbFeedbackDescription
            // 
            this.txbFeedbackDescription.Location = new System.Drawing.Point(37, 275);
            this.txbFeedbackDescription.Multiline = true;
            this.txbFeedbackDescription.Name = "txbFeedbackDescription";
            this.txbFeedbackDescription.Size = new System.Drawing.Size(472, 133);
            this.txbFeedbackDescription.TabIndex = 3;
            this.txbFeedbackDescription.TextChanged += new System.EventHandler(this.txbFeedbackDescription_TextChanged);
            // 
            // txbFeedbackTitle
            // 
            this.txbFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedbackTitle.Location = new System.Drawing.Point(37, 212);
            this.txbFeedbackTitle.Name = "txbFeedbackTitle";
            this.txbFeedbackTitle.Size = new System.Drawing.Size(472, 29);
            this.txbFeedbackTitle.TabIndex = 2;
            // 
            // lblRegisterFeedback
            // 
            this.lblRegisterFeedback.AutoSize = true;
            this.lblRegisterFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterFeedback.ForeColor = System.Drawing.Color.Orange;
            this.lblRegisterFeedback.Location = new System.Drawing.Point(35, 13);
            this.lblRegisterFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterFeedback.Name = "lblRegisterFeedback";
            this.lblRegisterFeedback.Size = new System.Drawing.Size(240, 29);
            this.lblRegisterFeedback.TabIndex = 1;
            this.lblRegisterFeedback.Text = "Registreer Feedback";
            // 
            // pnlAskQuestion
            // 
            this.pnlAskQuestion.Controls.Add(this.lblQuestionTeacher);
            this.pnlAskQuestion.Controls.Add(this.label14);
            this.pnlAskQuestion.Controls.Add(this.label10);
            this.pnlAskQuestion.Controls.Add(this.label13);
            this.pnlAskQuestion.Controls.Add(this.pictureBox1);
            this.pnlAskQuestion.Controls.Add(this.txbQuestion);
            this.pnlAskQuestion.Controls.Add(this.txbQuestionDescription);
            this.pnlAskQuestion.Controls.Add(this.txbQuestionTitle);
            this.pnlAskQuestion.Controls.Add(this.label1);
            this.pnlAskQuestion.Location = new System.Drawing.Point(642, 68);
            this.pnlAskQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAskQuestion.Name = "pnlAskQuestion";
            this.pnlAskQuestion.Size = new System.Drawing.Size(752, 644);
            this.pnlAskQuestion.TabIndex = 6;
            this.pnlAskQuestion.Visible = false;
            // 
            // lblQuestionTeacher
            // 
            this.lblQuestionTeacher.AutoSize = true;
            this.lblQuestionTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTeacher.ForeColor = System.Drawing.Color.Orange;
            this.lblQuestionTeacher.Location = new System.Drawing.Point(529, 53);
            this.lblQuestionTeacher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionTeacher.Name = "lblQuestionTeacher";
            this.lblQuestionTeacher.Size = new System.Drawing.Size(82, 29);
            this.lblQuestionTeacher.TabIndex = 13;
            this.lblQuestionTeacher.Text = "Auteur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Vraag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Beschrijving";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Titel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txbQuestion
            // 
            this.txbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestion.Location = new System.Drawing.Point(40, 317);
            this.txbQuestion.Multiline = true;
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.Size = new System.Drawing.Size(692, 272);
            this.txbQuestion.TabIndex = 4;
            // 
            // txbQuestionDescription
            // 
            this.txbQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestionDescription.Location = new System.Drawing.Point(41, 159);
            this.txbQuestionDescription.Multiline = true;
            this.txbQuestionDescription.Name = "txbQuestionDescription";
            this.txbQuestionDescription.Size = new System.Drawing.Size(472, 110);
            this.txbQuestionDescription.TabIndex = 3;
            // 
            // txbQuestionTitle
            // 
            this.txbQuestionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestionTitle.Location = new System.Drawing.Point(40, 89);
            this.txbQuestionTitle.Name = "txbQuestionTitle";
            this.txbQuestionTitle.Size = new System.Drawing.Size(472, 29);
            this.txbQuestionTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vraag Stellen";
            // 
            // pnlFeedforward
            // 
            this.pnlFeedforward.Controls.Add(this.dgvFeedback2);
            this.pnlFeedforward.Controls.Add(this.lblFeedback2);
            this.pnlFeedforward.Controls.Add(this.dataGridView1);
            this.pnlFeedforward.Controls.Add(this.dgvLearnGoals2);
            this.pnlFeedforward.Controls.Add(this.lblConclusion);
            this.pnlFeedforward.Controls.Add(this.lblLearnGoals2);
            this.pnlFeedforward.Location = new System.Drawing.Point(9, 85);
            this.pnlFeedforward.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedforward.Name = "pnlFeedforward";
            this.pnlFeedforward.Size = new System.Drawing.Size(1406, 743);
            this.pnlFeedforward.TabIndex = 5;
            this.pnlFeedforward.Visible = false;
            // 
            // dgvFeedback2
            // 
            this.dgvFeedback2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedforwardFeedbackID,
            this.clnFeedforwardFeedbackFeedback});
            this.dgvFeedback2.Location = new System.Drawing.Point(344, 43);
            this.dgvFeedback2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFeedback2.Name = "dgvFeedback2";
            this.dgvFeedback2.RowHeadersVisible = false;
            this.dgvFeedback2.RowHeadersWidth = 51;
            this.dgvFeedback2.RowTemplate.Height = 24;
            this.dgvFeedback2.Size = new System.Drawing.Size(180, 171);
            this.dgvFeedback2.TabIndex = 5;
            // 
            // clnFeedforwardFeedbackID
            // 
            this.clnFeedforwardFeedbackID.HeaderText = "ID";
            this.clnFeedforwardFeedbackID.MinimumWidth = 6;
            this.clnFeedforwardFeedbackID.Name = "clnFeedforwardFeedbackID";
            this.clnFeedforwardFeedbackID.Width = 125;
            // 
            // clnFeedforwardFeedbackFeedback
            // 
            this.clnFeedforwardFeedbackFeedback.HeaderText = "Feedback";
            this.clnFeedforwardFeedbackFeedback.MinimumWidth = 6;
            this.clnFeedforwardFeedbackFeedback.Name = "clnFeedforwardFeedbackFeedback";
            this.clnFeedforwardFeedbackFeedback.Width = 125;
            // 
            // lblFeedback2
            // 
            this.lblFeedback2.AutoSize = true;
            this.lblFeedback2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback2.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedback2.Location = new System.Drawing.Point(340, 11);
            this.lblFeedback2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeedback2.Name = "lblFeedback2";
            this.lblFeedback2.Size = new System.Drawing.Size(121, 29);
            this.lblFeedback2.TabIndex = 4;
            this.lblFeedback2.Text = "Feedback";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedforwardConclusionID,
            this.clnFeedforwardConclusionConclusion});
            this.dataGridView1.Location = new System.Drawing.Point(710, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(180, 171);
            this.dataGridView1.TabIndex = 3;
            // 
            // clnFeedforwardConclusionID
            // 
            this.clnFeedforwardConclusionID.HeaderText = "ID";
            this.clnFeedforwardConclusionID.MinimumWidth = 6;
            this.clnFeedforwardConclusionID.Name = "clnFeedforwardConclusionID";
            this.clnFeedforwardConclusionID.Width = 125;
            // 
            // clnFeedforwardConclusionConclusion
            // 
            this.clnFeedforwardConclusionConclusion.HeaderText = "Conclusie";
            this.clnFeedforwardConclusionConclusion.MinimumWidth = 6;
            this.clnFeedforwardConclusionConclusion.Name = "clnFeedforwardConclusionConclusion";
            this.clnFeedforwardConclusionConclusion.Width = 125;
            // 
            // dgvLearnGoals2
            // 
            this.dgvLearnGoals2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnGoals2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedforwardLearnGoalID,
            this.clnFeedforwardLearngoal});
            this.dgvLearnGoals2.Location = new System.Drawing.Point(29, 43);
            this.dgvLearnGoals2.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLearnGoals2.Name = "dgvLearnGoals2";
            this.dgvLearnGoals2.RowHeadersVisible = false;
            this.dgvLearnGoals2.RowHeadersWidth = 51;
            this.dgvLearnGoals2.RowTemplate.Height = 24;
            this.dgvLearnGoals2.Size = new System.Drawing.Size(180, 171);
            this.dgvLearnGoals2.TabIndex = 2;
            // 
            // clnFeedforwardLearnGoalID
            // 
            this.clnFeedforwardLearnGoalID.HeaderText = "ID";
            this.clnFeedforwardLearnGoalID.MinimumWidth = 6;
            this.clnFeedforwardLearnGoalID.Name = "clnFeedforwardLearnGoalID";
            this.clnFeedforwardLearnGoalID.Width = 125;
            // 
            // clnFeedforwardLearngoal
            // 
            this.clnFeedforwardLearngoal.HeaderText = "Leerdoel";
            this.clnFeedforwardLearngoal.MinimumWidth = 6;
            this.clnFeedforwardLearngoal.Name = "clnFeedforwardLearngoal";
            this.clnFeedforwardLearngoal.Width = 125;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.ForeColor = System.Drawing.Color.Orange;
            this.lblConclusion.Location = new System.Drawing.Point(705, 11);
            this.lblConclusion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(120, 29);
            this.lblConclusion.TabIndex = 1;
            this.lblConclusion.Text = "Conclusie";
            // 
            // lblLearnGoals2
            // 
            this.lblLearnGoals2.AutoSize = true;
            this.lblLearnGoals2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals2.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals2.Location = new System.Drawing.Point(25, 11);
            this.lblLearnGoals2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLearnGoals2.Name = "lblLearnGoals2";
            this.lblLearnGoals2.Size = new System.Drawing.Size(137, 29);
            this.lblLearnGoals2.TabIndex = 0;
            this.lblLearnGoals2.Text = "Leerdoelen";
            // 
            // pnlConclusion
            // 
            this.pnlConclusion.Controls.Add(this.dataGridView3);
            this.pnlConclusion.Controls.Add(this.label2);
            this.pnlConclusion.Location = new System.Drawing.Point(9, 85);
            this.pnlConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.pnlConclusion.Name = "pnlConclusion";
            this.pnlConclusion.Size = new System.Drawing.Size(1406, 743);
            this.pnlConclusion.TabIndex = 5;
            this.pnlConclusion.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnConclusionConclusionID,
            this.clnConclusionConclusionConclusion});
            this.dataGridView3.Location = new System.Drawing.Point(29, 68);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1345, 602);
            this.dataGridView3.TabIndex = 2;
            // 
            // clnConclusionConclusionID
            // 
            this.clnConclusionConclusionID.HeaderText = "ID";
            this.clnConclusionConclusionID.MinimumWidth = 6;
            this.clnConclusionConclusionID.Name = "clnConclusionConclusionID";
            this.clnConclusionConclusionID.Width = 125;
            // 
            // clnConclusionConclusionConclusion
            // 
            this.clnConclusionConclusionConclusion.HeaderText = "Conclusie";
            this.clnConclusionConclusionConclusion.MinimumWidth = 6;
            this.clnConclusionConclusionConclusion.Name = "clnConclusionConclusionConclusion";
            this.clnConclusionConclusionConclusion.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conclusie";
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.HeaderText = "Vaknaam";
            this.SubjectName.MinimumWidth = 8;
            this.SubjectName.Name = "SubjectName";
            // 
            // Following
            // 
            this.Following.HeaderText = "Volgend";
            this.Following.MinimumWidth = 8;
            this.Following.Name = "Following";
            this.Following.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Following.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Following.Width = 60;
            // 
            // lblNewSubject
            // 
            this.lblNewSubject.AutoSize = true;
            this.lblNewSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSubject.ForeColor = System.Drawing.Color.Black;
            this.lblNewSubject.Location = new System.Drawing.Point(13, 45);
            this.lblNewSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewSubject.Name = "lblNewSubject";
            this.lblNewSubject.Size = new System.Drawing.Size(101, 24);
            this.lblNewSubject.TabIndex = 6;
            this.lblNewSubject.Text = "Nieuw Vak";
            // 
            // txbSubject
            // 
            this.txbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubject.Location = new System.Drawing.Point(18, 73);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(161, 26);
            this.txbSubject.TabIndex = 5;
            // 
            // lblBeheerVakken
            // 
            this.lblBeheerVakken.AutoSize = true;
            this.lblBeheerVakken.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBeheerVakken.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeheerVakken.ForeColor = System.Drawing.Color.Orange;
            this.lblBeheerVakken.Location = new System.Drawing.Point(902, 11);
            this.lblBeheerVakken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeheerVakken.Name = "lblBeheerVakken";
            this.lblBeheerVakken.Size = new System.Drawing.Size(177, 29);
            this.lblBeheerVakken.TabIndex = 2;
            this.lblBeheerVakken.Text = "Beheer Vakken";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Orange;
            this.lblHome.Location = new System.Drawing.Point(13, 11);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(78, 29);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.dgvSubjects);
            this.pnlHome.Controls.Add(this.lblNewSubject_);
            this.pnlHome.Controls.Add(this.txbAddSubject);
            this.pnlHome.Controls.Add(this.btnAddSubject);
            this.pnlHome.Controls.Add(this.lblManageSubjects);
            this.pnlHome.Controls.Add(this.lblHome_);
            this.pnlHome.Location = new System.Drawing.Point(9, 85);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1414, 743);
            this.pnlHome.TabIndex = 9;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToResizeColumns = false;
            this.dgvSubjects.AllowUserToResizeRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.dgvSubjects.Location = new System.Drawing.Point(907, 45);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowHeadersWidth = 62;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(259, 396);
            this.dgvSubjects.TabIndex = 8;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSubjects_CellContentClick);
            this.dgvSubjects.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSubjects_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Vaknaam";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Volgend";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // lblNewSubject_
            // 
            this.lblNewSubject_.AutoSize = true;
            this.lblNewSubject_.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewSubject_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSubject_.ForeColor = System.Drawing.Color.Black;
            this.lblNewSubject_.Location = new System.Drawing.Point(13, 45);
            this.lblNewSubject_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewSubject_.Name = "lblNewSubject_";
            this.lblNewSubject_.Size = new System.Drawing.Size(101, 24);
            this.lblNewSubject_.TabIndex = 6;
            this.lblNewSubject_.Text = "Nieuw Vak";
            // 
            // txbAddSubject
            // 
            this.txbAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddSubject.Location = new System.Drawing.Point(18, 73);
            this.txbAddSubject.Name = "txbAddSubject";
            this.txbAddSubject.Size = new System.Drawing.Size(161, 26);
            this.txbAddSubject.TabIndex = 5;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(185, 73);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 26);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lblManageSubjects
            // 
            this.lblManageSubjects.AutoSize = true;
            this.lblManageSubjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblManageSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSubjects.ForeColor = System.Drawing.Color.Orange;
            this.lblManageSubjects.Location = new System.Drawing.Point(902, 11);
            this.lblManageSubjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageSubjects.Name = "lblManageSubjects";
            this.lblManageSubjects.Size = new System.Drawing.Size(177, 29);
            this.lblManageSubjects.TabIndex = 2;
            this.lblManageSubjects.Text = "Beheer Vakken";
            // 
            // lblHome_
            // 
            this.lblHome_.AutoSize = true;
            this.lblHome_.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHome_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome_.ForeColor = System.Drawing.Color.Orange;
            this.lblHome_.Location = new System.Drawing.Point(13, 11);
            this.lblHome_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome_.Name = "lblHome_";
            this.lblHome_.Size = new System.Drawing.Size(78, 29);
            this.lblHome_.TabIndex = 1;
            this.lblHome_.Text = "Home";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 839);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlFeedup);
            this.Controls.Add(this.pnlConclusion);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.pnlFeedforward);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFeedup.ResumeLayout(false);
            this.pnlFeedup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals)).EndInit();
            this.pnlLearngoal.ResumeLayout(false);
            this.pnlLearngoal.PerformLayout();
            this.pnlAddLearngoal.ResumeLayout(false);
            this.pnlAddLearngoal.PerformLayout();
            this.pnlUpdateLearngoal.ResumeLayout(false);
            this.pnlUpdateLearngoal.PerformLayout();
            this.pnlTimeSpent.ResumeLayout(false);
            this.pnlTimeSpent.PerformLayout();
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivity.PerformLayout();
            this.pnlUpdateActivity.ResumeLayout(false);
            this.pnlUpdateActivity.PerformLayout();
            this.pnlNewActivity.ResumeLayout(false);
            this.pnlNewActivity.PerformLayout();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.pnlRegisterFeedback.ResumeLayout(false);
            this.pnlRegisterFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserIcon)).EndInit();
            this.pnlAskQuestion.ResumeLayout(false);
            this.pnlAskQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFeedforward.ResumeLayout(false);
            this.pnlFeedforward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals2)).EndInit();
            this.pnlConclusion.ResumeLayout(false);
            this.pnlConclusion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComboBox cbxPanelSwitch;
        private ComboBox cbxSubject;
        private ComboBox cbxWeek;
        private Label lblStudentClass;
        private Label lblStudentName;
        private Panel pnlFeedup;
        private Label lblLearnGoals;
        private Label lblActivities;
        private Panel pnlFeedback;
        private DataGridView dgvFeedback;
        private Label lblRegisterFeedback;
        private Label lblFeedback;
        private DataGridView dgvActivities;
        private DataGridView dgvLearnGoals;
        private Panel pnlFeedforward;
        private Label lblFeedback2;
        private DataGridView dataGridView1;
        private DataGridView dgvLearnGoals2;
        private Label lblConclusion;
        private Label lblLearnGoals2;
        private DataGridView dgvFeedback2;
        private Panel pnlConclusion;
        private DataGridView dataGridView3;
        private Label label2;
        private DataGridViewTextBoxColumn clnFeedforwardFeedbackID;
        private DataGridViewTextBoxColumn clnFeedforwardFeedbackFeedback;
        private DataGridViewTextBoxColumn clnFeedforwardConclusionID;
        private DataGridViewTextBoxColumn clnFeedforwardConclusionConclusion;
        private DataGridViewTextBoxColumn clnFeedforwardLearnGoalID;
        private DataGridViewTextBoxColumn clnFeedforwardLearngoal;
        private DataGridViewTextBoxColumn clnConclusionConclusionID;
        private DataGridViewTextBoxColumn clnConclusionConclusionConclusion;
        private Button btnLogOut;
        private Button btnVraagStellen;
        private Button btnRegisterFeedback;
        private Panel pnlRegisterFeedback;
        private PictureBox pcbUserIcon;
        private TextBox txbFeedbackDescription;
        private TextBox txbFeedbackTitle;
        private Panel pnlAskQuestion;
        private PictureBox pictureBox1;
        private TextBox txbQuestion;
        private TextBox txbQuestionDescription;
        private TextBox txbQuestionTitle;
        private Label label1;
        private Label label7;
        private Label label6;
        private ComboBox cbxActivity;
        private ComboBox cbxLearnGoal;
        private Label label5;
        private Label label4;
        private Label lblFeedbackAuteur;
        private TextBox txbFeedbackTeacher;
        private Button btnFeedup_SwitchActivity;
        private Button btnFeedup_SwitchLearngoal;
        private Panel pnlLearngoal;
        private Button btnUpdateLearnGoalpnl;
        private Label label11;
        private TextBox txbFeedup_AddLearngoal;
        private Label label12;
        private Panel pnlActivity;
        private Label label3;
        private Button btnFeedbackAdd;
        private Label label14;
        private Label label10;
        private Label label13;
        private DataGridViewTextBoxColumn FeedbackID;
        private DataGridViewTextBoxColumn FeedbackTeacher;
        private DataGridViewTextBoxColumn FeedbackTitle;
        private DataGridViewTextBoxColumn FeedbackDescription;
        private Label lblQuestionTeacher;
        private Label lblNewSubject;
        private TextBox txbSubject;
        private Label lblBeheerVakken;
        private Label lblHome;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewCheckBoxColumn Following;
        private Button button1;
        private DataGridViewTextBoxColumn clnFeedupLearnGoalID;
        private DataGridViewTextBoxColumn clnFeedupLearnGoalLearnGoal;
        private Panel pnlTimeSpent;
        private Button btnSaveTimeSpent;
        private TextBox txbTimeSpent;
        private Label lblCompleted;
        private Panel pnlHome;
        private DataGridView dgvSubjects;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Label lblNewSubject_;
        private TextBox txbAddSubject;
        private Button btnAddSubject;
        private Label lblManageSubjects;
        private Label lblHome_;
        private DataGridViewTextBoxColumn clnFeedupActivitiesID;
        private DataGridViewTextBoxColumn clnFeedupActivitiesActivity;
        private DataGridViewTextBoxColumn dgcTimeEstimation;
        private DataGridViewCheckBoxColumn Completed;
        private Panel pnlAddLearngoal;
        private Button btnAddLearngoal;
        private Panel pnlUpdateLearngoal;
        private Button btnBackLearngoal;
        private Button btnDeleteLearngoal;
        private Button btnSaveLearngoal;
        private TextBox txbSelectedLearngoal;
        private Label lblUpdateLearngoal;
        private Button btnUpdateActivity;
        private Panel pnlUpdateActivity;
        private TextBox txbFeedup_SelectedActivitity;
        private Label label8;
        private Panel pnlNewActivity;
        private Button btnNewActivity;
        private Label lblNewActivity;
        private TextBox tbxNewActivity;
        private TextBox txbFeedup_TimeEstimation;
        private Label label15;
        private Button btnActivityBack;
        private Button btnDeleteActivity;
        private Button btnSaveActivity;
    }
}