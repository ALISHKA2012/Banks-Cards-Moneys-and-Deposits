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
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardForm_Load(object sender, EventArgs e)
        {



            dataGridView1.DataSource = Session.Data.Cards.GetAllBy(card => card.CardHolderId == Session.User.Id)
                .Select(card => new { card.Id, card.CardHolder, card.CardNumber, card.CardType, card.Bank, card.CVC, card.ExpiredDate })
                .ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
           
                var dgv = sender as DataGridView;
            int idColum = default;

            if (int.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out idColum))
            {

            }
                Card card = Session.Data.Cards.FindItem(c => c.Id == idColum);
                textBox1.Text = card.Bank.ToString();
                textBox4.Text = card.CardNumber.ToString();
                textBox3.Text = card.CVC.ToString();
                textBox5.Text = card.Duration.ToString();
                textBox2.Text = card.CardType.ToString();
                textBox6.Text = card.ExpiredDate.ToString();
            

        }
    }
}
