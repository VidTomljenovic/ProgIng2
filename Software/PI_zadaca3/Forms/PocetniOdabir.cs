using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_zadaca3
{

    public partial class PocetniOdabir : Form
    {
        void NavigacijaPregledPaketa() {
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
    }
}
