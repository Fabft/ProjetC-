using System;
using System.Windows.Forms;

namespace wfaaad
{
    public partial class FormModifArtiste : Form
    {
        private int artiste;
        
        public FormModifArtiste()
        {
            InitializeComponent();
        }

        private void FormModifArtiste_Load(object sender, EventArgs e)
        {
            foreach (Artiste art in Program.lesArtistes)
            {
                if (art.id == Program.artChoisi)
                {
                    artiste = art.id;
                    
                    Program.artChoisi = 0;
                    txtPrenomArt.Text = art.prenom;
                    txtNomArt.Text = art.nom;
                    txtDescArt.Text = art.desc;
                    txtImgArt.Text = art.img;
                    txtMailArt.Text = art.mail;
                    txtTelArt.Text = art.tel;
                }
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            foreach (Artiste art in Program.lesArtistes)
            {
                if (art.id == artiste)
                {
                    art.prenom = txtPrenomArt.Text;
                    art.nom = txtNomArt.Text;
                    art.desc = txtDescArt.Text;
                    art.img = txtImgArt.Text;
                    art.mail = txtMailArt.Text;
                    art.tel = txtTelArt.Text;
                    
                    art.modifier();
                    FormArtiste formArtiste = new FormArtiste();
                    formArtiste.Show();
                }
            }
        }
    }
}