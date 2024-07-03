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
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void PrikazPaketa()
        {
            List<Paket> paketi = RepozitorijPaketa.GetPaketi();
            dataGridView1.DataSource = paketi.Select(p => new { p.ID, p.ImePaketa }).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                string opisPaketa = RepozitorijPaketa.GetOpisPaketa(id);
                string napomenaPaketa = RepozitorijPaketa.GetNapomenaPaketa(id);
                string cijenaPaketa = RepozitorijPaketa.GetCijenaPaketa(id);

                richTextBox1.Text = opisPaketa;
                richTextBox2.Text = napomenaPaketa;
                richTextBox3.Text = cijenaPaketa;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pretrazeniTekst = textBox1.Text.ToLower(); // Uzmite tekst iz TextBox-a i pretvorite u mala slova

            // Filtrirajte listu paketa prema unesenom tekstu
            List<Paket> filtriraniPaketi = RepozitorijPaketa.GetPaketi().Where(p => p.ImePaketa.ToLower().Contains(pretrazeniTekst)).ToList();

            // Ažurirajte DataSource DataGridView-a s filtriranim paketima
            dataGridView1.DataSource = filtriraniPaketi.Select(p => new { p.ID, p.ImePaketa }).ToList();
        }
    }
}