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
    public partial class LoginForm : Form
    {
        private string text;

        public LoginForm()
        {
            InitializeComponent();
            pictureBox3.Image = this.CreateImage(pictureBox3.Width, pictureBox3.Height);
            passwordTextBox.UseSystemPasswordChar = true;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();


            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, 10);
            int Ypos = rnd.Next(0, 10);

      
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 4; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "user" && passwordTextBox.Text == "user")
            {
                SuccessForm successForm = new SuccessForm();
                successForm.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }
    }
}
