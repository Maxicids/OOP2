
namespace Lab2
{
    partial class RigistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RigistrationForm));
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.pChechBoxes = new System.Windows.Forms.Panel();
            this.cbinternetBanking = new System.Windows.Forms.CheckBox();
            this.cbSMS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.pChechBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(171, 138);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 20);
            this.dt.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(136, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(205, 261);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(119, 23);
            this.bRegister.TabIndex = 21;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(136, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(171, 95);
            this.tbName.MaxLength = 15;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 23;
            this.tbName.Text = "Name";
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {"Saving", "Current", "Term"});
            this.cbType.Location = new System.Drawing.Point(171, 181);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 21);
            this.cbType.TabIndex = 24;
            this.cbType.Text = "Deposit type";
            // 
            // pChechBoxes
            // 
            this.pChechBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pChechBoxes.Controls.Add(this.cbinternetBanking);
            this.pChechBoxes.Controls.Add(this.cbSMS);
            this.pChechBoxes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pChechBoxes.Location = new System.Drawing.Point(171, 208);
            this.pChechBoxes.Name = "pChechBoxes";
            this.pChechBoxes.Size = new System.Drawing.Size(200, 47);
            this.pChechBoxes.TabIndex = 28;
            // 
            // cbinternetBanking
            // 
            this.cbinternetBanking.AutoSize = true;
            this.cbinternetBanking.Location = new System.Drawing.Point(3, 26);
            this.cbinternetBanking.Name = "cbinternetBanking";
            this.cbinternetBanking.Size = new System.Drawing.Size(103, 17);
            this.cbinternetBanking.TabIndex = 1;
            this.cbinternetBanking.Text = "Internet banking";
            this.cbinternetBanking.UseVisualStyleBackColor = true;
            // 
            // cbSMS
            // 
            this.cbSMS.AutoSize = true;
            this.cbSMS.Location = new System.Drawing.Point(3, 3);
            this.cbSMS.Name = "cbSMS";
            this.cbSMS.Size = new System.Drawing.Size(73, 17);
            this.cbSMS.TabIndex = 0;
            this.cbSMS.Text = "SMS Alert";
            this.cbSMS.UseVisualStyleBackColor = true;
            // 
            // RigistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (47)))), ((int) (((byte) (54)))));
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.pChechBoxes);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RigistrationForm";
            this.Text = "RigistrationForm";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.pChechBoxes.ResumeLayout(false);
            this.pChechBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Panel pChechBoxes;
        private System.Windows.Forms.CheckBox cbinternetBanking;
        private System.Windows.Forms.CheckBox cbSMS;
    }
}