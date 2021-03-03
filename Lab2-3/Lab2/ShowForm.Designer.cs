
namespace Lab2
{
    partial class ShowForm
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
            this.bShow = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.bSerialize = new System.Windows.Forms.Button();
            this.bDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(74, 317);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(91, 23);
            this.bShow.TabIndex = 17;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(74, 25);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(357, 262);
            this.output.TabIndex = 16;
            this.output.Text = " ";
            // 
            // bSerialize
            // 
            this.bSerialize.Location = new System.Drawing.Point(199, 317);
            this.bSerialize.Name = "bSerialize";
            this.bSerialize.Size = new System.Drawing.Size(100, 23);
            this.bSerialize.TabIndex = 18;
            this.bSerialize.Text = "Serialize";
            this.bSerialize.UseVisualStyleBackColor = true;
            this.bSerialize.Click += new System.EventHandler(this.bSerialize_Click);
            // 
            // bDeserialize
            // 
            this.bDeserialize.Location = new System.Drawing.Point(331, 317);
            this.bDeserialize.Name = "bDeserialize";
            this.bDeserialize.Size = new System.Drawing.Size(100, 23);
            this.bDeserialize.TabIndex = 19;
            this.bDeserialize.Text = "Deserialize";
            this.bDeserialize.UseVisualStyleBackColor = true;
            this.bDeserialize.Click += new System.EventHandler(this.bDeserialize_Click);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(533, 374);
            this.Controls.Add(this.bSerialize);
            this.Controls.Add(this.bDeserialize);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowForm";
            this.Text = "ShowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button bSerialize;
        private System.Windows.Forms.Button bDeserialize;
    }
}