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
    public partial class FormNouvelleArtiste : Form
    {
        public FormNouvelleArtiste()
        {
            InitializeComponent();
        }

        private void FormNouvelleArtiste_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            string nomArt = txtnom.Text;
            string prenomArt = txtprenom.Text;
            string descArt = txtdesc.Text;
            string imgArt = txtimg.Text;
            string telArt = txttel.Text;
            string mailArt = txtmail.Text;

            Artiste unArt = new Artiste(0, nomArt, prenomArt, descArt, nomArt + ".jpg", telArt, mailArt);

            unArt.enregistrer();
            

            FormArtiste FormArtiste = new FormArtiste();
            FormArtiste.Show();
            

            this.Close();
        }

        private void txtimg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
