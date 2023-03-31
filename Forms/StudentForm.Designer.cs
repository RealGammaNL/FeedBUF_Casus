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
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cbxPanelSwitch = new System.Windows.Forms.ComboBox();
            this.pnlFeedup = new System.Windows.Forms.Panel();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.lblAskQuestion = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.dgvLearnGoals = new System.Windows.Forms.DataGridView();
            this.lblActivities = new System.Windows.Forms.Label();
            this.lblLearnGoals = new System.Windows.Forms.Label();
            this.pnlFeedforward = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvLearnGoals2 = new System.Windows.Forms.DataGridView();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblLearnGoals2 = new System.Windows.Forms.Label();
            this.lblFeedback2 = new System.Windows.Forms.Label();
            this.dgvFeedback2 = new System.Windows.Forms.DataGridView();
            this.dgvAskQuestion = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals)).BeginInit();
            this.pnlFeedforward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAskQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(17, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 70);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.lblStudentClass);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.cbxPanelSwitch);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Location = new System.Drawing.Point(-5, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1945, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(861, 58);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(33, 16);
            this.lblStudentClass.TabIndex = 5;
            this.lblStudentClass.Text = "Klas";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Introduction to Development",
            "Datastructure Basics",
            "Project Management"});
            this.comboBox2.Location = new System.Drawing.Point(423, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(303, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Week 1 ",
            "Week 2 ",
            "Week 3 "});
            this.comboBox1.Location = new System.Drawing.Point(283, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(861, 41);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(86, 16);
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
            "Conclusie"});
            this.cbxPanelSwitch.Location = new System.Drawing.Point(108, 41);
            this.cbxPanelSwitch.Name = "cbxPanelSwitch";
            this.cbxPanelSwitch.Size = new System.Drawing.Size(158, 33);
            this.cbxPanelSwitch.TabIndex = 1;
            // 
            // pnlFeedup
            // 
            this.pnlFeedup.Controls.Add(this.pnlFeedback);
            this.pnlFeedup.Controls.Add(this.dgvActivities);
            this.pnlFeedup.Controls.Add(this.dgvLearnGoals);
            this.pnlFeedup.Controls.Add(this.lblActivities);
            this.pnlFeedup.Controls.Add(this.lblLearnGoals);
            this.pnlFeedup.Location = new System.Drawing.Point(12, 105);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(1448, 505);
            this.pnlFeedup.TabIndex = 3;
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.pnlFeedforward);
            this.pnlFeedback.Controls.Add(this.dgvAskQuestion);
            this.pnlFeedback.Controls.Add(this.dgvFeedback);
            this.pnlFeedback.Controls.Add(this.lblAskQuestion);
            this.pnlFeedback.Controls.Add(this.lblFeedback);
            this.pnlFeedback.Location = new System.Drawing.Point(0, 0);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(1448, 505);
            this.pnlFeedback.TabIndex = 4;
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(39, 84);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.RowTemplate.Height = 24;
            this.dgvFeedback.Size = new System.Drawing.Size(240, 210);
            this.dgvFeedback.TabIndex = 2;
            // 
            // lblAskQuestion
            // 
            this.lblAskQuestion.AutoSize = true;
            this.lblAskQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskQuestion.ForeColor = System.Drawing.Color.Orange;
            this.lblAskQuestion.Location = new System.Drawing.Point(606, 14);
            this.lblAskQuestion.Name = "lblAskQuestion";
            this.lblAskQuestion.Size = new System.Drawing.Size(194, 36);
            this.lblAskQuestion.TabIndex = 1;
            this.lblAskQuestion.Text = "Vraag Stellen";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedback.Location = new System.Drawing.Point(33, 14);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(145, 36);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Feedback";
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(612, 84);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.RowHeadersWidth = 51;
            this.dgvActivities.RowTemplate.Height = 24;
            this.dgvActivities.Size = new System.Drawing.Size(240, 150);
            this.dgvActivities.TabIndex = 3;
            // 
            // dgvLearnGoals
            // 
            this.dgvLearnGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnGoals.Location = new System.Drawing.Point(39, 84);
            this.dgvLearnGoals.Name = "dgvLearnGoals";
            this.dgvLearnGoals.RowHeadersWidth = 51;
            this.dgvLearnGoals.RowTemplate.Height = 24;
            this.dgvLearnGoals.Size = new System.Drawing.Size(240, 150);
            this.dgvLearnGoals.TabIndex = 2;
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.ForeColor = System.Drawing.Color.Orange;
            this.lblActivities.Location = new System.Drawing.Point(606, 14);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(160, 36);
            this.lblActivities.TabIndex = 1;
            this.lblActivities.Text = "Activiteiten";
            // 
            // lblLearnGoals
            // 
            this.lblLearnGoals.AutoSize = true;
            this.lblLearnGoals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals.Location = new System.Drawing.Point(33, 14);
            this.lblLearnGoals.Name = "lblLearnGoals";
            this.lblLearnGoals.Size = new System.Drawing.Size(164, 36);
            this.lblLearnGoals.TabIndex = 0;
            this.lblLearnGoals.Text = "Leerdoelen";
            // 
            // pnlFeedforward
            // 
            this.pnlFeedforward.Controls.Add(this.dgvFeedback2);
            this.pnlFeedforward.Controls.Add(this.lblFeedback2);
            this.pnlFeedforward.Controls.Add(this.dataGridView1);
            this.pnlFeedforward.Controls.Add(this.dgvLearnGoals2);
            this.pnlFeedforward.Controls.Add(this.lblConclusion);
            this.pnlFeedforward.Controls.Add(this.lblLearnGoals2);
            this.pnlFeedforward.Location = new System.Drawing.Point(0, 0);
            this.pnlFeedforward.Name = "pnlFeedforward";
            this.pnlFeedforward.Size = new System.Drawing.Size(1448, 505);
            this.pnlFeedforward.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(946, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 181);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvLearnGoals2
            // 
            this.dgvLearnGoals2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearnGoals2.Location = new System.Drawing.Point(39, 53);
            this.dgvLearnGoals2.Name = "dgvLearnGoals2";
            this.dgvLearnGoals2.RowHeadersWidth = 51;
            this.dgvLearnGoals2.RowTemplate.Height = 24;
            this.dgvLearnGoals2.Size = new System.Drawing.Size(240, 210);
            this.dgvLearnGoals2.TabIndex = 2;
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.ForeColor = System.Drawing.Color.Orange;
            this.lblConclusion.Location = new System.Drawing.Point(940, 14);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(147, 36);
            this.lblConclusion.TabIndex = 1;
            this.lblConclusion.Text = "Conclusie";
            // 
            // lblLearnGoals2
            // 
            this.lblLearnGoals2.AutoSize = true;
            this.lblLearnGoals2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLearnGoals2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnGoals2.ForeColor = System.Drawing.Color.Orange;
            this.lblLearnGoals2.Location = new System.Drawing.Point(33, 14);
            this.lblLearnGoals2.Name = "lblLearnGoals2";
            this.lblLearnGoals2.Size = new System.Drawing.Size(164, 36);
            this.lblLearnGoals2.TabIndex = 0;
            this.lblLearnGoals2.Text = "Leerdoelen";
            // 
            // lblFeedback2
            // 
            this.lblFeedback2.AutoSize = true;
            this.lblFeedback2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback2.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedback2.Location = new System.Drawing.Point(453, 14);
            this.lblFeedback2.Name = "lblFeedback2";
            this.lblFeedback2.Size = new System.Drawing.Size(147, 36);
            this.lblFeedback2.TabIndex = 4;
            this.lblFeedback2.Text = "Conclusie";
            // 
            // dgvFeedback2
            // 
            this.dgvFeedback2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback2.Location = new System.Drawing.Point(459, 53);
            this.dgvFeedback2.Name = "dgvFeedback2";
            this.dgvFeedback2.RowHeadersWidth = 51;
            this.dgvFeedback2.RowTemplate.Height = 24;
            this.dgvFeedback2.Size = new System.Drawing.Size(240, 210);
            this.dgvFeedback2.TabIndex = 5;
            // 
            // dgvAskQuestion
            // 
            this.dgvAskQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAskQuestion.Location = new System.Drawing.Point(612, 84);
            this.dgvAskQuestion.Name = "dgvAskQuestion";
            this.dgvAskQuestion.RowHeadersWidth = 51;
            this.dgvAskQuestion.RowTemplate.Height = 24;
            this.dgvAskQuestion.Size = new System.Drawing.Size(240, 150);
            this.dgvAskQuestion.TabIndex = 3;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlFeedup);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFeedup.ResumeLayout(false);
            this.pnlFeedup.PerformLayout();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals)).EndInit();
            this.pnlFeedforward.ResumeLayout(false);
            this.pnlFeedforward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoals2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAskQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComboBox cbxPanelSwitch;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblStudentClass;
        private Label lblStudentName;
        private Panel pnlFeedup;
        private Label lblLearnGoals;
        private Label lblActivities;
        private Panel pnlFeedback;
        private DataGridView dgvFeedback;
        private Label lblAskQuestion;
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
        private DataGridView dgvAskQuestion;
    }
}