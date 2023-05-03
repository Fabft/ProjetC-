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
    public partial class FormUnArtiste : Form
    {
        public FormUnArtiste()
        {
            InitializeComponent();
        }
        Artiste lArtisteChoisie;
        private void button1_Click(object sender, EventArgs e)
        {
            

            string nomArt = txtNomArt.Text;
            string prenomArt = txtPrenomArt.Text;
            string descArt =  txtDescArt.Text;
            string imgArt = txtImgArt.Text;
            string telArt = txtTelArt.Text;
            string mailArt = txtMailArt.Text;

            Artiste artiste = new Artiste(0, nomArt, prenomArt, descArt, imgArt, telArt, mailArt);
            artiste.enregistrer();

            FormArtiste formArtiste = new FormArtiste();
            formArtiste.Show();

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUnArtiste_Load(object sender, EventArgs e)
        {
            
        

            }
        }
    }

