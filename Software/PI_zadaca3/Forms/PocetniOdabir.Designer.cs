
namespace PI_zadaca3
{
    partial class PocetniOdabir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetniOdabir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.odjavaLabel = new System.Windows.Forms.LinkLabel();
            this.grupnaKutija1 = new System.Windows.Forms.GroupBox();
            this.stvoritiPaketGumb = new System.Windows.Forms.Button();
            this.noviPaketSlika = new System.Windows.Forms.PictureBox();
            this.zelimOdabratiLabel1 = new System.Windows.Forms.Label();
            this.zelimOdabratiLabel2 = new System.Windows.Forms.Label();
            this.grupnaKutija2 = new System.Windows.Forms.GroupBox();
            this.pregledatiPaketeGumb = new System.Windows.Forms.Button();
            this.pregledPaketaSlika = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grupnaKutija1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noviPaketSlika)).BeginInit();
            this.grupnaKutija2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPaketaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.odjavaLabel);
            this.panel1.Controls.Add(this.grupnaKutija1);
            this.panel1.Controls.Add(this.zelimOdabratiLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 456);
            this.panel1.TabIndex = 6;
            // 
            // odjavaLabel
            // 
            this.odjavaLabel.AutoSize = true;
            this.odjavaLabel.Location = new System.Drawing.Point(16, 16);
            this.odjavaLabel.Name = "odjavaLabel";
            this.odjavaLabel.Size = new System.Drawing.Size(41, 13);
            this.odjavaLabel.TabIndex = 22;
            this.odjavaLabel.TabStop = true;
            this.odjavaLabel.Text = "Odjava";
            this.odjavaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.odjavaLabel_LinkClicked);
            // 
            // grupnaKutija1
            // 
            this.grupnaKutija1.Controls.Add(this.stvoritiPaketGumb);
            this.grupnaKutija1.Controls.Add(this.noviPaketSlika);
            this.grupnaKutija1.Location = new System.Drawing.Point(40, 128);
            this.grupnaKutija1.Name = "grupnaKutija1";
            this.grupnaKutija1.Size = new System.Drawing.Size(264, 176);
            this.grupnaKutija1.TabIndex = 9;
            this.grupnaKutija1.TabStop = false;
            // 
            // stvoritiPaketGumb
            // 
            this.stvoritiPaketGumb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stvoritiPaketGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stvoritiPaketGumb.Location = new System.Drawing.Point(64, 136);
            this.stvoritiPaketGumb.Name = "stvoritiPaketGumb";
            this.stvoritiPaketGumb.Size = new System.Drawing.Size(136, 32);
            this.stvoritiPaketGumb.TabIndex = 9;
            this.stvoritiPaketGumb.Text = "Stvoriti paket";
            this.stvoritiPaketGumb.UseVisualStyleBackColor = false;
            this.stvoritiPaketGumb.Click += new System.EventHandler(this.stvoritiPaketGumb_Click);
            // 
            // noviPaketSlika
            // 
            this.noviPaketSlika.Image = ((System.Drawing.Image)(resources.GetObject("noviPaketSlika.Image")));
            this.noviPaketSlika.Location = new System.Drawing.Point(64, 8);
            this.noviPaketSlika.Name = "noviPaketSlika";
            this.noviPaketSlika.Size = new System.Drawing.Size(132, 122);
            this.noviPaketSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noviPaketSlika.TabIndex = 8;
            this.noviPaketSlika.TabStop = false;
            this.noviPaketSlika.Click += new System.EventHandler(this.noviPaketSlika_Click);
            // 
            // zelimOdabratiLabel1
            // 
            this.zelimOdabratiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zelimOdabratiLabel1.AutoSize = true;
            this.zelimOdabratiLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zelimOdabratiLabel1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zelimOdabratiLabel1.ForeColor = System.Drawing.SystemColors.Info;
            this.zelimOdabratiLabel1.Location = new System.Drawing.Point(136, 64);
            this.zelimOdabratiLabel1.Name = "zelimOdabratiLabel1";
            this.zelimOdabratiLabel1.Size = new System.Drawing.Size(73, 29);
            this.zelimOdabratiLabel1.TabIndex = 7;
            this.zelimOdabratiLabel1.Text = "Želim";
            // 
            // zelimOdabratiLabel2
            // 
            this.zelimOdabratiLabel2.AutoSize = true;
            this.zelimOdabratiLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zelimOdabratiLabel2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zelimOdabratiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zelimOdabratiLabel2.Location = new System.Drawing.Point(568, 64);
            this.zelimOdabratiLabel2.Name = "zelimOdabratiLabel2";
            this.zelimOdabratiLabel2.Size = new System.Drawing.Size(73, 29);
            this.zelimOdabratiLabel2.TabIndex = 8;
            this.zelimOdabratiLabel2.Text = "Želim";
            // 
            // grupnaKutija2
            // 
            this.grupnaKutija2.Controls.Add(this.pregledatiPaketeGumb);
            this.grupnaKutija2.Controls.Add(this.pregledPaketaSlika);
            this.grupnaKutija2.Location = new System.Drawing.Point(464, 136);
            this.grupnaKutija2.Name = "grupnaKutija2";
            this.grupnaKutija2.Size = new System.Drawing.Size(272, 168);
            this.grupnaKutija2.TabIndex = 9;
            this.grupnaKutija2.TabStop = false;
            // 
            // pregledatiPaketeGumb
            // 
            this.pregledatiPaketeGumb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pregledatiPaketeGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledatiPaketeGumb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pregledatiPaketeGumb.Location = new System.Drawing.Point(72, 136);
            this.pregledatiPaketeGumb.Name = "pregledatiPaketeGumb";
            this.pregledatiPaketeGumb.Size = new System.Drawing.Size(136, 32);
            this.pregledatiPaketeGumb.TabIndex = 10;
            this.pregledatiPaketeGumb.Text = "Pregledati pakete";
            this.pregledatiPaketeGumb.UseVisualStyleBackColor = false;
            this.pregledatiPaketeGumb.Click += new System.EventHandler(this.pregledatiPaketeGumb_Click);
            // 
            // pregledPaketaSlika
            // 
            this.pregledPaketaSlika.Image = ((System.Drawing.Image)(resources.GetObject("pregledPaketaSlika.Image")));
            this.pregledPaketaSlika.Location = new System.Drawing.Point(72, 8);
            this.pregledPaketaSlika.Name = "pregledPaketaSlika";
            this.pregledPaketaSlika.Size = new System.Drawing.Size(136, 120);
            this.pregledPaketaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pregledPaketaSlika.TabIndex = 0;
            this.pregledPaketaSlika.TabStop = false;
            this.pregledPaketaSlika.Click += new System.EventHandler(this.pregledPaketaSlika_Click);
            // 
            // PocetniOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupnaKutija2);
            this.Controls.Add(this.zelimOdabratiLabel2);
            this.Controls.Add(this.panel1);
            this.Name = "PocetniOdabir";
            this.Text = "PocetniOdabir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupnaKutija1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noviPaketSlika)).EndInit();
            this.grupnaKutija2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledPaketaSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label zelimOdabratiLabel1;
        private System.Windows.Forms.GroupBox grupnaKutija1;
        private System.Windows.Forms.Button stvoritiPaketGumb;
        private System.Windows.Forms.PictureBox noviPaketSlika;
        private System.Windows.Forms.Label zelimOdabratiLabel2;
        private System.Windows.Forms.GroupBox grupnaKutija2;
        private System.Windows.Forms.Button pregledatiPaketeGumb;
        private System.Windows.Forms.PictureBox pregledPaketaSlika;
        private System.Windows.Forms.LinkLabel odjavaLabel;
    }
}