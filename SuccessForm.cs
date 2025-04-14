using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopTableBoard
{

    public partial class SuccessForm : Form
    {
        public SuccessForm()
        {
            InitializeComponent();

            // Анимация появления
            this.Opacity = 0;
            Timer fadeIn = new Timer();
            fadeIn.Interval = 20;
            fadeIn.Tick += (s, args) =>
            {
                if (this.Opacity >= 1)
                    fadeIn.Stop();
                else
                    this.Opacity += 0.05;
            };
            fadeIn.Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); this.Close();
        }
    }
}

