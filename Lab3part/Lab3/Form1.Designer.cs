namespace Lab3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passportIdLabel;
            System.Windows.Forms.Label passWordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passportIdTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            passportIdLabel = new System.Windows.Forms.Label();
            passWordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.customerBindingSource)).BeginInit();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(104, 95);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(104, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // passportIdLabel
            // 
            passportIdLabel.AutoSize = true;
            passportIdLabel.Location = new System.Drawing.Point(104, 147);
            passportIdLabel.Name = "passportIdLabel";
            passportIdLabel.Size = new System.Drawing.Size(63, 13);
            passportIdLabel.TabIndex = 6;
            passportIdLabel.Text = "Passport Id:";
            // 
            // passWordLabel
            // 
            passWordLabel.AutoSize = true;
            passWordLabel.Location = new System.Drawing.Point(104, 173);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new System.Drawing.Size(62, 13);
            passWordLabel.TabIndex = 8;
            passWordLabel.Text = "Pass Word:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Lab3.Customer);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(173, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(173, 118);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // passportIdTextBox
            // 
            this.passportIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PassportId", true));
            this.passportIdTextBox.Location = new System.Drawing.Point(173, 144);
            this.passportIdTextBox.Name = "passportIdTextBox";
            this.passportIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.passportIdTextBox.TabIndex = 7;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PassWord", true));
            this.passWordTextBox.Location = new System.Drawing.Point(173, 170);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passWordTextBox.TabIndex = 9;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(107, 219);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 10;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(198, 219);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 11;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(219, 48);
            // 
            // 
            // 
            this.toolStripContainer1.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripContainer1.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.toolStripContainer1.LeftToolStripPanel.Name = "";
            this.toolStripContainer1.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripContainer1.LeftToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.toolStripContainer1.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripContainer1.LeftToolStripPanel.Size = new System.Drawing.Size(25, 78);
            this.toolStripContainer1.LeftToolStripPanel.Visible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(12, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(219, 73);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripButton1, this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(58, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 254);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bNew);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passportIdLabel);
            this.Controls.Add(this.passportIdTextBox);
            this.Controls.Add(passWordLabel);
            this.Controls.Add(this.passWordTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.customerBindingSource)).EndInit();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripButton toolStripButton2;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passportIdTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSave;
    }
}