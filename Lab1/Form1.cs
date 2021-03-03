using System;
using System.Windows.Forms;
using Lab1.Converter;

namespace Lab1
{
    public partial class Конвертер : Form
    {
        public Конвертер()
        {
            InitializeComponent();
        }

        private void switch1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = Service.GetInstance();
                service.From = Creator.GetCountry(cbFrom.Text);
                service.To = Creator.GetCountry(cbTo.Text);
                service.From.size = Convert.ToDouble(numericFrom.Value);
                tbResult.Text = service.Convert(service.From, service.To, switch1.Checked).ToString();
            }
            catch(ServiceException exception)
            {
                MessageBox.Show(exception.GetInfo());
            }
        }

        private void numericFrom_ValueChanged(object sender, EventArgs e)
        {
            //if()
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}
