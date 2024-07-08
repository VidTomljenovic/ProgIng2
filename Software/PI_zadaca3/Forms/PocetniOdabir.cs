using System;
using System.Windows.Forms;
using PI_zadaca3.Modules;

namespace PI_zadaca3
{
    public partial class PocetniOdabir : Form
    {
        void NavigacijaPregledPaketa()
        {
            PregledPaketa pregledPaketa = new PregledPaketa();
            pregledPaketa.Show();
            this.Hide();
        }

        void NavigacijaStvaranjePaketa()
        {
            StvaranjePaketa stvaranjePaketa = new StvaranjePaketa();
            stvaranjePaketa.Show();
            this.Hide();
        }

        public PocetniOdabir()
        {
            InitializeComponent();
            pomocPictureBox.MouseHover += pomocPictureBox_MouseHover;
            pomocPictureBox.MouseLeave += pomocPictureBox_MouseLeave;
        }

        private void pregledPaketaSlika_Click(object sender, EventArgs e)
        {
            NavigacijaPregledPaketa();
        }

        private void pregledatiPaketeGumb_Click(object sender, EventArgs e)
        {
            NavigacijaPregledPaketa();
        }

        private void noviPaketSlika_Click(object sender, EventArgs e)
        {
            NavigacijaStvaranjePaketa();
        }

        private void stvoritiPaketGumb_Click(object sender, EventArgs e)
        {
            NavigacijaStvaranjePaketa();
        }

        private void odjavaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void pomocPictureBox_MouseHover(object sender, EventArgs e)
        {
            Tooltip.ShowTooltip(pomocPictureBox, "Izaberi želiš li izraditi potpuno novi paket usluga ili pak pregledati postojeće (njih možeš ujedno i urediti ili obrisati.");
        }

        private void pomocPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Tooltip.HideTooltip(pomocPictureBox);
        }
    }
}