
namespace Lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pMain = new System.Windows.Forms.Panel();
            this.pToFill = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pTop = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.pRollUp = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pRegistration = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bAbout = new System.Windows.Forms.Button();
            this.bSort = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.pFill = new System.Windows.Forms.Panel();
            this.bShowMenu = new System.Windows.Forms.Button();
            this.bAddMenu = new System.Windows.Forms.Button();
            this.bRegistMenu = new System.Windows.Forms.Button();
            this.pMain.SuspendLayout();
            this.pToFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pRegistration.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.AutoScroll = true;
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.pMain.Controls.Add(this.pToFill);
            this.pMain.Controls.Add(this.pTop);
            this.pMain.Controls.Add(this.pRegistration);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(640, 393);
            this.pMain.TabIndex = 2;
            // 
            // pToFill
            // 
            this.pToFill.Controls.Add(this.pictureBox1);
            this.pToFill.Location = new System.Drawing.Point(106, 18);
            this.pToFill.Name = "pToFill";
            this.pToFill.Size = new System.Drawing.Size(533, 374);
            this.pToFill.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.pTop.Controls.Add(this.tbTitle);
            this.pTop.Controls.Add(this.pRollUp);
            this.pTop.Controls.Add(this.pictureBox4);
            this.pTop.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pTop.Location = new System.Drawing.Point(-18, -4);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(658, 22);
            this.pTop.TabIndex = 15;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbTitle.Location = new System.Drawing.Point(23, 5);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ShortcutsEnabled = false;
            this.tbTitle.Size = new System.Drawing.Size(100, 17);
            this.tbTitle.TabIndex = 16;
            this.tbTitle.Text = "Banking";
            // 
            // pRollUp
            // 
            this.pRollUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRollUp.BackgroundImage")));
            this.pRollUp.Location = new System.Drawing.Point(621, 5);
            this.pRollUp.Name = "pRollUp";
            this.pRollUp.Size = new System.Drawing.Size(17, 17);
            this.pRollUp.TabIndex = 1;
            this.pRollUp.TabStop = false;
            this.pRollUp.Click += new System.EventHandler(this.pRollUp_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(640, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pRegistration
            // 
            this.pRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.pRegistration.Controls.Add(this.statusStrip);
            this.pRegistration.Controls.Add(this.bAbout);
            this.pRegistration.Controls.Add(this.bSort);
            this.pRegistration.Controls.Add(this.bSearch);
            this.pRegistration.Controls.Add(this.pFill);
            this.pRegistration.Controls.Add(this.bShowMenu);
            this.pRegistration.Controls.Add(this.bAddMenu);
            this.pRegistration.Controls.Add(this.bRegistMenu);
            this.pRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pRegistration.Location = new System.Drawing.Point(0, 0);
            this.pRegistration.Name = "pRegistration";
            this.pRegistration.Size = new System.Drawing.Size(105, 393);
            this.pRegistration.TabIndex = 14;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 371);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(105, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "Number of objects: ";
            // 
            // bAbout
            // 
            this.bAbout.FlatAppearance.BorderSize = 0;
            this.bAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.bAbout.Location = new System.Drawing.Point(3, 345);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(99, 23);
            this.bAbout.TabIndex = 21;
            this.bAbout.Text = "About";
            this.bAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAbout.UseVisualStyleBackColor = true;
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // bSort
            // 
            this.bSort.FlatAppearance.BorderSize = 0;
            this.bSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSort.ForeColor = System.Drawing.Color.Gainsboro;
            this.bSort.Location = new System.Drawing.Point(3, 170);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(99, 23);
            this.bSort.TabIndex = 20;
            this.bSort.Text = "Sorting";
            this.bSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // bSearch
            // 
            this.bSearch.FlatAppearance.BorderSize = 0;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.bSearch.Location = new System.Drawing.Point(3, 140);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(99, 23);
            this.bSearch.TabIndex = 19;
            this.bSearch.Text = "Search";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pFill
            // 
            this.pFill.Location = new System.Drawing.Point(106, 206);
            this.pFill.Name = "pFill";
            this.pFill.Size = new System.Drawing.Size(201, 175);
            this.pFill.TabIndex = 16;
            // 
            // bShowMenu
            // 
            this.bShowMenu.FlatAppearance.BorderSize = 0;
            this.bShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.bShowMenu.Location = new System.Drawing.Point(3, 110);
            this.bShowMenu.Name = "bShowMenu";
            this.bShowMenu.Size = new System.Drawing.Size(99, 23);
            this.bShowMenu.TabIndex = 18;
            this.bShowMenu.Text = "Show";
            this.bShowMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bShowMenu.UseVisualStyleBackColor = true;
            this.bShowMenu.Click += new System.EventHandler(this.bShowMenu_Click);
            // 
            // bAddMenu
            // 
            this.bAddMenu.FlatAppearance.BorderSize = 0;
            this.bAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.bAddMenu.Location = new System.Drawing.Point(3, 80);
            this.bAddMenu.Name = "bAddMenu";
            this.bAddMenu.Size = new System.Drawing.Size(99, 23);
            this.bAddMenu.TabIndex = 17;
            this.bAddMenu.Text = "Add";
            this.bAddMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddMenu.UseVisualStyleBackColor = true;
            this.bAddMenu.Click += new System.EventHandler(this.bAddMenu_Click);
            // 
            // bRegistMenu
            // 
            this.bRegistMenu.FlatAppearance.BorderSize = 0;
            this.bRegistMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRegistMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.bRegistMenu.Location = new System.Drawing.Point(3, 50);
            this.bRegistMenu.Name = "bRegistMenu";
            this.bRegistMenu.Size = new System.Drawing.Size(99, 28);
            this.bRegistMenu.TabIndex = 16;
            this.bRegistMenu.Text = "Registation";
            this.bRegistMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRegistMenu.UseVisualStyleBackColor = true;
            this.bRegistMenu.Click += new System.EventHandler(this.bRegistMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(640, 393);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pMain.ResumeLayout(false);
            this.pToFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pRegistration.ResumeLayout(false);
            this.pRegistration.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.Button bAbout;

        private System.Windows.Forms.Panel pMain;

        #endregion
        private System.Windows.Forms.Panel pRegistration;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pRollUp;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button bShowMenu;
        private System.Windows.Forms.Button bAddMenu;
        private System.Windows.Forms.Button bRegistMenu;
        private System.Windows.Forms.Panel pToFill;
        private System.Windows.Forms.Panel pFill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

