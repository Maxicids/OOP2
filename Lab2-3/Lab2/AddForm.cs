using Lab2.Banking;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            tbAmount.Text = trackBar1.Value.ToString();
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (tbAmount.Text != "" && tbAmount.Text != "-" && tbAmount.Text != null)
            {
                trackBar1.Value = Convert.ToInt32(tbAmount.Text);
            }
        }

        private void bCommit_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            if (accountList.Commit(Convert.ToInt32(tbNumber.Text), Convert.ToInt32(tbAmount.Text)) == 0)
            {
                //TODO: Logger
                MessageBox.Show("There is no account with this number ");
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (e.KeyChar == '\b'))
            {
                return;
            }
            e.Handled = true;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbAmount.Text == "")
            {
                return;
            }
            if (tbAmount.Text != "-" && (e.KeyChar != '\b'))
            {
                if (Convert.ToInt32(tbAmount.Text) >= 100)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (Char.IsNumber(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == '-'))
            {
                if (tbAmount.Text.Contains('-') && (e.KeyChar == '-'))
                {
                    e.Handled = true;
                    return;
                }
                return;
            }
            e.Handled = true;
        }
    }
}
