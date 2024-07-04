using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBLayer;
using PI_zadaca3.Modules;
using PI_zadaca3.Repositories;

namespace PI_zadaca3
{
    public partial class StvaranjePaketa : Form
    {
        void NavigacijaPocetniOdabir()
        {
            PocetniOdabir pocetniOdabir = new PocetniOdabir();
            pocetniOdabir.Show();
            this.Hide();
        }
        public StvaranjePaketa()
        {
            InitializeComponent();
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
                return; // Prekini izvršavanje funkcije ako nisu uneseni svi podaci
            }

            if (!int.TryParse(cijenaPaketaText, out int cijenaPaketa))
            {
                MessageBox.Show("Molimo unesite ispravnu cijenu.");
                return; // Prekini izvršavanje funkcije ako cijena nije ispravno unesena
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
        public static void DodajPaket(Paket paket)
        {
            string sql = "INSERT INTO PaketUsluga (ImePaketa, OpisPaketa, CijenaPaketa, NapomenaPaketa) " +
                         "VALUES (@ImePaketa, @OpisPaketa, @CijenaPaketa, @NapomenaPaketa)";
            //Conn connectionString = new Conn();
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
        }
    }

