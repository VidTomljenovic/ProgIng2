﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PI_zadaca3.Modules;
using PI_zadaca3.Repositories;

namespace PI_zadaca3.Forms
{
    public partial class DetaljiPaketa : Form
    {
        private int detaljiPaketaId;

        public DetaljiPaketa(int id)
        {
            InitializeComponent();
            detaljiPaketaId = id;
        }

        private void DetaljiPaketa_Load(object sender, EventArgs e)
        {
            // Na temelju ID-a dohvatite sve podatke o paketu
            Paket paket = RepozitorijPaketa.GetPaket(detaljiPaketaId); // Pretpostavka: Imate metodu koja dohvaća paket po ID-u

            // Postavite DataSource za DataGridView s podacima o paketu
            List<Paket> detaljiPaketa = new List<Paket> { paket };
            detaljiPaketadataGridView.DataSource = detaljiPaketa;

            // Sakrijte stupac ID
            detaljiPaketadataGridView.Columns["ID"].Visible = false;

            // Omogući uređivanje cijelog DataGridView-a
            detaljiPaketadataGridView.ReadOnly = false;

            // Postavite EditMode na EditOnEnter ili EditProgrammatically
            detaljiPaketadataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

            // Dodajte CellClick event handler za omogućavanje uređivanja
            detaljiPaketadataGridView.CellClick += detaljiPaketadataGridView_CellClick;

            // Postavite labelu tekst na ID paketa
            label1.Text = paket.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izbrisati ovaj paket?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RepozitorijPaketa.DeletePaket(detaljiPaketaId);
                MessageBox.Show("Paket je uspješno obrisan.");
                // Povratak na formu PregledPaketa
                PregledPaketa pregledPaketaForm = new PregledPaketa();
                pregledPaketaForm.Show();
                this.Hide();
            }
        }

        private void nazadLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PregledPaketa pregledPaketaForm = new PregledPaketa();
            pregledPaketaForm.Show();
            this.Hide();
        }

        private void odjavaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void detaljiPaketadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Provjerite je li kliknuta ćelija važeća i omogućite uređivanje
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                detaljiPaketadataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                detaljiPaketadataGridView.BeginEdit(true);
            }
        }

        private void spremiPromjeneButton_Click(object sender, EventArgs e)
        {
            // Dohvati nove vrijednosti koje je korisnik unio
            var imePaketaCell = detaljiPaketadataGridView.Rows[0].Cells["ImePaketa"];
            string novoImePaketa = detaljiPaketadataGridView.Rows[0].Cells["ImePaketa"].Value.ToString();
            if (imePaketaCell.Value == null || string.IsNullOrWhiteSpace(imePaketaCell.Value.ToString()))
            {
                MessageBox.Show("Ime paketa ne smije biti prazno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string noviOpisPaketa = detaljiPaketadataGridView.Rows[0].Cells["OpisPaketa"].Value.ToString();
            string novaNapomenaPaketa = detaljiPaketadataGridView.Rows[0].Cells["NapomenaPaketa"].Value?.ToString(); // Može biti null
            int novaCijenaPaketa = Convert.ToInt32(detaljiPaketadataGridView.Rows[0].Cells["CijenaPaketa"].Value);

            // Ažuriraj podatke u bazi za odabrani paket
            RepozitorijPaketa.UpdatePaketExceptID(detaljiPaketaId, novoImePaketa, noviOpisPaketa, novaNapomenaPaketa, novaCijenaPaketa);

            // Prikaži poruku da su promjene spremljene
            MessageBox.Show("Promjene su uspješno spremljene.");

            // Zatvori trenutnu formu i prikaži formu za pregled paketa
            PregledPaketa pregledPaketaForm = new PregledPaketa();
            pregledPaketaForm.Show();
            this.Hide();
        }
    }
}
