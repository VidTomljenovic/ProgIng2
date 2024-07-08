using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PI_zadaca3.Forms;
using PI_zadaca3.Modules;
using PI_zadaca3.Repositories;

namespace PI_zadaca3
{
    public partial class PregledPaketa : Form
    {
        public PregledPaketa()
        {
            InitializeComponent();
            pomocPictureBox.MouseHover += pomocPictureBox_MouseHover;
            pomocPictureBox.MouseLeave += pomocPictureBox_MouseLeave;
        }

        private void NavigacijaPocetniOdabir()
        {
            PocetniOdabir pocetniOdabir = new PocetniOdabir();
            pocetniOdabir.Show();
            this.Hide();
        }


        private void PregledPaketa_Load(object sender, EventArgs e)
        {
            PrikazPaketa();
            cijenaPaketaRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void PrikazPaketa()
        {
            List<Paket> paketi = RepozitorijPaketa.GetPaketi();
            prikazPaketadataGridView.DataSource = paketi.Select(p => new { p.ID, p.ImePaketa }).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (prikazPaketadataGridView.SelectedRows.Count > 0)
            {
                int id = (int)prikazPaketadataGridView.SelectedRows[0].Cells["ID"].Value;
                opisPaketaRichTextBox.Text = RepozitorijPaketa.GetOpisPaketa(id);
                napomenaPaketaRichTextBox.Text = RepozitorijPaketa.GetNapomenaPaketa(id);
                cijenaPaketaRichTextBox.Text = RepozitorijPaketa.GetCijenaPaketa(id);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pretrazeniTekst = pretragaPaketatextBox.Text.ToLower();
            List<Paket> filtriraniPaketi = RepozitorijPaketa.GetPaketi().Where(p => p.ImePaketa.ToLower().Contains(pretrazeniTekst)).ToList();
            prikazPaketadataGridView.DataSource = filtriraniPaketi.Select(p => new { p.ID, p.ImePaketa }).ToList();
        }

        private void odaberiPaketButton_Click(object sender, EventArgs e)
        {
            if (prikazPaketadataGridView.SelectedRows.Count > 0)
            {
                int id = (int)prikazPaketadataGridView.SelectedRows[0].Cells["ID"].Value;
                DetaljiPaketa detaljiPaketa = new DetaljiPaketa(id);
                detaljiPaketa.Show();
                this.Hide();
            }
        }

        private void nazadLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => NavigacijaPocetniOdabir();
        private void odjavaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Application.Exit();
        private void pomocPictureBox_MouseHover(object sender, EventArgs e) =>
            Tooltip.ShowTooltip(pomocPictureBox, "Ovdje možeš pregledati sve trenutno dostupne pakete, izvršiti pretragu prema imenu te odabrati jedan od ponuđenih i nastaviti na njegovo uređivanje.");
        private void pomocPictureBox_MouseLeave(object sender, EventArgs e) => Tooltip.HideTooltip(pomocPictureBox);
    }
}