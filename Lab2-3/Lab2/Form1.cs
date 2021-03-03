using Lab2.Banking;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Form1 : Form
    {
        Timer timer;
        string onTick = "Number of objects: ";
        public Form1()
        {
            InitializeComponent();


            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            AccountList accountList = AccountList.GetAccountList();
            toolStripStatusLabel2.Text = onTick + accountList.Count();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pRollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private const int WmNclButtonDown = 0xA1;
        private const int HtCaption = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
            }
        }

        private void bShowMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowForm());
        }

        private void bRegistMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RigistrationForm());
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pToFill.Controls.Add(childForm);
            pToFill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bAddMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddForm());
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchForm());
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SortForm());
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            activeForm?.Close();
        }
    }
}
