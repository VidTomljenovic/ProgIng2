﻿
namespace PI_zadaca3.Forms
{
    partial class DetaljiPaketa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiPaketa));
            this.detaljiPaketadataGridView = new System.Windows.Forms.DataGridView();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.odjavaLabel = new System.Windows.Forms.LinkLabel();
            this.detaljiPaketaLabel = new System.Windows.Forms.Label();
            this.myDocLabel = new System.Windows.Forms.Label();
            this.slikaPaketa = new System.Windows.Forms.PictureBox();
            this.nazadLabel = new System.Windows.Forms.LinkLabel();
            this.spremiPromjeneButton = new System.Windows.Forms.Button();
            this.pomocPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.detaljiPaketadataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomocPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // detaljiPaketadataGridView
            // 
            this.detaljiPaketadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.detaljiPaketadataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detaljiPaketadataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detaljiPaketadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detaljiPaketadataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.detaljiPaketadataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.detaljiPaketadataGridView.Location = new System.Drawing.Point(16, 120);
            this.detaljiPaketadataGridView.Name = "detaljiPaketadataGridView";
            this.detaljiPaketadataGridView.Size = new System.Drawing.Size(696, 120);
            this.detaljiPaketadataGridView.TabIndex = 0;
            this.detaljiPaketadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detaljiPaketadataGridView_CellClick);
            // 
            // obrisiButton
            // 
            this.obrisiButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.obrisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiButton.Location = new System.Drawing.Point(344, 400);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(120, 32);
            this.obrisiButton.TabIndex = 1;
            this.obrisiButton.Text = "Obrisi paket";
            this.obrisiButton.UseVisualStyleBackColor = false;
            this.obrisiButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pomocPictureBox);
            this.panel1.Controls.Add(this.odjavaLabel);
            this.panel1.Controls.Add(this.detaljiPaketaLabel);
            this.panel1.Controls.Add(this.myDocLabel);
            this.panel1.Controls.Add(this.slikaPaketa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 96);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(440, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // odjavaLabel
            // 
            this.odjavaLabel.AutoSize = true;
            this.odjavaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.odjavaLabel.Location = new System.Drawing.Point(8, 8);
            this.odjavaLabel.Name = "odjavaLabel";
            this.odjavaLabel.Size = new System.Drawing.Size(41, 13);
            this.odjavaLabel.TabIndex = 9;
            this.odjavaLabel.TabStop = true;
            this.odjavaLabel.Text = "Odjava";
            this.odjavaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.odjavaLabel_LinkClicked);
            // 
            // detaljiPaketaLabel
            // 
            this.detaljiPaketaLabel.AutoSize = true;
            this.detaljiPaketaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.detaljiPaketaLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaljiPaketaLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.detaljiPaketaLabel.Location = new System.Drawing.Point(328, 72);
            this.detaljiPaketaLabel.Name = "detaljiPaketaLabel";
            this.detaljiPaketaLabel.Size = new System.Drawing.Size(114, 22);
            this.detaljiPaketaLabel.TabIndex = 21;
            this.detaljiPaketaLabel.Text = "Detalji paketa";
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
            // nazadLabel
            // 
            this.nazadLabel.AutoSize = true;
            this.nazadLabel.Location = new System.Drawing.Point(16, 424);
            this.nazadLabel.Name = "nazadLabel";
            this.nazadLabel.Size = new System.Drawing.Size(38, 13);
            this.nazadLabel.TabIndex = 8;
            this.nazadLabel.TabStop = true;
            this.nazadLabel.Text = "Nazad";
            this.nazadLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nazadLabel_LinkClicked);
            // 
            // spremiPromjeneButton
            // 
            this.spremiPromjeneButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.spremiPromjeneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spremiPromjeneButton.Location = new System.Drawing.Point(336, 360);
            this.spremiPromjeneButton.Name = "spremiPromjeneButton";
            this.spremiPromjeneButton.Size = new System.Drawing.Size(136, 32);
            this.spremiPromjeneButton.TabIndex = 9;
            this.spremiPromjeneButton.Text = "Spremi promjene";
            this.spremiPromjeneButton.UseVisualStyleBackColor = false;
            this.spremiPromjeneButton.Click += new System.EventHandler(this.spremiPromjeneButton_Click);
            // 
            // pomocPictureBox
            // 
            this.pomocPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pomocPictureBox.Image")));
            this.pomocPictureBox.Location = new System.Drawing.Point(736, 8);
            this.pomocPictureBox.Name = "pomocPictureBox";
            this.pomocPictureBox.Size = new System.Drawing.Size(52, 48);
            this.pomocPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pomocPictureBox.TabIndex = 10;
            this.pomocPictureBox.TabStop = false;
            this.pomocPictureBox.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // DetaljiPaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spremiPromjeneButton);
            this.Controls.Add(this.nazadLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.detaljiPaketadataGridView);
            this.Name = "DetaljiPaketa";
            this.Text = "DetaljiPaketa";
            this.Load += new System.EventHandler(this.DetaljiPaketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detaljiPaketadataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPaketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomocPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView detaljiPaketadataGridView;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label detaljiPaketaLabel;
        private System.Windows.Forms.Label myDocLabel;
        private System.Windows.Forms.PictureBox slikaPaketa;
        private System.Windows.Forms.LinkLabel nazadLabel;
        private System.Windows.Forms.LinkLabel odjavaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spremiPromjeneButton;
        private System.Windows.Forms.PictureBox pomocPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}