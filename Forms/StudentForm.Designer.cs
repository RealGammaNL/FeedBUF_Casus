using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbFeedup_TimeEstimation = new System.Windows.Forms.TextBox();
            this.txbFeedup_Activitity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTimeSpent = new System.Windows.Forms.Panel();
            this.btnSaveTimeSpent = new System.Windows.Forms.Button();
            this.txbTimeSpent = new System.Windows.Forms.TextBox();
            this.lblCompleted = new System.Windows.Forms.Label();
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
            this.pnlUpdateLearngoal = new System.Windows.Forms.Panel();
            this.lblUpdateLearngoal = new System.Windows.Forms.Label();
            this.tbxSelectedLearngoal = new System.Windows.Forms.TextBox();
            this.btnSaveLearngoal = new System.Windows.Forms.Button();
            this.btnDeleteLearngoal = new System.Windows.Forms.Button();
            this.btnBackLearngoal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals)).BeginInit();
            this.pnlLearngoal.SuspendLayout();
            this.pnlAddLearngoal.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.pnlTimeSpent.SuspendLayout();
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
            this.pnlUpdateLearngoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(20, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 88);
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
            this.groupBox1.Location = new System.Drawing.Point(-6, -15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2188, 138);
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
            this.btnLogOut.Location = new System.Drawing.Point(2054, 29);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 88);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(1906, 72);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(39, 20);
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
            this.cbxSubject.Location = new System.Drawing.Point(476, 51);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(340, 37);
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
            this.cbxWeek.Location = new System.Drawing.Point(318, 51);
            this.cbxWeek.Name = "cbxWeek";
            this.cbxWeek.Size = new System.Drawing.Size(136, 37);
            this.cbxWeek.TabIndex = 2;
            this.cbxWeek.SelectedIndexChanged += new System.EventHandler(this.WeekChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(1906, 51);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(106, 20);
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
            this.cbxPanelSwitch.Location = new System.Drawing.Point(122, 51);
            this.cbxPanelSwitch.Name = "cbxPanelSwitch";
            this.cbxPanelSwitch.Size = new System.Drawing.Size(178, 37);
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
            this.pnlFeedup.Controls.Add(this.pnlActivity);
            this.pnlFeedup.Controls.Add(this.pnlTimeSpent);
            this.pnlFeedup.Location = new System.Drawing.Point(14, 131);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(2109, 1143);
            this.pnlFeedup.TabIndex = 3;
            this.pnlFeedup.Visible = false;
            this.pnlFeedup.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFeedup_Paint);
            // 
            // btnFeedup_SwitchActivity
            // 
            this.btnFeedup_SwitchActivity.Location = new System.Drawing.Point(1478, 18);
            this.btnFeedup_SwitchActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeedup_SwitchActivity.Name = "btnFeedup_SwitchActivity";
            this.btnFeedup_SwitchActivity.Size = new System.Drawing.Size(213, 55);
            this.btnFeedup_SwitchActivity.TabIndex = 7;
            this.btnFeedup_SwitchActivity.Text = "Activiteit Beheren";
            this.btnFeedup_SwitchActivity.UseVisualStyleBackColor = true;
            this.btnFeedup_SwitchActivity.Click += new System.EventHandler(this.btnFeedup_SwitchActivity_Click);
            // 
            // btnFeedup_SwitchLearngoal
            // 
            this.btnFeedup_SwitchLearngoal.Location = new System.Drawing.Point(1244, 18);
            this.btnFeedup_SwitchLearngoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeedup_SwitchLearngoal.Name = "btnFeedup_SwitchLearngoal";
            this.btnFeedup_SwitchLearngoal.Size = new System.Drawing.Size(213, 55);
            this.btnFeedup_SwitchLearngoal.TabIndex = 6;
            this.btnFeedup_SwitchLearngoal.Text = "Leerdoel Beheren";
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
            this.dgvActivities.Location = new System.Drawing.Point(630, 105);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(525, 1000);
            this.dgvActivities.TabIndex = 3;
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
            this.dgvLearnGoals.Location = new System.Drawing.Point(44, 105);
            this.dgvLearnGoals.MultiSelect = false;
            this.dgvLearnGoals.Name = "dgvLearnGoals";
            this.dgvLearnGoals.ReadOnly = true;
            this.dgvLearnGoals.RowHeadersVisible = false;
            this.dgvLearnGoals.RowHeadersWidth = 51;
            this.dgvLearnGoals.RowTemplate.Height = 24;
            this.dgvLearnGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLearnGoals.Size = new System.Drawing.Size(525, 1000);
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
            this.lblActivities.Location = new System.Drawing.Point(622, 18);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(191, 40);
            this.lblActivities.TabIndex = 1;
            this.lblActivities.Text = "Activiteiten";
            // 
            // lblLearnGoals
            // 
            this.lblLearnGoals.AutoSize = true;
            this.lblLearnGoals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals.Location = new System.Drawing.Point(38, 17);
            this.lblLearnGoals.Name = "lblLearnGoals";
            this.lblLearnGoals.Size = new System.Drawing.Size(197, 40);
            this.lblLearnGoals.TabIndex = 0;
            this.lblLearnGoals.Text = "Leerdoelen";
            // 
            // pnlLearngoal
            // 
            this.pnlLearngoal.Controls.Add(this.pnlUpdateLearngoal);
            this.pnlLearngoal.Controls.Add(this.pnlAddLearngoal);
            this.pnlLearngoal.Controls.Add(this.btnUpdateLearnGoalpnl);
            this.pnlLearngoal.Controls.Add(this.label12);
            this.pnlLearngoal.Location = new System.Drawing.Point(1202, 105);
            this.pnlLearngoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLearngoal.Name = "pnlLearngoal";
            this.pnlLearngoal.Size = new System.Drawing.Size(885, 1014);
            this.pnlLearngoal.TabIndex = 10;
            // 
            // pnlAddLearngoal
            // 
            this.pnlAddLearngoal.Controls.Add(this.btnAddLearngoal);
            this.pnlAddLearngoal.Controls.Add(this.label11);
            this.pnlAddLearngoal.Controls.Add(this.txbFeedup_AddLearngoal);
            this.pnlAddLearngoal.Location = new System.Drawing.Point(12, 78);
            this.pnlAddLearngoal.Name = "pnlAddLearngoal";
            this.pnlAddLearngoal.Size = new System.Drawing.Size(870, 226);
            this.pnlAddLearngoal.TabIndex = 12;
            // 
            // btnAddLearngoal
            // 
            this.btnAddLearngoal.BackColor = System.Drawing.Color.Orange;
            this.btnAddLearngoal.Location = new System.Drawing.Point(11, 111);
            this.btnAddLearngoal.Name = "btnAddLearngoal";
            this.btnAddLearngoal.Size = new System.Drawing.Size(213, 69);
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
            this.label11.Location = new System.Drawing.Point(3, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 33);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nieuw leerdoel";
            // 
            // txbFeedup_AddLearngoal
            // 
            this.txbFeedup_AddLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_AddLearngoal.Location = new System.Drawing.Point(9, 58);
            this.txbFeedup_AddLearngoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedup_AddLearngoal.Name = "txbFeedup_AddLearngoal";
            this.txbFeedup_AddLearngoal.Size = new System.Drawing.Size(839, 40);
            this.txbFeedup_AddLearngoal.TabIndex = 6;
            // 
            // btnUpdateLearnGoalpnl
            // 
            this.btnUpdateLearnGoalpnl.Location = new System.Drawing.Point(647, 15);
            this.btnUpdateLearnGoalpnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateLearnGoalpnl.Name = "btnUpdateLearnGoalpnl";
            this.btnUpdateLearnGoalpnl.Size = new System.Drawing.Size(213, 55);
            this.btnUpdateLearnGoalpnl.TabIndex = 11;
            this.btnUpdateLearnGoalpnl.Text = "Leerdoel beheren";
            this.btnUpdateLearnGoalpnl.UseVisualStyleBackColor = true;
            this.btnUpdateLearnGoalpnl.Click += new System.EventHandler(this.btnAddLearnGoal_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(14, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 40);
            this.label12.TabIndex = 5;
            this.label12.Text = "Leerdoel";
            // 
            // pnlActivity
            // 
            this.pnlActivity.Controls.Add(this.btnAddActivity);
            this.pnlActivity.Controls.Add(this.label9);
            this.pnlActivity.Controls.Add(this.label8);
            this.pnlActivity.Controls.Add(this.txbFeedup_TimeEstimation);
            this.pnlActivity.Controls.Add(this.txbFeedup_Activitity);
            this.pnlActivity.Controls.Add(this.label3);
            this.pnlActivity.Location = new System.Drawing.Point(1202, 105);
            this.pnlActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(885, 1014);
            this.pnlActivity.TabIndex = 4;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(44, 312);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(213, 55);
            this.btnAddActivity.TabIndex = 12;
            this.btnAddActivity.Text = "Activiteit toevoegen";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 33);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tijdsinschatting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 33);
            this.label8.TabIndex = 8;
            this.label8.Text = "Activiteit";
            // 
            // txbFeedup_TimeEstimation
            // 
            this.txbFeedup_TimeEstimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_TimeEstimation.Location = new System.Drawing.Point(42, 240);
            this.txbFeedup_TimeEstimation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedup_TimeEstimation.Name = "txbFeedup_TimeEstimation";
            this.txbFeedup_TimeEstimation.Size = new System.Drawing.Size(788, 40);
            this.txbFeedup_TimeEstimation.TabIndex = 7;
            // 
            // txbFeedup_Activitity
            // 
            this.txbFeedup_Activitity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedup_Activitity.Location = new System.Drawing.Point(42, 129);
            this.txbFeedup_Activitity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedup_Activitity.Name = "txbFeedup_Activitity";
            this.txbFeedup_Activitity.Size = new System.Drawing.Size(788, 40);
            this.txbFeedup_Activitity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(34, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activiteiten";
            // 
            // pnlTimeSpent
            // 
            this.pnlTimeSpent.Controls.Add(this.btnSaveTimeSpent);
            this.pnlTimeSpent.Controls.Add(this.txbTimeSpent);
            this.pnlTimeSpent.Controls.Add(this.lblCompleted);
            this.pnlTimeSpent.Location = new System.Drawing.Point(1196, 105);
            this.pnlTimeSpent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTimeSpent.Name = "pnlTimeSpent";
            this.pnlTimeSpent.Size = new System.Drawing.Size(532, 243);
            this.pnlTimeSpent.TabIndex = 11;
            this.pnlTimeSpent.Visible = false;
            // 
            // btnSaveTimeSpent
            // 
            this.btnSaveTimeSpent.BackColor = System.Drawing.Color.Orange;
            this.btnSaveTimeSpent.Location = new System.Drawing.Point(18, 138);
            this.btnSaveTimeSpent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTimeSpent.Name = "btnSaveTimeSpent";
            this.btnSaveTimeSpent.Size = new System.Drawing.Size(152, 66);
            this.btnSaveTimeSpent.TabIndex = 2;
            this.btnSaveTimeSpent.Text = "Opslaan";
            this.btnSaveTimeSpent.UseVisualStyleBackColor = false;
            this.btnSaveTimeSpent.Click += new System.EventHandler(this.btnSaveTimeSpent_Click);
            // 
            // txbTimeSpent
            // 
            this.txbTimeSpent.Location = new System.Drawing.Point(24, 83);
            this.txbTimeSpent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTimeSpent.Name = "txbTimeSpent";
            this.txbTimeSpent.Size = new System.Drawing.Size(148, 26);
            this.txbTimeSpent.TabIndex = 1;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCompleted.Location = new System.Drawing.Point(22, 25);
            this.lblCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(491, 29);
            this.lblCompleted.TabIndex = 0;
            this.lblCompleted.Text = "Hoe lang heeft u over deze activiteit gedaan?";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnVraagStellen);
            this.pnlFeedback.Controls.Add(this.btnRegisterFeedback);
            this.pnlFeedback.Controls.Add(this.dgvFeedback);
            this.pnlFeedback.Controls.Add(this.lblFeedback);
            this.pnlFeedback.Controls.Add(this.pnlRegisterFeedback);
            this.pnlFeedback.Controls.Add(this.pnlAskQuestion);
            this.pnlFeedback.Location = new System.Drawing.Point(14, 131);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(2121, 1143);
            this.pnlFeedback.TabIndex = 4;
            this.pnlFeedback.Visible = false;
            // 
            // btnVraagStellen
            // 
            this.btnVraagStellen.Location = new System.Drawing.Point(663, 965);
            this.btnVraagStellen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVraagStellen.Name = "btnVraagStellen";
            this.btnVraagStellen.Size = new System.Drawing.Size(225, 131);
            this.btnVraagStellen.TabIndex = 7;
            this.btnVraagStellen.Text = "Vraag Stellen";
            this.btnVraagStellen.UseVisualStyleBackColor = true;
            this.btnVraagStellen.Click += new System.EventHandler(this.btnVraagStellen_Click);
            // 
            // btnRegisterFeedback
            // 
            this.btnRegisterFeedback.Location = new System.Drawing.Point(44, 965);
            this.btnRegisterFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterFeedback.Name = "btnRegisterFeedback";
            this.btnRegisterFeedback.Size = new System.Drawing.Size(225, 131);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFeedback.Location = new System.Drawing.Point(44, 105);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersVisible = false;
            this.dgvFeedback.RowHeadersWidth = 51;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedback.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFeedback.RowTemplate.Height = 24;
            this.dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedback.Size = new System.Drawing.Size(844, 837);
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
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeedbackDescription.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.lblFeedback.Location = new System.Drawing.Point(38, 17);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(175, 40);
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
            this.pnlRegisterFeedback.Location = new System.Drawing.Point(963, 105);
            this.pnlRegisterFeedback.Name = "pnlRegisterFeedback";
            this.pnlRegisterFeedback.Size = new System.Drawing.Size(1128, 991);
            this.pnlRegisterFeedback.TabIndex = 5;
            this.pnlRegisterFeedback.Visible = false;
            // 
            // btnFeedbackAdd
            // 
            this.btnFeedbackAdd.Location = new System.Drawing.Point(801, 423);
            this.btnFeedbackAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFeedbackAdd.Name = "btnFeedbackAdd";
            this.btnFeedbackAdd.Size = new System.Drawing.Size(270, 205);
            this.btnFeedbackAdd.TabIndex = 14;
            this.btnFeedbackAdd.Text = "Nieuwe Feedback";
            this.btnFeedbackAdd.UseVisualStyleBackColor = true;
            this.btnFeedbackAdd.Click += new System.EventHandler(this.btnFeedbackAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Activiteit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Leerdoel";
            // 
            // cbxActivity
            // 
            this.cbxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActivity.FormattingEnabled = true;
            this.cbxActivity.Location = new System.Drawing.Point(426, 140);
            this.cbxActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxActivity.Name = "cbxActivity";
            this.cbxActivity.Size = new System.Drawing.Size(336, 41);
            this.cbxActivity.TabIndex = 11;
            // 
            // cbxLearnGoal
            // 
            this.cbxLearnGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLearnGoal.FormattingEnabled = true;
            this.cbxLearnGoal.Location = new System.Drawing.Point(56, 142);
            this.cbxLearnGoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxLearnGoal.Name = "cbxLearnGoal";
            this.cbxLearnGoal.Size = new System.Drawing.Size(336, 41);
            this.cbxLearnGoal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titel";
            // 
            // lblFeedbackAuteur
            // 
            this.lblFeedbackAuteur.AutoSize = true;
            this.lblFeedbackAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackAuteur.Location = new System.Drawing.Point(56, 194);
            this.lblFeedbackAuteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedbackAuteur.Name = "lblFeedbackAuteur";
            this.lblFeedbackAuteur.Size = new System.Drawing.Size(107, 33);
            this.lblFeedbackAuteur.TabIndex = 7;
            this.lblFeedbackAuteur.Text = "Docent";
            // 
            // txbFeedbackTeacher
            // 
            this.txbFeedbackTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedbackTeacher.Location = new System.Drawing.Point(56, 235);
            this.txbFeedbackTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedbackTeacher.Name = "txbFeedbackTeacher";
            this.txbFeedbackTeacher.Size = new System.Drawing.Size(706, 40);
            this.txbFeedbackTeacher.TabIndex = 6;
            // 
            // pcbUserIcon
            // 
            this.pcbUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbUserIcon.Image")));
            this.pcbUserIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbUserIcon.InitialImage")));
            this.pcbUserIcon.Location = new System.Drawing.Point(801, 140);
            this.pcbUserIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbUserIcon.Name = "pcbUserIcon";
            this.pcbUserIcon.Size = new System.Drawing.Size(270, 274);
            this.pcbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserIcon.TabIndex = 5;
            this.pcbUserIcon.TabStop = false;
            // 
            // txbFeedbackDescription
            // 
            this.txbFeedbackDescription.Location = new System.Drawing.Point(56, 423);
            this.txbFeedbackDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedbackDescription.Multiline = true;
            this.txbFeedbackDescription.Name = "txbFeedbackDescription";
            this.txbFeedbackDescription.Size = new System.Drawing.Size(706, 202);
            this.txbFeedbackDescription.TabIndex = 3;
            this.txbFeedbackDescription.TextChanged += new System.EventHandler(this.txbFeedbackDescription_TextChanged);
            // 
            // txbFeedbackTitle
            // 
            this.txbFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeedbackTitle.Location = new System.Drawing.Point(56, 326);
            this.txbFeedbackTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbFeedbackTitle.Name = "txbFeedbackTitle";
            this.txbFeedbackTitle.Size = new System.Drawing.Size(706, 40);
            this.txbFeedbackTitle.TabIndex = 2;
            // 
            // lblRegisterFeedback
            // 
            this.lblRegisterFeedback.AutoSize = true;
            this.lblRegisterFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterFeedback.ForeColor = System.Drawing.Color.Orange;
            this.lblRegisterFeedback.Location = new System.Drawing.Point(52, 20);
            this.lblRegisterFeedback.Name = "lblRegisterFeedback";
            this.lblRegisterFeedback.Size = new System.Drawing.Size(351, 40);
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
            this.pnlAskQuestion.Location = new System.Drawing.Point(963, 105);
            this.pnlAskQuestion.Name = "pnlAskQuestion";
            this.pnlAskQuestion.Size = new System.Drawing.Size(1128, 991);
            this.pnlAskQuestion.TabIndex = 6;
            this.pnlAskQuestion.Visible = false;
            // 
            // lblQuestionTeacher
            // 
            this.lblQuestionTeacher.AutoSize = true;
            this.lblQuestionTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTeacher.ForeColor = System.Drawing.Color.Orange;
            this.lblQuestionTeacher.Location = new System.Drawing.Point(794, 82);
            this.lblQuestionTeacher.Name = "lblQuestionTeacher";
            this.lblQuestionTeacher.Size = new System.Drawing.Size(123, 40);
            this.lblQuestionTeacher.TabIndex = 13;
            this.lblQuestionTeacher.Text = "Auteur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 446);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 33);
            this.label14.TabIndex = 12;
            this.label14.Text = "Vraag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 33);
            this.label10.TabIndex = 11;
            this.label10.Text = "Beschrijving";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 95);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 33);
            this.label13.TabIndex = 10;
            this.label13.Text = "Titel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(801, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txbQuestion
            // 
            this.txbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestion.Location = new System.Drawing.Point(60, 488);
            this.txbQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbQuestion.Multiline = true;
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.Size = new System.Drawing.Size(1036, 416);
            this.txbQuestion.TabIndex = 4;
            // 
            // txbQuestionDescription
            // 
            this.txbQuestionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestionDescription.Location = new System.Drawing.Point(62, 245);
            this.txbQuestionDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbQuestionDescription.Multiline = true;
            this.txbQuestionDescription.Name = "txbQuestionDescription";
            this.txbQuestionDescription.Size = new System.Drawing.Size(706, 167);
            this.txbQuestionDescription.TabIndex = 3;
            // 
            // txbQuestionTitle
            // 
            this.txbQuestionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuestionTitle.Location = new System.Drawing.Point(60, 137);
            this.txbQuestionTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbQuestionTitle.Name = "txbQuestionTitle";
            this.txbQuestionTitle.Size = new System.Drawing.Size(706, 40);
            this.txbQuestionTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
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
            this.pnlFeedforward.Location = new System.Drawing.Point(14, 131);
            this.pnlFeedforward.Name = "pnlFeedforward";
            this.pnlFeedforward.Size = new System.Drawing.Size(2109, 1143);
            this.pnlFeedforward.TabIndex = 5;
            this.pnlFeedforward.Visible = false;
            // 
            // dgvFeedback2
            // 
            this.dgvFeedback2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedforwardFeedbackID,
            this.clnFeedforwardFeedbackFeedback});
            this.dgvFeedback2.Location = new System.Drawing.Point(516, 66);
            this.dgvFeedback2.Name = "dgvFeedback2";
            this.dgvFeedback2.RowHeadersVisible = false;
            this.dgvFeedback2.RowHeadersWidth = 51;
            this.dgvFeedback2.RowTemplate.Height = 24;
            this.dgvFeedback2.Size = new System.Drawing.Size(270, 263);
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
            this.lblFeedback2.Location = new System.Drawing.Point(510, 17);
            this.lblFeedback2.Name = "lblFeedback2";
            this.lblFeedback2.Size = new System.Drawing.Size(175, 40);
            this.lblFeedback2.TabIndex = 4;
            this.lblFeedback2.Text = "Feedback";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFeedforwardConclusionID,
            this.clnFeedforwardConclusionConclusion});
            this.dataGridView1.Location = new System.Drawing.Point(1065, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(270, 263);
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
            this.dgvLearnGoals2.Location = new System.Drawing.Point(44, 66);
            this.dgvLearnGoals2.Name = "dgvLearnGoals2";
            this.dgvLearnGoals2.RowHeadersVisible = false;
            this.dgvLearnGoals2.RowHeadersWidth = 51;
            this.dgvLearnGoals2.RowTemplate.Height = 24;
            this.dgvLearnGoals2.Size = new System.Drawing.Size(270, 263);
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
            this.lblConclusion.Location = new System.Drawing.Point(1058, 17);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(175, 40);
            this.lblConclusion.TabIndex = 1;
            this.lblConclusion.Text = "Conclusie";
            // 
            // lblLearnGoals2
            // 
            this.lblLearnGoals2.AutoSize = true;
            this.lblLearnGoals2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals2.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals2.Location = new System.Drawing.Point(38, 17);
            this.lblLearnGoals2.Name = "lblLearnGoals2";
            this.lblLearnGoals2.Size = new System.Drawing.Size(197, 40);
            this.lblLearnGoals2.TabIndex = 0;
            this.lblLearnGoals2.Text = "Leerdoelen";
            // 
            // pnlConclusion
            // 
            this.pnlConclusion.Controls.Add(this.dataGridView3);
            this.pnlConclusion.Controls.Add(this.label2);
            this.pnlConclusion.Location = new System.Drawing.Point(14, 131);
            this.pnlConclusion.Name = "pnlConclusion";
            this.pnlConclusion.Size = new System.Drawing.Size(2109, 1143);
            this.pnlConclusion.TabIndex = 5;
            this.pnlConclusion.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnConclusionConclusionID,
            this.clnConclusionConclusionConclusion});
            this.dataGridView3.Location = new System.Drawing.Point(44, 105);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(2018, 926);
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
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 40);
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
            this.txbSubject.Size = new System.Drawing.Size(161, 35);
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
            this.pnlHome.Location = new System.Drawing.Point(14, 131);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(2121, 1143);
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
            this.dgvSubjects.Location = new System.Drawing.Point(1360, 69);
            this.dgvSubjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowHeadersWidth = 62;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(388, 609);
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
            this.lblNewSubject_.Location = new System.Drawing.Point(20, 69);
            this.lblNewSubject_.Name = "lblNewSubject_";
            this.lblNewSubject_.Size = new System.Drawing.Size(154, 33);
            this.lblNewSubject_.TabIndex = 6;
            this.lblNewSubject_.Text = "Nieuw Vak";
            // 
            // txbAddSubject
            // 
            this.txbAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddSubject.Location = new System.Drawing.Point(27, 112);
            this.txbAddSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAddSubject.Name = "txbAddSubject";
            this.txbAddSubject.Size = new System.Drawing.Size(240, 35);
            this.txbAddSubject.TabIndex = 5;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(278, 112);
            this.btnAddSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(112, 40);
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
            this.lblManageSubjects.Location = new System.Drawing.Point(1353, 17);
            this.lblManageSubjects.Name = "lblManageSubjects";
            this.lblManageSubjects.Size = new System.Drawing.Size(263, 40);
            this.lblManageSubjects.TabIndex = 2;
            this.lblManageSubjects.Text = "Beheer Vakken";
            // 
            // lblHome_
            // 
            this.lblHome_.AutoSize = true;
            this.lblHome_.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHome_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome_.ForeColor = System.Drawing.Color.Orange;
            this.lblHome_.Location = new System.Drawing.Point(20, 17);
            this.lblHome_.Name = "lblHome_";
            this.lblHome_.Size = new System.Drawing.Size(113, 40);
            this.lblHome_.TabIndex = 1;
            this.lblHome_.Text = "Home";
            // 
            // pnlUpdateLearngoal
            // 
            this.pnlUpdateLearngoal.Controls.Add(this.btnBackLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.btnDeleteLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.btnSaveLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.tbxSelectedLearngoal);
            this.pnlUpdateLearngoal.Controls.Add(this.lblUpdateLearngoal);
            this.pnlUpdateLearngoal.Location = new System.Drawing.Point(7, 78);
            this.pnlUpdateLearngoal.Name = "pnlUpdateLearngoal";
            this.pnlUpdateLearngoal.Size = new System.Drawing.Size(872, 212);
            this.pnlUpdateLearngoal.TabIndex = 13;
            this.pnlUpdateLearngoal.Visible = false;
            // 
            // lblUpdateLearngoal
            // 
            this.lblUpdateLearngoal.AutoSize = true;
            this.lblUpdateLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateLearngoal.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateLearngoal.Location = new System.Drawing.Point(5, 14);
            this.lblUpdateLearngoal.Name = "lblUpdateLearngoal";
            this.lblUpdateLearngoal.Size = new System.Drawing.Size(242, 33);
            this.lblUpdateLearngoal.TabIndex = 9;
            this.lblUpdateLearngoal.Text = "Leerdoel beheren";
            // 
            // tbxSelectedLearngoal
            // 
            this.tbxSelectedLearngoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSelectedLearngoal.Location = new System.Drawing.Point(9, 64);
            this.tbxSelectedLearngoal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxSelectedLearngoal.Name = "tbxSelectedLearngoal";
            this.tbxSelectedLearngoal.Size = new System.Drawing.Size(839, 40);
            this.tbxSelectedLearngoal.TabIndex = 10;
            // 
            // btnSaveLearngoal
            // 
            this.btnSaveLearngoal.BackColor = System.Drawing.Color.Orange;
            this.btnSaveLearngoal.Location = new System.Drawing.Point(9, 127);
            this.btnSaveLearngoal.Name = "btnSaveLearngoal";
            this.btnSaveLearngoal.Size = new System.Drawing.Size(213, 69);
            this.btnSaveLearngoal.TabIndex = 11;
            this.btnSaveLearngoal.Text = "Opslaan";
            this.btnSaveLearngoal.UseVisualStyleBackColor = false;
            // 
            // btnDeleteLearngoal
            // 
            this.btnDeleteLearngoal.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteLearngoal.Location = new System.Drawing.Point(228, 127);
            this.btnDeleteLearngoal.Name = "btnDeleteLearngoal";
            this.btnDeleteLearngoal.Size = new System.Drawing.Size(213, 69);
            this.btnDeleteLearngoal.TabIndex = 12;
            this.btnDeleteLearngoal.Text = "Verwijderen";
            this.btnDeleteLearngoal.UseVisualStyleBackColor = false;
            // 
            // btnBackLearngoal
            // 
            this.btnBackLearngoal.BackColor = System.Drawing.SystemColors.Control;
            this.btnBackLearngoal.Location = new System.Drawing.Point(635, 127);
            this.btnBackLearngoal.Name = "btnBackLearngoal";
            this.btnBackLearngoal.Size = new System.Drawing.Size(213, 69);
            this.btnBackLearngoal.TabIndex = 13;
            this.btnBackLearngoal.Text = "Terug";
            this.btnBackLearngoal.UseVisualStyleBackColor = false;
            this.btnBackLearngoal.Click += new System.EventHandler(this.btnBackLearngoal_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2182, 1291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlFeedup);
            this.Controls.Add(this.pnlConclusion);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.pnlFeedforward);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivity.PerformLayout();
            this.pnlTimeSpent.ResumeLayout(false);
            this.pnlTimeSpent.PerformLayout();
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
            this.pnlUpdateLearngoal.ResumeLayout(false);
            this.pnlUpdateLearngoal.PerformLayout();
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
        private Label label9;
        private Label label8;
        private TextBox txbFeedup_TimeEstimation;
        private TextBox txbFeedup_Activitity;
        private Label label3;
        private Button btnAddActivity;
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
        private TextBox tbxSelectedLearngoal;
        private Label lblUpdateLearngoal;
    }
}