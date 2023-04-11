namespace FeedBUF_Casus.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.btnCreateAccountPanel = new System.Windows.Forms.Button();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblFeedBuff = new System.Windows.Forms.Label();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.LoginPassword_Label = new System.Windows.Forms.Label();
            this.LoginPassword_Box = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.LoginEmail_Label = new System.Windows.Forms.Label();
            this.LoginEmail_Box = new System.Windows.Forms.TextBox();
            this.pnlCreateAccount = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txbStudentNumber = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txbGroup = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPasswordHelp = new System.Windows.Forms.Button();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txbNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lblFeedBUF = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbNewEmail = new System.Windows.Forms.TextBox();
            this.ttpShowPasswordRequirements = new System.Windows.Forms.ToolTip(this.components);
            this.LoginPanel.SuspendLayout();
            this.pnlCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPanel.Controls.Add(this.btnCreateAccountPanel);
            this.LoginPanel.Controls.Add(this.lblCreateAccount);
            this.LoginPanel.Controls.Add(this.lblForgotPassword);
            this.LoginPanel.Controls.Add(this.lblFeedBuff);
            this.LoginPanel.Controls.Add(this.IncorrectLabel);
            this.LoginPanel.Controls.Add(this.SignInButton);
            this.LoginPanel.Controls.Add(this.LoginPassword_Label);
            this.LoginPanel.Controls.Add(this.LoginPassword_Box);
            this.LoginPanel.Controls.Add(this.Loginlabel);
            this.LoginPanel.Controls.Add(this.LoginEmail_Label);
            this.LoginPanel.Controls.Add(this.LoginEmail_Box);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(2859, 1606);
            this.LoginPanel.TabIndex = 42;
            // 
            // btnCreateAccountPanel
            // 
            this.btnCreateAccountPanel.BackColor = System.Drawing.Color.Orange;
            this.btnCreateAccountPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccountPanel.Location = new System.Drawing.Point(1104, 1146);
            this.btnCreateAccountPanel.Name = "btnCreateAccountPanel";
            this.btnCreateAccountPanel.Size = new System.Drawing.Size(224, 60);
            this.btnCreateAccountPanel.TabIndex = 44;
            this.btnCreateAccountPanel.Text = "Account aanmaken";
            this.btnCreateAccountPanel.UseVisualStyleBackColor = false;
            this.btnCreateAccountPanel.Click += new System.EventHandler(this.btnCreateAccountPanel_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.Location = new System.Drawing.Point(1097, 1086);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(692, 37);
            this.lblCreateAccount.TabIndex = 43;
            this.lblCreateAccount.Text = "Heb je nog geen account? maak er nu een aan:";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.LinkColor = System.Drawing.Color.Orange;
            this.lblForgotPassword.Location = new System.Drawing.Point(1441, 883);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(173, 20);
            this.lblForgotPassword.TabIndex = 42;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Wachtwoord vergeten?";
            // 
            // lblFeedBuff
            // 
            this.lblFeedBuff.AutoSize = true;
            this.lblFeedBuff.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedBuff.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBuff.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedBuff.Location = new System.Drawing.Point(1077, 554);
            this.lblFeedBuff.Name = "lblFeedBuff";
            this.lblFeedBuff.Size = new System.Drawing.Size(478, 113);
            this.lblFeedBuff.TabIndex = 41;
            this.lblFeedBuff.Text = "FeedBUF";
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectLabel.Location = new System.Drawing.Point(1338, 916);
            this.IncorrectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(351, 25);
            this.IncorrectLabel.TabIndex = 40;
            this.IncorrectLabel.Text = "Gegevens onjuist, probeer opnieuw";
            this.IncorrectLabel.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Orange;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.Location = new System.Drawing.Point(1104, 900);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(224, 60);
            this.SignInButton.TabIndex = 39;
            this.SignInButton.Text = "Log in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginPassword_Label
            // 
            this.LoginPassword_Label.AutoSize = true;
            this.LoginPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Label.Location = new System.Drawing.Point(1099, 811);
            this.LoginPassword_Label.Name = "LoginPassword_Label";
            this.LoginPassword_Label.Size = new System.Drawing.Size(131, 25);
            this.LoginPassword_Label.TabIndex = 35;
            this.LoginPassword_Label.Text = "Wachtwoord";
            // 
            // LoginPassword_Box
            // 
            this.LoginPassword_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Box.Location = new System.Drawing.Point(1104, 839);
            this.LoginPassword_Box.Name = "LoginPassword_Box";
            this.LoginPassword_Box.PasswordChar = '*';
            this.LoginPassword_Box.Size = new System.Drawing.Size(510, 31);
            this.LoginPassword_Box.TabIndex = 34;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlabel.Location = new System.Drawing.Point(1094, 662);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(152, 59);
            this.Loginlabel.TabIndex = 26;
            this.Loginlabel.Text = "Login";
            // 
            // LoginEmail_Label
            // 
            this.LoginEmail_Label.AutoSize = true;
            this.LoginEmail_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Label.Location = new System.Drawing.Point(1099, 736);
            this.LoginEmail_Label.Name = "LoginEmail_Label";
            this.LoginEmail_Label.Size = new System.Drawing.Size(126, 25);
            this.LoginEmail_Label.TabIndex = 23;
            this.LoginEmail_Label.Text = "E-mailadres";
            // 
            // LoginEmail_Box
            // 
            this.LoginEmail_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Box.Location = new System.Drawing.Point(1104, 764);
            this.LoginEmail_Box.Name = "LoginEmail_Box";
            this.LoginEmail_Box.Size = new System.Drawing.Size(510, 31);
            this.LoginEmail_Box.TabIndex = 22;
            this.LoginEmail_Box.Text = "xxx@mail.net";
            // 
            // pnlCreateAccount
            // 
            this.pnlCreateAccount.Controls.Add(this.lblStatus);
            this.pnlCreateAccount.Controls.Add(this.lblName);
            this.pnlCreateAccount.Controls.Add(this.txbName);
            this.pnlCreateAccount.Controls.Add(this.lblStudentNumber);
            this.pnlCreateAccount.Controls.Add(this.txbStudentNumber);
            this.pnlCreateAccount.Controls.Add(this.lblGroup);
            this.pnlCreateAccount.Controls.Add(this.txbGroup);
            this.pnlCreateAccount.Controls.Add(this.btnBack);
            this.pnlCreateAccount.Controls.Add(this.btnPasswordHelp);
            this.pnlCreateAccount.Controls.Add(this.lblRepeatPassword);
            this.pnlCreateAccount.Controls.Add(this.txbNewPasswordRepeat);
            this.pnlCreateAccount.Controls.Add(this.lblFeedBUF);
            this.pnlCreateAccount.Controls.Add(this.btnCreateAccount);
            this.pnlCreateAccount.Controls.Add(this.lblPassword);
            this.pnlCreateAccount.Controls.Add(this.txbNewPassword);
            this.pnlCreateAccount.Controls.Add(this.lblCreateAcc);
            this.pnlCreateAccount.Controls.Add(this.lblEmail);
            this.pnlCreateAccount.Controls.Add(this.txbNewEmail);
            this.pnlCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateAccount.Name = "pnlCreateAccount";
            this.pnlCreateAccount.Size = new System.Drawing.Size(2859, 1606);
            this.pnlCreateAccount.TabIndex = 43;
            this.pnlCreateAccount.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1143, 1066);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 26);
            this.lblStatus.TabIndex = 61;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1143, 668);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 25);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Volledige naam";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(1148, 696);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(510, 31);
            this.txbName.TabIndex = 59;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(1143, 730);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(169, 25);
            this.lblStudentNumber.TabIndex = 58;
            this.lblStudentNumber.Text = "Student nummer";
            // 
            // txbStudentNumber
            // 
            this.txbStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentNumber.Location = new System.Drawing.Point(1148, 758);
            this.txbStudentNumber.Name = "txbStudentNumber";
            this.txbStudentNumber.Size = new System.Drawing.Size(510, 31);
            this.txbStudentNumber.TabIndex = 57;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(1143, 792);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(54, 25);
            this.lblGroup.TabIndex = 56;
            this.lblGroup.Text = "Klas";
            // 
            // txbGroup
            // 
            this.txbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGroup.Location = new System.Drawing.Point(1148, 820);
            this.txbGroup.Name = "txbGroup";
            this.txbGroup.Size = new System.Drawing.Size(510, 31);
            this.txbGroup.TabIndex = 55;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Orange;
            this.btnBack.Location = new System.Drawing.Point(1435, 1095);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(224, 60);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPasswordHelp
            // 
            this.btnPasswordHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswordHelp.BackgroundImage")));
            this.btnPasswordHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordHelp.Location = new System.Drawing.Point(1637, 937);
            this.btnPasswordHelp.Name = "btnPasswordHelp";
            this.btnPasswordHelp.Size = new System.Drawing.Size(22, 25);
            this.btnPasswordHelp.TabIndex = 53;
            this.ttpShowPasswordRequirements.SetToolTip(this.btnPasswordHelp, "Het wachtwoord moet minimaal 1 hoofdletter bevatten en 1 cijfer.");
            this.btnPasswordHelp.UseVisualStyleBackColor = true;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(1144, 998);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(207, 25);
            this.lblRepeatPassword.TabIndex = 52;
            this.lblRepeatPassword.Text = "Herhaal wachtwoord";
            // 
            // txbNewPasswordRepeat
            // 
            this.txbNewPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPasswordRepeat.Location = new System.Drawing.Point(1149, 1026);
            this.txbNewPasswordRepeat.Name = "txbNewPasswordRepeat";
            this.txbNewPasswordRepeat.PasswordChar = '*';
            this.txbNewPasswordRepeat.Size = new System.Drawing.Size(510, 31);
            this.txbNewPasswordRepeat.TabIndex = 51;
            // 
            // lblFeedBUF
            // 
            this.lblFeedBUF.AutoSize = true;
            this.lblFeedBUF.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedBUF.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBUF.ForeColor = System.Drawing.Color.Orange;
            this.lblFeedBUF.Location = new System.Drawing.Point(1114, 507);
            this.lblFeedBUF.Name = "lblFeedBUF";
            this.lblFeedBUF.Size = new System.Drawing.Size(478, 113);
            this.lblFeedBUF.TabIndex = 50;
            this.lblFeedBUF.Text = "FeedBUF";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Orange;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(1148, 1095);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(224, 60);
            this.btnCreateAccount.TabIndex = 48;
            this.btnCreateAccount.Text = "Aanmaken";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(1144, 935);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(131, 25);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.Location = new System.Drawing.Point(1149, 963);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.PasswordChar = '*';
            this.txbNewPassword.Size = new System.Drawing.Size(510, 31);
            this.txbNewPassword.TabIndex = 46;
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.Location = new System.Drawing.Point(1147, 609);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(394, 52);
            this.lblCreateAcc.TabIndex = 45;
            this.lblCreateAcc.Text = "Account aanmaken";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(1144, 854);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 25);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "E-mailadres";
            // 
            // txbNewEmail
            // 
            this.txbNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewEmail.Location = new System.Drawing.Point(1149, 882);
            this.txbNewEmail.Name = "txbNewEmail";
            this.txbNewEmail.Size = new System.Drawing.Size(510, 31);
            this.txbNewEmail.TabIndex = 43;
            this.txbNewEmail.Text = "xxx@mail.net";
            // 
            // ttpShowPasswordRequirements
            // 
            this.ttpShowPasswordRequirements.AutoPopDelay = 10000;
            this.ttpShowPasswordRequirements.InitialDelay = 1000;
            this.ttpShowPasswordRequirements.IsBalloon = true;
            this.ttpShowPasswordRequirements.ReshowDelay = 500;
            this.ttpShowPasswordRequirements.ShowAlways = true;
            this.ttpShowPasswordRequirements.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1602);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.pnlCreateAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.pnlCreateAccount.ResumeLayout(false);
            this.pnlCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label IncorrectLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label LoginPassword_Label;
        private System.Windows.Forms.TextBox LoginPassword_Box;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label LoginEmail_Label;
        private System.Windows.Forms.TextBox LoginEmail_Box;
        private System.Windows.Forms.Label lblFeedBuff;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.Button btnCreateAccountPanel;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Panel pnlCreateAccount;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txbNewPasswordRepeat;
        private System.Windows.Forms.Label lblFeedBUF;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label lblCreateAcc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbNewEmail;
        private System.Windows.Forms.ToolTip ttpShowPasswordRequirements;
        private System.Windows.Forms.Button btnPasswordHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txbGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txbStudentNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblStatus;
    }
}