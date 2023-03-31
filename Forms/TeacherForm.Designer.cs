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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainGroup.SuspendLayout();
            this.pnlFeedup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.BackColor = System.Drawing.Color.Orange;
            this.MainGroup.Controls.Add(this.lblName);
            this.MainGroup.Controls.Add(this.cmbStudent);
            this.MainGroup.Controls.Add(this.cbxWeek);
            this.MainGroup.Controls.Add(this.cbxPanelSwitch);
            this.MainGroup.Controls.Add(this.btnHome);
            this.MainGroup.Location = new System.Drawing.Point(-3, -28);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(1913, 104);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1694, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(193, 32);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "TeacherName";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(625, 40);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(363, 40);
            this.cmbStudent.TabIndex = 4;
            // 
            // cbxWeek
            // 
            this.cbxWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWeek.FormattingEnabled = true;
            this.cbxWeek.Location = new System.Drawing.Point(352, 41);
            this.cbxWeek.Name = "cbxWeek";
            this.cbxWeek.Size = new System.Drawing.Size(267, 40);
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
            this.cbxPanelSwitch.Location = new System.Drawing.Point(79, 41);
            this.cbxPanelSwitch.Name = "cbxPanelSwitch";
            this.cbxPanelSwitch.Size = new System.Drawing.Size(267, 40);
            this.cbxPanelSwitch.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Orange;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(6, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(67, 70);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlFeedup
            // 
            this.pnlFeedup.Controls.Add(this.panel1);
            this.pnlFeedup.Controls.Add(this.label2);
            this.pnlFeedup.Controls.Add(this.label1);
            this.pnlFeedup.Location = new System.Drawing.Point(13, 93);
            this.pnlFeedup.Name = "pnlFeedup";
            this.pnlFeedup.Size = new System.Drawing.Size(1874, 913);
            this.pnlFeedup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leerdoelen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(934, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activiteiten";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1874, 913);
            this.panel1.TabIndex = 3;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.pnlFeedup);
            this.Controls.Add(this.MainGroup);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.pnlFeedup.ResumeLayout(false);
            this.pnlFeedup.PerformLayout();
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
        private Panel panel1;
    }
}