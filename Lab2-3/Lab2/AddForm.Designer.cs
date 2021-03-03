
namespace Lab2
{
    partial class AddForm
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.bCommit = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(133, 145);
            this.trackBar1.Maximum = 999;
            this.trackBar1.Minimum = -999;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(268, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(190, 91);
            this.tbAmount.MaxLength = 4;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(152, 20);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.Text = "0";
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // bCommit
            // 
            this.bCommit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCommit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bCommit.Location = new System.Drawing.Point(202, 226);
            this.bCommit.Name = "bCommit";
            this.bCommit.Size = new System.Drawing.Size(118, 23);
            this.bCommit.TabIndex = 2;
            this.bCommit.Text = "Commit";
            this.bCommit.UseVisualStyleBackColor = true;
            this.bCommit.Click += new System.EventHandler(this.bCommit_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(190, 52);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(152, 20);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.Text = "Account number";
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.bCommit);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button bCommit;
        private System.Windows.Forms.TextBox tbNumber;
    }
}