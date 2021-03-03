using System;
using System.Windows.Forms;
using Lab2.Banking;

namespace Lab2
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            if (accountList.Sort(cbSortType.SelectedIndex).Equals(1))
            {
                output.Text += string.Concat("Sorted ", cbSortType.Text, Environment.NewLine,
                    "___List___", Environment.NewLine, accountList.GetList(), "__________", Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Choose sort type", "error");
            }
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            output.Text += string.Concat(Environment.NewLine,
                "___List___", Environment.NewLine, accountList.GetList(), "__________", Environment.NewLine);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            accountList.SerialData();
        }
    }
}