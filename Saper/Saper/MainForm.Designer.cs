namespace Saper
{
    partial class MainForm
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
            this.lblBombsLeft = new System.Windows.Forms.Label();
            this.lblFlagsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            // 
            // lblBombsLeft
            // 
            this.lblBombsLeft.AutoSize = true;
            this.lblBombsLeft.Location = new System.Drawing.Point(12, 319);
            this.lblBombsLeft.Name = "lblBombsLeft";
            this.lblBombsLeft.Size = new System.Drawing.Size(68, 13);
            this.lblBombsLeft.TabIndex = 1;
            this.lblBombsLeft.Text = "Bombs left: 0";
            // 
            // lblFlagsLeft
            // 
            this.lblFlagsLeft.AutoSize = true;
            this.lblFlagsLeft.Location = new System.Drawing.Point(225, 319);
            this.lblFlagsLeft.Name = "lblFlagsLeft";
            this.lblFlagsLeft.Size = new System.Drawing.Size(61, 13);
            this.lblFlagsLeft.TabIndex = 1;
            this.lblFlagsLeft.Text = "Flags left: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 341);
            this.Controls.Add(this.lblFlagsLeft);
            this.Controls.Add(this.lblBombsLeft);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBombsLeft;
        private System.Windows.Forms.Label lblFlagsLeft;
    }
}

