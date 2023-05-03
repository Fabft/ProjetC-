using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaaad
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btnLesArtistes_Click(object sender, EventArgs e)
        {
            FormArtiste FormArtiste = new FormArtiste();
            FormArtiste.Show();
        }

        private void btnLesSp_Click(object sender, EventArgs e)
        {
            FormSpectacle FormSpectacle = new FormSpectacle();
            FormSpectacle.Show();
        }

        private void btnLesC_Click(object sender, EventArgs e)
        {
             FormContact FormContact = new FormContact();
            FormContact.Show();
        }
    }
}
    

