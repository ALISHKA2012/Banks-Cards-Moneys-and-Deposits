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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void linkUsers(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvAdmin.DataSource = Session.Data.Users.GetAll().ToList();

        }

        private void linkCards(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvAdmin.DataSource = Session.Data.Cards.GetAll().ToList();
        }

        private void linkOut(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.Admin = this;
            Session.LogForm.Show();
        }

        private void linkRefresh(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Load(sender, e);
        }

        private void groupAdmin(object sender, EventArgs e)
        {

        }

        private void dgv_Admin(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupAdmin2(object sender, EventArgs e)
        {

        }
    }
}
