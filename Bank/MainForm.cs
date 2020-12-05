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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardForm().ShowDialog();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            new ConfiguretionForm().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new CardManager().ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.LogForm.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.MainForm = this;
            Session.LogForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User currentUser = Session.User;
            label3.Text += $" {currentUser.name}";
            label2.Text += $" {currentUser.Surname}";
            label1.Text += $" {currentUser.Age}";

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm_Load(sender, e);
        }
    }
}
