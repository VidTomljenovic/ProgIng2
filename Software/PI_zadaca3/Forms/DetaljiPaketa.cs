using System;
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
            pomocPictureBox.MouseHover += pictureBox1_MouseHover;
            pomocPictureBox.MouseLeave += pictureBox1_MouseLeave;
        }

        private void DetaljiPaketa_Load(object sender, EventArgs e)
        {
            Paket paket = RepozitorijPaketa.GetPaket(detaljiPaketaId);
            List<Paket> detaljiPaketa = new List<Paket> { paket };
            detaljiPaketadataGridView.DataSource = detaljiPaketa;
            detaljiPaketadataGridView.Columns["ID"].Visible = false;
            detaljiPaketadataGridView.ReadOnly = false;
            detaljiPaketadataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            detaljiPaketadataGridView.CellClick += detaljiPaketadataGridView_CellClick;
            label1.Text = paket.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izbrisati ovaj paket?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RepozitorijPaketa.DeletePaket(detaljiPaketaId);
                MessageBox.Show("Paket je uspješno obrisan.");
                // Return to PregledPaketa form
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
            // Check if clicked cell is valid and enable editing
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                detaljiPaketadataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                detaljiPaketadataGridView.BeginEdit(true);
            }
        }

        private void spremiPromjeneButton_Click(object sender, EventArgs e)
        {
            var imePaketaCell = detaljiPaketadataGridView.Rows[0].Cells["ImePaketa"];
            if (imePaketaCell.Value == null || string.IsNullOrWhiteSpace(imePaketaCell.Value.ToString()))
            {
                MessageBox.Show("Ime paketa ne smije biti prazno.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string novoImePaketa = imePaketaCell.Value.ToString();

            var opisPaketaCell = detaljiPaketadataGridView.Rows[0].Cells["OpisPaketa"];
            if (opisPaketaCell.Value == null || string.IsNullOrWhiteSpace(opisPaketaCell.Value.ToString()))
            {
                MessageBox.Show("Opis paketa ne smije biti prazan.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string noviOpisPaketa = opisPaketaCell.Value.ToString();

            var napomenaPaketaCell = detaljiPaketadataGridView.Rows[0].Cells["NapomenaPaketa"];
            string novaNapomenaPaketa = napomenaPaketaCell.Value?.ToString();

            var cijenaPaketaCell = detaljiPaketadataGridView.Rows[0].Cells["CijenaPaketa"];
            if (cijenaPaketaCell.Value == null || string.IsNullOrWhiteSpace(cijenaPaketaCell.Value.ToString()))
            {
                MessageBox.Show("Cijena paketa ne smije biti prazna.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int novaCijenaPaketa = Convert.ToInt32(cijenaPaketaCell.Value);

            RepozitorijPaketa.UpdatePaketExceptID(detaljiPaketaId, novoImePaketa, noviOpisPaketa, novaNapomenaPaketa, novaCijenaPaketa);

            MessageBox.Show("Promjene su uspješno spremljene.");

            PregledPaketa pregledPaketaForm = new PregledPaketa();
            pregledPaketaForm.Show();
            this.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Tooltip.ShowTooltip(pomocPictureBox, "Ovdje možeš mijenjati ili obrisati svoj paket!");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Tooltip.HideTooltip(pomocPictureBox);
        }
    }
}