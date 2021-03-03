using Lab2.Banking;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            output.Text += accountList.GetList() + Environment.NewLine;
        }

        private void bDeserialize_Click(object sender, EventArgs e)
        {
            try
            {
                AccountList list = AccountList.GetAccountList();
                list.DeSerialData();
            }
            catch
            {
                MessageBox.Show("Import error", "Deserialization");
            }
        }

        private void bSerialize_Click(object sender, EventArgs e)
        {
            try
            {
                AccountList list = AccountList.GetAccountList();
                list.SerialData();
            }
            catch
            {
                MessageBox.Show("Export error", "Deserialization");
            }
        }
    }
}
