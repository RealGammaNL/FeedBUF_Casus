using System.Windows.Forms;

namespace FeedBUF_Casus.Forms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cbxWeek = new System.Windows.Forms.ComboBox();
            this.cbxPanelSwitch = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlFeedup = new System.Windows.Forms.Panel();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLearnGoal = new System.Windows.Forms.DataGridView();
            this.LearnGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblLearnGoal = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnAddFeedback = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxTitel = new System.Windows.Forms.TextBox();
            this.lblFeedbackDescription = new System.Windows.Forms.Label();
            this.lblFeedbackTitle = new System.Windows.Forms.Label();
            this.lblLearnGoalAndAssignments = new System.Windows.Forms.Label();
            this.cbxSelectedGoal = new System.Windows.Forms.ComboBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCall = new System.Windows.Forms.Label();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.pnlConclusie = new System.Windows.Forms.Panel();
            this.dgvConclusion = new System.Windows.Forms.DataGridView();
            this.MainGroup.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoal)).BeginInit();
            this.pnlFeedback.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlConclusie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConclusion)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.BackColor = System.Drawing.Color.Orange;
            this.MainGroup.Controls.Add(this.btnExit);
            this.MainGroup.Controls.Add(this.lblName);
            this.MainGroup.Controls.Add(this.cmbStudent);
            this.MainGroup.Controls.Add(this.cbxWeek);
            this.MainGroup.Controls.Add(this.cbxPanelSwitch);
            this.MainGroup.Controls.Add(this.btnHome);
            this.MainGroup.Location = new System.Drawing.Point(-2, -23);
            this.MainGroup.Margin = new System.Windows.Forms.Padding(2);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(2);
            this.MainGroup.Size = new System.Drawing.Size(1565, 87);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Orange;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1487, 25);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 58);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1301, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "TeacherName";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(511, 33);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(298, 37);
            this.cmbStudent.TabIndex = 4;
            // 
            // cbxWeek
            // 
            this.cbxWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWeek.FormattingEnabled = true;
            this.cbxWeek.Location = new System.Drawing.Point(288, 34);
            this.cbxWeek.Margin = new System.Windows.Forms.Padding(2);
            this.cbxWeek.Name = "cbxWeek";
            this.cbxWeek.Size = new System.Drawing.Size(219, 37);
            this.cbxWeek.TabIndex = 3;
            // 
            // cbxPanelSwitch
            // 
            this.cbxPanelSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPanelSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPanelSwitch.FormattingEnabled = true;
            this.cbxPanelSwitch.Items.AddRange(new object[] {
            "Feedup",
            "Feedback",
            "Conclusie"});
            this.cbxPanelSwitch.Location = new System.Drawing.Point(65, 34);
            this.cbxPanelSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPanelSwitch.Name = "cbxPanelSwitch";
            this.cbxPanelSwitch.Size = new System.Drawing.Size(219, 37);
            this.cbxPanelSwitch.TabIndex = 2;
            this.cbxPanelSwitch.SelectedValueChanged += new System.EventHandler(this.Switchpanel);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(5, 23);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(55, 58);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlFeedup
            // 
            this.pnlFeedup.Controls.Add(this.dgvActivity);
            this.pnlFeedup.Controls.Add(this.dgvLearnGoal);
            this.pnlFeedup.Controls.Add(this.lblActivity);
            this.pnlFeedup.Controls.Add(this.lblLearnGoal);
            this.pnlFeedup.Location = new System.Drawing.Point(3, 75);
            this.pnlFeedup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(1533, 761);
            this.pnlFeedup.TabIndex = 1;
            this.pnlFeedup.Visible = false;
            // 
            // dgvActivity
            // 
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activity});
            this.dgvActivity.Location = new System.Drawing.Point(771, 43);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.RowHeadersVisible = false;
            this.dgvActivity.RowHeadersWidth = 62;
            this.dgvActivity.RowTemplate.Height = 28;
            this.dgvActivity.Size = new System.Drawing.Size(604, 614);
            this.dgvActivity.TabIndex = 5;
            // 
            // Activity
            // 
            this.Activity.HeaderText = "";
            this.Activity.MinimumWidth = 8;
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            // 
            // dgvLearnGoal
            // 
            this.dgvLearnGoal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLearnGoal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnGoal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LearnGoal});
            this.dgvLearnGoal.Location = new System.Drawing.Point(8, 43);
            this.dgvLearnGoal.Name = "dgvLearnGoal";
            this.dgvLearnGoal.RowHeadersVisible = false;
            this.dgvLearnGoal.RowHeadersWidth = 62;
            this.dgvLearnGoal.RowTemplate.Height = 28;
            this.dgvLearnGoal.Size = new System.Drawing.Size(604, 614);
            this.dgvLearnGoal.TabIndex = 4;
            // 
            // LearnGoal
            // 
            this.LearnGoal.HeaderText = "";
            this.LearnGoal.MinimumWidth = 8;
            this.LearnGoal.Name = "LearnGoal";
            this.LearnGoal.ReadOnly = true;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.ForeColor = System.Drawing.Color.Orange;
            this.lblActivity.Location = new System.Drawing.Point(764, 0);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(203, 40);
            this.lblActivity.TabIndex = 2;
            this.lblActivity.Text = "Activiteiten";
            // 
            // lblLearnGoal
            // 
            this.lblLearnGoal.AutoSize = true;
            this.lblLearnGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoal.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoal.Location = new System.Drawing.Point(2, 0);
            this.lblLearnGoal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLearnGoal.Name = "lblLearnGoal";
            this.lblLearnGoal.Size = new System.Drawing.Size(207, 40);
            this.lblLearnGoal.TabIndex = 1;
            this.lblLearnGoal.Text = "Leerdoelen";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnAddFeedback);
            this.pnlFeedback.Controls.Add(this.tbxDescription);
            this.pnlFeedback.Controls.Add(this.tbxTitel);
            this.pnlFeedback.Controls.Add(this.lblFeedbackDescription);
            this.pnlFeedback.Controls.Add(this.lblFeedbackTitle);
            this.pnlFeedback.Controls.Add(this.lblLearnGoalAndAssignments);
            this.pnlFeedback.Controls.Add(this.cbxSelectedGoal);
            this.pnlFeedback.Location = new System.Drawing.Point(3, 75);
            this.pnlFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(1533, 761);
            this.pnlFeedback.TabIndex = 3;
            this.pnlFeedback.Visible = false;
            // 
            // btnAddFeedback
            // 
            this.btnAddFeedback.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFeedback.Location = new System.Drawing.Point(1301, 657);
            this.btnAddFeedback.Name = "btnAddFeedback";
            this.btnAddFeedback.Size = new System.Drawing.Size(213, 89);
            this.btnAddFeedback.TabIndex = 6;
            this.btnAddFeedback.Text = "Feedback toevoegen";
            this.btnAddFeedback.UseVisualStyleBackColor = false;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.Location = new System.Drawing.Point(9, 299);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(1286, 447);
            this.tbxDescription.TabIndex = 5;
            // 
            // tbxTitel
            // 
            this.tbxTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitel.Location = new System.Drawing.Point(9, 203);
            this.tbxTitel.Multiline = true;
            this.tbxTitel.Name = "tbxTitel";
            this.tbxTitel.Size = new System.Drawing.Size(1286, 61);
            this.tbxTitel.TabIndex = 4;
            // 
            // lblFeedbackDescription
            // 
            this.lblFeedbackDescription.AutoSize = true;
            this.lblFeedbackDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackDescription.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedbackDescription.Location = new System.Drawing.Point(3, 267);
            this.lblFeedbackDescription.Name = "lblFeedbackDescription";
            this.lblFeedbackDescription.Size = new System.Drawing.Size(144, 29);
            this.lblFeedbackDescription.TabIndex = 3;
            this.lblFeedbackDescription.Text = "Beschrijving";
            // 
            // lblFeedbackTitle
            // 
            this.lblFeedbackTitle.AutoSize = true;
            this.lblFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedbackTitle.Location = new System.Drawing.Point(3, 171);
            this.lblFeedbackTitle.Name = "lblFeedbackTitle";
            this.lblFeedbackTitle.Size = new System.Drawing.Size(69, 32);
            this.lblFeedbackTitle.TabIndex = 2;
            this.lblFeedbackTitle.Text = "Titel";
            // 
            // lblLearnGoalAndAssignments
            // 
            this.lblLearnGoalAndAssignments.AutoSize = true;
            this.lblLearnGoalAndAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoalAndAssignments.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoalAndAssignments.Location = new System.Drawing.Point(4, 11);
            this.lblLearnGoalAndAssignments.Name = "lblLearnGoalAndAssignments";
            this.lblLearnGoalAndAssignments.Size = new System.Drawing.Size(308, 29);
            this.lblLearnGoalAndAssignments.TabIndex = 1;
            this.lblLearnGoalAndAssignments.Text = "Leerdoelen en inleveringen";
            // 
            // cbxSelectedGoal
            // 
            this.cbxSelectedGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectedGoal.FormattingEnabled = true;
            this.cbxSelectedGoal.Location = new System.Drawing.Point(9, 43);
            this.cbxSelectedGoal.Name = "cbxSelectedGoal";
            this.cbxSelectedGoal.Size = new System.Drawing.Size(1286, 28);
            this.cbxSelectedGoal.TabIndex = 0;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblSubject);
            this.pnlHome.Controls.Add(this.lblCall);
            this.pnlHome.Controls.Add(this.cbxSubject);
            this.pnlHome.Controls.Add(this.cbxClass);
            this.pnlHome.Location = new System.Drawing.Point(3, 75);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1533, 761);
            this.pnlHome.TabIndex = 4;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Orange;
            this.lblSubject.Location = new System.Drawing.Point(765, 255);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 32);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Vak";
            // 
            // lblCall
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.BackColor = System.Drawing.SystemColors.Control;
            this.lblCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCall.ForeColor = System.Drawing.Color.Orange;
            this.lblCall.Location = new System.Drawing.Point(537, 255);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(70, 32);
            this.lblCall.TabIndex = 6;
            this.lblCall.Text = "Klas";
            // 
            // cbxSubject
            // 
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(771, 299);
            this.cbxSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(181, 37);
            this.cbxSubject.TabIndex = 5;
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(543, 299);
            this.cbxClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(219, 37);
            this.cbxClass.TabIndex = 3;
            // 
            // pnlConclusie
            // 
            this.pnlConclusie.Controls.Add(this.dgvConclusion);
            this.pnlConclusie.Location = new System.Drawing.Point(3, 75);
            this.pnlConclusie.Name = "pnlConclusie";
            this.pnlConclusie.Size = new System.Drawing.Size(1533, 761);
            this.pnlConclusie.TabIndex = 5;
            this.pnlConclusie.Visible = false;
            // 
            // dgvConclusion
            // 
            this.dgvConclusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConclusion.Location = new System.Drawing.Point(9, 19);
            this.dgvConclusion.Name = "dgvConclusion";
            this.dgvConclusion.RowHeadersWidth = 62;
            this.dgvConclusion.RowTemplate.Height = 28;
            this.dgvConclusion.Size = new System.Drawing.Size(1455, 727);
            this.dgvConclusion.TabIndex = 0;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1551, 847);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.pnlFeedup);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlConclusie);
            this.Controls.Add(this.pnlFeedback);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1575, 909);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeedBuff";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.pnlFeedup.ResumeLayout(false);
            this.pnlFeedup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoal)).EndInit();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlConclusie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConclusion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button btnHome;
        private ComboBox cbxPanelSwitch;
        private ComboBox cmbStudent;
        private ComboBox cbxWeek;
        private Label lblName;
        private Panel pnlFeedup;
        private Label lblActivity;
        private Label lblLearnGoal;
        private Panel pnlFeedback;
        private Label lblLearnGoalAndAssignments;
        private ComboBox cbxSelectedGoal;
        private TextBox tbxDescription;
        private TextBox tbxTitel;
        private Label lblFeedbackDescription;
        private Label lblFeedbackTitle;
        private Button btnAddFeedback;
        private Panel pnlHome;
        private Label lblSubject;
        private Label lblCall;
        private ComboBox cbxSubject;
        private ComboBox cbxClass;
        private Panel pnlConclusie;
        private DataGridView dgvConclusion;
        private Button btnExit;
        private DataGridView dgvLearnGoal;
        private DataGridView dgvActivity;
        private DataGridViewTextBoxColumn LearnGoal;
        private DataGridViewTextBoxColumn Activity;
    }
}