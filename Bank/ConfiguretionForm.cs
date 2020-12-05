using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class ConfiguretionForm : Form
    {
        public ConfiguretionForm()
        {
            InitializeComponent();
            button1.Text = "Update";
            button1.Click += Button1_Click;
            textBox3.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateUser(Session.User);
            MessageBox.Show("User updated!");
        }
    
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void GetCurrentUser(User user)
        {
            textBox1.Text = user.Age.ToString();
            textBox4.Text = user.name;
            textBox2.Text = user.Surname;
            textBox3.Text = user.Email;
            textBox5.Text = user.Password;

        }

        private void ConfiguretionForm_Load(object sender, EventArgs e)
        {
            GetCurrentUser(Session.User);
        }
        private void UpdateUser(User user)
        {
            user.name = textBox4.Text;
            user.Surname = textBox2.Text;
            user.Age = byte.Parse(textBox1.Text);
            user.Email = textBox3.Text;
            user.Password = textBox5.Text;
            DbContext db = Session.Data;
            db.Users.Update(user);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
