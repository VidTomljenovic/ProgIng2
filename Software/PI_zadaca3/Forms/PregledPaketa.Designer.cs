
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.odaberiPaketButton = new System.Windows.Forms.Button();
            this.odjavaLabel = new System.Windows.Forms.LinkLabel();
            this.slikaPaketa = new System.Windows.Forms.PictureBox();
            this.myDocLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pregledPaketaLabel = new System.Windows.Forms.Label();
            this.nazadLabel = new System.Windows.Forms.LinkLabel();
            this.prikazPaketadataGridView = new System.Windows.Forms.DataGridView();
            this.opisPaketaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.napomenaPaketaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cijenaPaketaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pretragaPaketatextBox = new System.Windows.Forms.TextBox();
            this.opisPaketalabel = new System.Windows.Forms.Label();
            this.napomenaPaketalabel = new System.Windows.Forms.Label();
            this.cijenaPaketaLabel = new System.Windows.Forms.Label();
            this.pretragaPaketalabel = new System.Windows.Forms.Label();
            this.povecaloPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPaketadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povecaloPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // odaberiPaketButton
            // 
            this.odaberiPaketButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.odaberiPaketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odaberiPaketButton.ForeColor = System.Drawing.SystemColors.Control;
            this.odaberiPaketButton.Location = new System.Drawing.Point(344, 416);
            this.odaberiPaketButton.Name = "odaberiPaketButton";
            this.odaberiPaketButton.Size = new System.Drawing.Size(120, 32);
            this.odaberiPaketButton.TabIndex = 0;
            this.odaberiPaketButton.Text = "Odaberi paket";
            this.odaberiPaketButton.UseVisualStyleBackColor = false;
            this.odaberiPaketButton.Click += new System.EventHandler(this.odaberiPaketButton_Click);
            // 
            // odjavaLabel
            // 
            this.odjavaLabel.AutoSize = true;
            this.odjavaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.odjavaLabel.Location = new System.Drawing.Point(8, 8);
            this.odjavaLabel.Name = "odjavaLabel";
            this.odjavaLabel.Size = new System.Drawing.Size(41, 13);
            this.odjavaLabel.TabIndex = 1;
            this.odjavaLabel.TabStop = true;
            this.odjavaLabel.Text = "Odjava";
            this.odjavaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.odjavaLabel_LinkClicked);
            // 
            // slikaPaketa
            // 
            this.slikaPaketa.Image = ((System.Drawing.Image)(resources.GetObject("slikaPaketa.Image")));
            this.slikaPaketa.Location = new System.Drawing.Point(72, 0);
            this.slikaPaketa.Name = "slikaPaketa";
            this.slikaPaketa.Size = new System.Drawing.Size(112, 96);
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
            this.panel1.Controls.Add(this.pregledPaketaLabel);
            this.panel1.Controls.Add(this.myDocLabel);
            this.panel1.Controls.Add(this.slikaPaketa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 96);
            this.panel1.TabIndex = 5;
            // 
            // pregledPaketaLabel
            // 
            this.pregledPaketaLabel.AutoSize = true;
            this.pregledPaketaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pregledPaketaLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledPaketaLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.pregledPaketaLabel.Location = new System.Drawing.Point(328, 72);
            this.pregledPaketaLabel.Name = "pregledPaketaLabel";
            this.pregledPaketaLabel.Size = new System.Drawing.Size(120, 22);
            this.pregledPaketaLabel.TabIndex = 21;
            this.pregledPaketaLabel.Text = "Pregled paketa";
            // 
            // nazadLabel
            // 
            this.nazadLabel.AutoSize = true;
            this.nazadLabel.Location = new System.Drawing.Point(16, 424);
            this.nazadLabel.Name = "nazadLabel";
            this.nazadLabel.Size = new System.Drawing.Size(38, 13);
            this.nazadLabel.TabIndex = 7;
            this.nazadLabel.TabStop = true;
            this.nazadLabel.Text = "Nazad";
            this.nazadLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nazadLabel_LinkClicked);
            // 
            // prikazPaketadataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikazPaketadataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prikazPaketadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prikazPaketadataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prikazPaketadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prikazPaketadataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prikazPaketadataGridView.Location = new System.Drawing.Point(216, 96);
            this.prikazPaketadataGridView.Name = "prikazPaketadataGridView";
            this.prikazPaketadataGridView.ReadOnly = true;
            this.prikazPaketadataGridView.Size = new System.Drawing.Size(352, 168);
            this.prikazPaketadataGridView.TabIndex = 8;
            this.prikazPaketadataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // opisPaketaRichTextBox
            // 
            this.opisPaketaRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisPaketaRichTextBox.Location = new System.Drawing.Point(40, 304);
            this.opisPaketaRichTextBox.Name = "opisPaketaRichTextBox";
            this.opisPaketaRichTextBox.ReadOnly = true;
            this.opisPaketaRichTextBox.Size = new System.Drawing.Size(176, 96);
            this.opisPaketaRichTextBox.TabIndex = 9;
            this.opisPaketaRichTextBox.Text = "";
            // 
            // napomenaPaketaRichTextBox
            // 
            this.napomenaPaketaRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napomenaPaketaRichTextBox.Location = new System.Drawing.Point(320, 304);
            this.napomenaPaketaRichTextBox.Name = "napomenaPaketaRichTextBox";
            this.napomenaPaketaRichTextBox.ReadOnly = true;
            this.napomenaPaketaRichTextBox.Size = new System.Drawing.Size(168, 96);
            this.napomenaPaketaRichTextBox.TabIndex = 10;
            this.napomenaPaketaRichTextBox.Text = "";
            // 
            // cijenaPaketaRichTextBox
            // 
            this.cijenaPaketaRichTextBox.Location = new System.Drawing.Point(624, 304);
            this.cijenaPaketaRichTextBox.Name = "cijenaPaketaRichTextBox";
            this.cijenaPaketaRichTextBox.Size = new System.Drawing.Size(88, 32);
            this.cijenaPaketaRichTextBox.TabIndex = 11;
            this.cijenaPaketaRichTextBox.Text = "";
            // 
            // pretragaPaketatextBox
            // 
            this.pretragaPaketatextBox.Location = new System.Drawing.Point(608, 128);
            this.pretragaPaketatextBox.Name = "pretragaPaketatextBox";
            this.pretragaPaketatextBox.Size = new System.Drawing.Size(168, 20);
            this.pretragaPaketatextBox.TabIndex = 12;
            this.pretragaPaketatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // opisPaketalabel
            // 
            this.opisPaketalabel.AutoSize = true;
            this.opisPaketalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisPaketalabel.Location = new System.Drawing.Point(32, 280);
            this.opisPaketalabel.Name = "opisPaketalabel";
            this.opisPaketalabel.Size = new System.Drawing.Size(94, 20);
            this.opisPaketalabel.TabIndex = 13;
            this.opisPaketalabel.Text = "Opis paketa";
            // 
            // napomenaPaketalabel
            // 
            this.napomenaPaketalabel.AutoSize = true;
            this.napomenaPaketalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.napomenaPaketalabel.Location = new System.Drawing.Point(312, 280);
            this.napomenaPaketalabel.Name = "napomenaPaketalabel";
            this.napomenaPaketalabel.Size = new System.Drawing.Size(140, 20);
            this.napomenaPaketalabel.TabIndex = 14;
            this.napomenaPaketalabel.Text = "Napomena paketa";
            // 
            // cijenaPaketaLabel
            // 
            this.cijenaPaketaLabel.AutoSize = true;
            this.cijenaPaketaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cijenaPaketaLabel.Location = new System.Drawing.Point(608, 280);
            this.cijenaPaketaLabel.Name = "cijenaPaketaLabel";
            this.cijenaPaketaLabel.Size = new System.Drawing.Size(106, 20);
            this.cijenaPaketaLabel.TabIndex = 15;
            this.cijenaPaketaLabel.Text = "Cijena paketa";
            // 
            // pretragaPaketalabel
            // 
            this.pretragaPaketalabel.AutoSize = true;
            this.pretragaPaketalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaPaketalabel.Location = new System.Drawing.Point(592, 104);
            this.pretragaPaketalabel.Name = "pretragaPaketalabel";
            this.pretragaPaketalabel.Size = new System.Drawing.Size(123, 20);
            this.pretragaPaketalabel.TabIndex = 16;
            this.pretragaPaketalabel.Text = "Pretraga paketa";
            // 
            // povecaloPictureBox
            // 
            this.povecaloPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("povecaloPictureBox.Image")));
            this.povecaloPictureBox.Location = new System.Drawing.Point(776, 128);
            this.povecaloPictureBox.Name = "povecaloPictureBox";
            this.povecaloPictureBox.Size = new System.Drawing.Size(16, 16);
            this.povecaloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.povecaloPictureBox.TabIndex = 17;
            this.povecaloPictureBox.TabStop = false;
            // 
            // PregledPaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.povecaloPictureBox);
            this.Controls.Add(this.pretragaPaketalabel);
            this.Controls.Add(this.cijenaPaketaLabel);
            this.Controls.Add(this.napomenaPaketalabel);
            this.Controls.Add(this.opisPaketalabel);
            this.Controls.Add(this.pretragaPaketatextBox);
            this.Controls.Add(this.cijenaPaketaRichTextBox);
            this.Controls.Add(this.napomenaPaketaRichTextBox);
            this.Controls.Add(this.opisPaketaRichTextBox);
            this.Controls.Add(this.prikazPaketadataGridView);
            this.Controls.Add(this.nazadLabel);
            this.Controls.Add(this.odjavaLabel);
            this.Controls.Add(this.odaberiPaketButton);
            this.Controls.Add(this.panel1);
            this.Name = "PregledPaketa";
            this.Text = "PregledPaketa";
            this.Load += new System.EventHandler(this.PregledPaketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPaketadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povecaloPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaberiPaketButton;
        private System.Windows.Forms.LinkLabel odjavaLabel;
        private System.Windows.Forms.PictureBox slikaPaketa;
        private System.Windows.Forms.Label myDocLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel nazadLabel;
        private System.Windows.Forms.DataGridView prikazPaketadataGridView;
        private System.Windows.Forms.RichTextBox opisPaketaRichTextBox;
        private System.Windows.Forms.RichTextBox napomenaPaketaRichTextBox;
        private System.Windows.Forms.RichTextBox cijenaPaketaRichTextBox;
        private System.Windows.Forms.TextBox pretragaPaketatextBox;
        private System.Windows.Forms.Label opisPaketalabel;
        private System.Windows.Forms.Label napomenaPaketalabel;
        private System.Windows.Forms.Label cijenaPaketaLabel;
        private System.Windows.Forms.Label pretragaPaketalabel;
        private System.Windows.Forms.PictureBox povecaloPictureBox;
        private System.Windows.Forms.Label pregledPaketaLabel;
    }
}

