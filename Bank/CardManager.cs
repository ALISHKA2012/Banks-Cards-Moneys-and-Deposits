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
    public partial class CardManager : Form
    {
        public CardManager()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string
                bankName = comboBox1.Text,
                duration = comboBox3.Text,
                CardType = comboBox2.Text;

            CardManager2 cardManager2 = new CardManager2(bankName, duration, CardType, Session.User);
            Card card = cardManager2.GetCard();
            Session.Data.Cards.Add(card);
            textBox4.Text = card.CardNumber;

            textBox4.Text = card.CVC.ToString();

            textBox6.Text = card.ExpiredDate.ToString();
            MessageBox.Show("Card is Done!");
        }

     
    }
}
