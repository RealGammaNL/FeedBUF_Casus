using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUF
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (User user in Users)
            {
                if (user.Email == LoginEmail_Box.Text && user.Password == LoginPassword_Box.Text && user.SecurityLevel == "Manager")
                {
                    LoginPanel.Hide();
                    ManageAcc_Btn.Show();
                    CreateAccBtn.Show();
                    ToCashBtn.Show();
                    ManageProductsButton.Show();
                    found = true;
                    break;
                }

                if (user.Email == LoginEmail_Box.Text && user.Password == LoginPassword_Box.Text && user.SecurityLevel == "Employee")
                {
                    LoginPanel.Hide();
                    found = true;
                    Hide();
                    Cashregister CashregisterForm = new Cashregister();
                    CashregisterForm.Show();
                    break;
                }
            }

            if (!found)
            {
                LoginPassword_Box.Clear();
                IncorrectLabel.Show();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(2382, 1303);
            this.Name = "LoginForm";
            this.ResumeLayout(false);

        }
    }
}
