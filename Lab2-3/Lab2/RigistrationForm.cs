using Lab2.Banking;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class RigistrationForm : Form
    {
        public RigistrationForm()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            ValidateRegistration();
            Owner owner = new Owner(tbName.Text, dt.Value);
            BankAccount account =
                BankAccount.GetBankAccount(cbType.SelectedIndex, owner, cbSMS.Checked, cbinternetBanking.Checked);
            if (account == null)//TODO:(validation)
            {
                MessageBox.Show("You must select account type");
                return;
            }
            AccountList accountList = AccountList.GetAccountList();
            accountList.Add(account);
            MessageBox.Show("Account with name: " + tbName.Text + " has been registered", "Registration");
            ClearAfterRegistration();
        }

        private void ValidateRegistration()
        {
            //bankingBindingSource
        }

        private void ClearAfterRegistration()
        {
            tbName.Text = "Name";
            dt.ResetText();
            cbSMS.Checked = false;
            cbinternetBanking.Checked = false;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == '\b'))
            {
                    return;
            }
            e.Handled = true;
        }
    }
}
