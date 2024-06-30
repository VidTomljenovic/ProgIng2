
namespace PI_zadaca3
{
    partial class PregledPaketa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledPaketa));
            this.odaberiPaketButton = new System.Windows.Forms.Button();
            this.odjavaLabel = new System.Windows.Forms.LinkLabel();
            this.slikaPaketa = new System.Windows.Forms.PictureBox();
            this.myDocLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nazadLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odaberiPaketButton
            // 
            this.odaberiPaketButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.odaberiPaketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odaberiPaketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.odaberiPaketButton.Location = new System.Drawing.Point(328, 392);
            this.odaberiPaketButton.Name = "odaberiPaketButton";
            this.odaberiPaketButton.Size = new System.Drawing.Size(120, 32);
            this.odaberiPaketButton.TabIndex = 0;
            this.odaberiPaketButton.Text = "Odaberi paket";
            this.odaberiPaketButton.UseVisualStyleBackColor = false;
            // 
            // odjavaLabel
            // 
            this.odjavaLabel.AutoSize = true;
            this.odjavaLabel.Location = new System.Drawing.Point(8, 8);
            this.odjavaLabel.Name = "odjavaLabel";
            this.odjavaLabel.Size = new System.Drawing.Size(41, 13);
            this.odjavaLabel.TabIndex = 1;
            this.odjavaLabel.TabStop = true;
            this.odjavaLabel.Text = "Odjava";
            // 
            // slikaPaketa
            // 
            this.slikaPaketa.Image = ((System.Drawing.Image)(resources.GetObject("slikaPaketa.Image")));
            this.slikaPaketa.Location = new System.Drawing.Point(72, 8);
            this.slikaPaketa.Name = "slikaPaketa";
            this.slikaPaketa.Size = new System.Drawing.Size(112, 88);
            this.slikaPaketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slikaPaketa.TabIndex = 2;
            this.slikaPaketa.TabStop = false;
            // 
            // myDocLabel
            // 
            this.myDocLabel.AutoSize = true;
            this.myDocLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.myDocLabel.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myDocLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.myDocLabel.Location = new System.Drawing.Point(328, 8);
            this.myDocLabel.Name = "myDocLabel";
            this.myDocLabel.Size = new System.Drawing.Size(125, 46);
            this.myDocLabel.TabIndex = 4;
            this.myDocLabel.Text = "MyDoc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.myDocLabel);
            this.panel1.Controls.Add(this.slikaPaketa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 96);
            this.panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // nazadLabel
            // 
            this.nazadLabel.AutoSize = true;
            this.nazadLabel.Location = new System.Drawing.Point(16, 408);
            this.nazadLabel.Name = "nazadLabel";
            this.nazadLabel.Size = new System.Drawing.Size(38, 13);
            this.nazadLabel.TabIndex = 7;
            this.nazadLabel.TabStop = true;
            this.nazadLabel.Text = "Nazad";
            this.nazadLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nazadLabel_LinkClicked);
            // 
            // PregledPaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nazadLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.odjavaLabel);
            this.Controls.Add(this.odaberiPaketButton);
            this.Controls.Add(this.panel1);
            this.Name = "PregledPaketa";
            this.Text = "PregledPaketa";
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaberiPaketButton;
        private System.Windows.Forms.LinkLabel odjavaLabel;
        private System.Windows.Forms.PictureBox slikaPaketa;
        private System.Windows.Forms.Label myDocLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel nazadLabel;
    }
}

