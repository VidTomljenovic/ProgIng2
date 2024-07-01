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
using PI_zadaca3.Repositories;
using PI_zadaca3.Modules;

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
        }
        private void PrikazPaketa()
        {
            List<Paket> paketi = RepozitorijPaketa.GetPaketi();
            dataGridView1.DataSource = paketi;
        }
    }
}
