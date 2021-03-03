using System;
using System.Windows.Forms;
using Lab2.Banking;

namespace Lab2
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            tbOutput.Text = accountList.Search(cbRegex.Checked, tbSearch.Text);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            accountList.SerialData(1);
        }
    }
}