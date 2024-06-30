
namespace PI_zadaca3
{
    partial class StvaranjePaketa
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
            this.nazadLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nazadLabel
            // 
            this.nazadLabel.AutoSize = true;
            this.nazadLabel.Location = new System.Drawing.Point(16, 416);
            this.nazadLabel.Name = "nazadLabel";
            this.nazadLabel.Size = new System.Drawing.Size(38, 13);
            this.nazadLabel.TabIndex = 8;
            this.nazadLabel.TabStop = true;
            this.nazadLabel.Text = "Nazad";
            this.nazadLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nazadLabel_LinkClicked);
            // 
            // StvaranjePaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nazadLabel);
            this.Name = "StvaranjePaketa";
            this.Text = "StvaranjePaketa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel nazadLabel;
    }
}