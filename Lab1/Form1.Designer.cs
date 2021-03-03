
namespace Lab1
{
    partial class Конвертер
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.switch1 = new Lab1.Switch();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switch1);
            this.panel1.Controls.Add(this.numericFrom);
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Controls.Add(this.bConvert);
            this.panel1.Controls.Add(this.cbFrom);
            this.panel1.Controls.Add(this.cbTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 109);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(224, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "f/m";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // switch1
            // 
            this.switch1.BackColor = System.Drawing.Color.White;
            this.switch1.BackColorOn = System.Drawing.Color.Red;
            this.switch1.Checked = false;
            this.switch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch1.Font = new System.Drawing.Font("Verdana", 9F);
            this.switch1.Location = new System.Drawing.Point(217, 75);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(40, 15);
            this.switch1.TabIndex = 6;
            this.switch1.Text = "switch1";
            // 
            // numericFrom
            // 
            this.numericFrom.Location = new System.Drawing.Point(33, 69);
            this.numericFrom.Maximum = new decimal(new int[] {50, 0, 0, 0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(120, 21);
            this.numericFrom.TabIndex = 5;
            this.numericFrom.ValueChanged += new System.EventHandler(this.numericFrom_ValueChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(393, 22);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 21);
            this.tbResult.TabIndex = 3;
            this.tbResult.Text = "Result";
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // bConvert
            // 
            this.bConvert.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bConvert.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.bConvert.Location = new System.Drawing.Point(393, 69);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(100, 23);
            this.bConvert.TabIndex = 2;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = false;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {"USA", "Europe", "Russia"});
            this.cbFrom.Location = new System.Drawing.Point(32, 22);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 1;
            this.cbFrom.Text = "From";
            // 
            // cbTo
            // 
            this.cbTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {"USA", "Europe", "Russia"});
            this.cbTo.Location = new System.Drawing.Point(178, 22);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 0;
            this.cbTo.Text = "To";
            // 
            // Конвертер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 109);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MaximumSize = new System.Drawing.Size(555, 148);
            this.MinimumSize = new System.Drawing.Size(555, 148);
            this.Name = "Конвертер";
            this.Text = "Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericFrom)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericFrom;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private Switch switch1;
        private System.Windows.Forms.Label label1;
    }
}

