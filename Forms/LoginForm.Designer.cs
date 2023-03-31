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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.LoginPassword_Label = new System.Windows.Forms.Label();
            this.LoginPassword_Box = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.LoginEmail_Label = new System.Windows.Forms.Label();
            this.LoginEmail_Box = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LoginPanel.Controls.Add(this.IncorrectLabel);
            this.LoginPanel.Controls.Add(this.SignInButton);
            this.LoginPanel.Controls.Add(this.LoginPassword_Label);
            this.LoginPanel.Controls.Add(this.LoginPassword_Box);
            this.LoginPanel.Controls.Add(this.Loginlabel);
            this.LoginPanel.Controls.Add(this.LoginEmail_Label);
            this.LoginPanel.Controls.Add(this.LoginEmail_Box);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1906, 1044);
            this.LoginPanel.TabIndex = 42;
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectLabel.Location = new System.Drawing.Point(290, 137);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(126, 17);
            this.IncorrectLabel.TabIndex = 40;
            this.IncorrectLabel.Text = "Incorrect, try again";
            this.IncorrectLabel.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(134, 127);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(149, 39);
            this.SignInButton.TabIndex = 39;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginPassword_Label
            // 
            this.LoginPassword_Label.AutoSize = true;
            this.LoginPassword_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Label.Location = new System.Drawing.Point(34, 102);
            this.LoginPassword_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPassword_Label.Name = "LoginPassword_Label";
            this.LoginPassword_Label.Size = new System.Drawing.Size(69, 17);
            this.LoginPassword_Label.TabIndex = 35;
            this.LoginPassword_Label.Text = "Password";
            // 
            // LoginPassword_Box
            // 
            this.LoginPassword_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword_Box.Location = new System.Drawing.Point(134, 97);
            this.LoginPassword_Box.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPassword_Box.Name = "LoginPassword_Box";
            this.LoginPassword_Box.PasswordChar = '*';
            this.LoginPassword_Box.Size = new System.Drawing.Size(570, 23);
            this.LoginPassword_Box.TabIndex = 34;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginlabel.Location = new System.Drawing.Point(30, 20);
            this.Loginlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(101, 39);
            this.Loginlabel.TabIndex = 26;
            this.Loginlabel.Text = "Login";
            // 
            // LoginEmail_Label
            // 
            this.LoginEmail_Label.AutoSize = true;
            this.LoginEmail_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Label.Location = new System.Drawing.Point(34, 76);
            this.LoginEmail_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginEmail_Label.Name = "LoginEmail_Label";
            this.LoginEmail_Label.Size = new System.Drawing.Size(98, 17);
            this.LoginEmail_Label.TabIndex = 23;
            this.LoginEmail_Label.Text = "Email Address";
            // 
            // LoginEmail_Box
            // 
            this.LoginEmail_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginEmail_Box.Location = new System.Drawing.Point(134, 70);
            this.LoginEmail_Box.Margin = new System.Windows.Forms.Padding(2);
            this.LoginEmail_Box.Name = "LoginEmail_Box";
            this.LoginEmail_Box.Size = new System.Drawing.Size(570, 23);
            this.LoginEmail_Box.TabIndex = 22;
            this.LoginEmail_Box.Text = "xxx@mail.net";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
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
    }
}