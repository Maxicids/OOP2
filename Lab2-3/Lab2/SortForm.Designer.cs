using System.ComponentModel;

namespace Lab2
{
    partial class SortForm
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
            this.output = new System.Windows.Forms.TextBox();
            this.bShow = new System.Windows.Forms.Button();
            this.bSort = new System.Windows.Forms.Button();
            this.cbSortType = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(84, 21);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(357, 262);
            this.output.TabIndex = 17;
            this.output.Text = " ";
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(303, 318);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(66, 23);
            this.bShow.TabIndex = 20;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(231, 318);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(66, 23);
            this.bSort.TabIndex = 19;
            this.bSort.Text = "Sort";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // cbSortType
            // 
            this.cbSortType.FormattingEnabled = true;
            this.cbSortType.Items.AddRange(new object[] {"by Opening Date", "by Birth Date", "by Name", "by Number"});
            this.cbSortType.Location = new System.Drawing.Point(82, 318);
            this.cbSortType.Name = "cbSortType";
            this.cbSortType.Size = new System.Drawing.Size(143, 21);
            this.cbSortType.TabIndex = 25;
            this.cbSortType.Text = "Sort type";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(375, 318);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(66, 23);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (47)))), ((int) (((byte) (54)))));
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbSortType);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bSort);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bSave;

        private System.Windows.Forms.ComboBox cbSortType;

        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bSort;

        private System.Windows.Forms.TextBox output;

        #endregion
    }
}