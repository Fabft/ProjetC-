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
    public partial class FormSpectacle : Form
    {
        public FormSpectacle()
        {
            InitializeComponent();
        }
        private void FormSpectacle_Load(object sender, EventArgs e)
        {
            dgvSp.ColumnCount = 7;
            dgvSp.Columns[0].Name = "Identifiant";
            dgvSp.Columns[1].Name = "Titre";
            dgvSp.Columns[2].Name = "Description";
            dgvSp.Columns[3].Name = "Tarif";
            dgvSp.Columns[4].Name = "Durée";
            dgvSp.Columns[5].Name = "Images";
            dgvSp.Columns[6].Name = "L'artiste";
            dgvSp.RowHeadersVisible = false;

            foreach (Spectacle Sp in Program.lesSpectacles)
            {
                string artisteNom = "";
                foreach (Artiste art in Program.lesArtistes)
                {
                    if (art.id == Sp.IdArt)
                    {
                        artisteNom = art.nom + " " + art.prenom;
                    }
                }
                if (Program.artChoisi != 0)
                {
                    
                    if (Sp.IdArt == Program.artChoisi)
                    {
   
                        string[] uneLigne = { Sp.id.ToString(), Sp.titre, Sp.Description, Sp.Tarif.ToString(), Sp.Temps, Sp.Image, artisteNom };
                                            dgvSp.Rows.Add(uneLigne);
                    }
                    
                }
                else
                {
                    string[] uneLigne = { Sp.id.ToString(), Sp.titre, Sp.Description, Sp.Tarif.ToString(), Sp.Temps, Sp.Image, artisteNom };
                                    dgvSp.Rows.Add(uneLigne);
                }
                

            }
        }
       

        private void dgvSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
    }

