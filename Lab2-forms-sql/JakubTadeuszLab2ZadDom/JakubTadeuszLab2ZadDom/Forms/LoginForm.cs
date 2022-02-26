using JakubTadeuszLab2ZadDom.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubTadeuszLab2ZadDom
{
    public partial class LoginForm : Form
    {
        /// <summary> 
        /// Database connection repository
        /// </summary>
        private readonly Repository repository = new Repository();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        /// <summary>
        /// Try to log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int userId = repository.Login(textBoxLogin.Text, textBoxPassword.Text);
            if(userId == -1)
            {
                MessageBox.Show("Niepoprawne dane logowania!");
                textBoxPassword.Text = "";
            }
            else{
                MainForm mainForm = new MainForm
                {
                    userId = userId
                };
                mainForm.ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Show form with the whole database, for testing purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDatabase_Click(object sender, EventArgs e)
        {
            ShowDatabaseForm showDatabaseForm = new ShowDatabaseForm();
            showDatabaseForm.ShowDialog();
        }
    }
}
