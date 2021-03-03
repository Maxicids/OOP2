using System.ComponentModel;

namespace Lab2
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(100, 83);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(292, 28);
            this.tbSearch.TabIndex = 18;
            this.tbSearch.Text = " ";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(100, 156);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(321, 168);
            this.tbOutput.TabIndex = 19;
            this.tbOutput.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(154, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 138);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cbRegex
            // 
            this.cbRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbRegex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbRegex.Location = new System.Drawing.Point(100, 123);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(104, 24);
            this.cbRegex.TabIndex = 21;
            this.cbRegex.Text = "Regex";
            this.cbRegex.UseVisualStyleBackColor = true;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Location = new System.Drawing.Point(390, 83);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(28, 28);
            this.pbSearch.TabIndex = 22;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(343, 124);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 23;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (47)))), ((int) (((byte) (54)))));
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.cbRegex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bSave;

        private System.Windows.Forms.PictureBox pbSearch;

        private System.Windows.Forms.CheckBox cbRegex;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.RichTextBox tbOutput;

        private System.Windows.Forms.TextBox tbSearch;

        #endregion
    }
}