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
            this.lblName = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cbxWeek = new System.Windows.Forms.ComboBox();
            this.cbxPanelSwitch = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlFeedup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnAddFeedback = new System.Windows.Forms.Button();
            this.tbxDescreption = new System.Windows.Forms.TextBox();
            this.tbxTitel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSelectedGoal = new System.Windows.Forms.ComboBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlConclusie = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvLearnGoal = new System.Windows.Forms.DataGridView();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.LearnGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainGroup.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlConclusie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
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
            this.pnlFeedup.Controls.Add(this.label2);
            this.pnlFeedup.Controls.Add(this.label1);
            this.pnlFeedup.Location = new System.Drawing.Point(3, 75);
            this.pnlFeedup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(1533, 761);
            this.pnlFeedup.TabIndex = 1;
            this.pnlFeedup.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(764, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activiteiten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leerdoelen";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnAddFeedback);
            this.pnlFeedback.Controls.Add(this.tbxDescreption);
            this.pnlFeedback.Controls.Add(this.tbxTitel);
            this.pnlFeedback.Controls.Add(this.label5);
            this.pnlFeedback.Controls.Add(this.label4);
            this.pnlFeedback.Controls.Add(this.label3);
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
            // tbxDescreption
            // 
            this.tbxDescreption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescreption.Location = new System.Drawing.Point(9, 299);
            this.tbxDescreption.Multiline = true;
            this.tbxDescreption.Name = "tbxDescreption";
            this.tbxDescreption.Size = new System.Drawing.Size(1286, 447);
            this.tbxDescreption.TabIndex = 5;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(3, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Beschrijving";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Leerdoelen en inleveringen";
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
            this.pnlHome.Controls.Add(this.label7);
            this.pnlHome.Controls.Add(this.label6);
            this.pnlHome.Controls.Add(this.comboBox2);
            this.pnlHome.Controls.Add(this.comboBox1);
            this.pnlHome.Location = new System.Drawing.Point(3, 75);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1533, 761);
            this.pnlHome.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(765, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(537, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Klas";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(771, 299);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 37);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 299);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // pnlConclusie
            // 
            this.pnlConclusie.Controls.Add(this.dataGridView1);
            this.pnlConclusie.Location = new System.Drawing.Point(3, 75);
            this.pnlConclusie.Name = "pnlConclusie";
            this.pnlConclusie.Size = new System.Drawing.Size(1533, 761);
            this.pnlConclusie.TabIndex = 5;
            this.pnlConclusie.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1455, 727);
            this.dataGridView1.TabIndex = 0;
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
            // LearnGoal
            // 
            this.LearnGoal.HeaderText = "";
            this.LearnGoal.MinimumWidth = 8;
            this.LearnGoal.Name = "LearnGoal";
            this.LearnGoal.ReadOnly = true;
            // 
            // Activity
            // 
            this.Activity.HeaderText = "";
            this.Activity.MinimumWidth = 8;
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
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
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlConclusie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearnGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
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
        private Label label2;
        private Label label1;
        private Panel pnlFeedback;
        private Label label3;
        private ComboBox cbxSelectedGoal;
        private TextBox tbxDescreption;
        private TextBox tbxTitel;
        private Label label5;
        private Label label4;
        private Button btnAddFeedback;
        private Panel pnlHome;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel pnlConclusie;
        private DataGridView dataGridView1;
        private Button btnExit;
        private DataGridView dgvLearnGoal;
        private DataGridView dgvActivity;
        private DataGridViewTextBoxColumn LearnGoal;
        private DataGridViewTextBoxColumn Activity;
    }
}