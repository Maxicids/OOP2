using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = new Customer();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            Customer customer = customerBindingSource.Current as Customer;
            if (customer != null)
            {
                ValidationContext context = new ValidationContext(customer, null, null);
                IList<ValidationResult> validationResults = new List<ValidationResult>();
                if (!Validator.TryValidateObject(customer, context, validationResults, true))
                {
                    foreach (ValidationResult result in validationResults)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            MessageBox.Show("Registred", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}