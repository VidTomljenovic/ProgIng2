using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBLayer;
using PI_zadaca3.Modules;
using PI_zadaca3.Repositories;

namespace PI_zadaca3
{
    public partial class StvaranjePaketa : Form
    {
        public StvaranjePaketa()
        {
            InitializeComponent();
            pomocPictureBox.MouseHover += pomocPictureBox_MouseHover;
            pomocPictureBox.MouseLeave += pomocPictureBox_MouseLeave;
        }

        private void nazadLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigacijaPocetniOdabir();
        }

        private void stvoriPaketGumb_Click(object sender, EventArgs e)
        {
            string imePaketa = imePaketaTxt.Text;
            string opisPaketa = opisPaketaRichTextBox.Text;
            string cijenaPaketaText = cijenaPaketaTxt.Text;
            string napomenaPaketa = napomenaPaketaRichTextBox.Text;

            if (string.IsNullOrEmpty(imePaketa) || string.IsNullOrEmpty(opisPaketa) || string.IsNullOrEmpty(cijenaPaketaText))
            {
                MessageBox.Show("Molimo unesite sve obavezne podatke!");
                return;
            }

            if (!int.TryParse(cijenaPaketaText, out int cijenaPaketa))
            {
                MessageBox.Show("Molimo unesite ispravnu cijenu.");
                return;
            }

            Paket noviPaket = new Paket
            {
                ImePaketa = imePaketa,
                OpisPaketa = opisPaketa,
                CijenaPaketa = cijenaPaketa,
                NapomenaPaketa = napomenaPaketa
            };

            DodajPaket(noviPaket);
        }

        public void DodajPaket(Paket paket)
        {
            string sql = "INSERT INTO PaketUsluga (ImePaketa, OpisPaketa, CijenaPaketa, NapomenaPaketa) " +
                         "VALUES (@ImePaketa, @OpisPaketa, @CijenaPaketa, @NapomenaPaketa)";

            string connectionString = Conn.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ImePaketa", paket.ImePaketa);
                command.Parameters.AddWithValue("@OpisPaketa", paket.OpisPaketa);
                command.Parameters.AddWithValue("@CijenaPaketa", paket.CijenaPaketa);
                command.Parameters.AddWithValue("@NapomenaPaketa", paket.NapomenaPaketa);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Paket uspješno dodan!");
        }

        private void odjavaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void NavigacijaPocetniOdabir()
        {
            PocetniOdabir pocetniOdabir = new PocetniOdabir();
            pocetniOdabir.Show();
            this.Hide();
        }
        private void pomocPictureBox_MouseHover(object sender, EventArgs e)
        {
            Tooltip.ShowTooltip(pomocPictureBox, "Ovdje možeš izraditi poptuno novi paket usluga. Pripazi, obavezna polja označena su *, a cijena paketa izražena je u valuti EUR, cijeli broj.");
        }

        private void pomocPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Tooltip.HideTooltip(pomocPictureBox);
        }
    }
}
