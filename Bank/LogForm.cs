using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class LogForm : Form
    {
        private readonly DbContext dbContext;
        public LogForm()
        {
            InitializeComponent();
            button2.Text = "Register";
            button1.Text = "Login";
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            dbContext = new DbContext();
            Session.Data = dbContext;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string
           email = textBox3.Text,
           password = textBox4.Text;
            User currentUser = dbContext.Users.FindItem(u => u.Email == email);
            if (currentUser != null)
            {
                Session.User = currentUser;
                Session.LogForm = this;
                if (currentUser.userType == UserType.User)
                {
                    new MainForm().Show();
                    Hide();
                }
                else if(currentUser.userType == UserType.Admin)
                {
                    new Admin().Show();
                    Hide();
                }
              
            }
            else
            {
                MessageBox.Show("Your email or password is inccorect! Please try again");
            }
                  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string
                email = textBox1.Text,
                password = textBox2.Text;

            if (dbContext.Users.FindItem(u => u.Email == email) == null)
            {

                User user = new User { Id = Ibentificator<User>.GetId(), Email = email, Password = password, userType = UserType.User };
                dbContext.Users.Add(user);
                MessageBox.Show("You successfully registered!");
            }
            else
            {
                MessageBox.Show("this user already exists!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
