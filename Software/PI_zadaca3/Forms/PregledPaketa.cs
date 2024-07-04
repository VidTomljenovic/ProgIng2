using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PI_zadaca3.Modules;
using PI_zadaca3.Repositories;

namespace PI_zadaca3
{
    
    public partial class PregledPaketa : Form
    {
        void NavigacijaPocetniOdabir()
        {
            PocetniOdabir pocetniOdabir = new PocetniOdabir();
            pocetniOdabir.Show();
            this.Hide();
        }

        public PregledPaketa()
        {
            InitializeComponent();
        }

        private void nazadLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigacijaPocetniOdabir();
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

                string opisPaketa = RepozitorijPaketa.GetOpisPaketa(id);
                string napomenaPaketa = RepozitorijPaketa.GetNapomenaPaketa(id);
                string cijenaPaketa = RepozitorijPaketa.GetCijenaPaketa(id);

                opisPaketaRichTextBox.Text = opisPaketa;
                napomenaPaketaRichTextBox.Text = napomenaPaketa;
                cijenaPaketaRichTextBox.Text = cijenaPaketa;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pretrazeniTekst = pretragaPaketatextBox.Text.ToLower(); // Uzmite tekst iz TextBox-a i pretvorite u mala slova

            // Filtrirajte listu paketa prema unesenom tekstu
            List<Paket> filtriraniPaketi = RepozitorijPaketa.GetPaketi().Where(p => p.ImePaketa.ToLower().Contains(pretrazeniTekst)).ToList();

            // Ažurirajte DataSource DataGridView-a s filtriranim paketima
            prikazPaketadataGridView.DataSource = filtriraniPaketi.Select(p => new { p.ID, p.ImePaketa }).ToList();
        }
    }
}