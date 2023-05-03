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
    public partial class FormArtiste : Form
    {

        public FormArtiste()
        {
            InitializeComponent();
        }

        private void FormArtiste_Load(object sender, EventArgs e)
        {
            dgvartiste.ReadOnly = true;
            dgvartiste.ColumnCount = 10;
            dgvartiste.Columns[0].Name = "Identifiant";
            dgvartiste.Columns[1].Name = "Nom";
            dgvartiste.Columns[2].Name = "Prénom";
            dgvartiste.Columns[3].Name = "Description";
            dgvartiste.Columns[4].Name = "Images";
            dgvartiste.Columns[5].Name = "Téléphone";
            dgvartiste.Columns[6].Name = "Email";
            dgvartiste.Columns[7].Name = "Spectacles";
            dgvartiste.Columns[8].Name = "Modifier";
            dgvartiste.Columns[9].Name = "Supprimer";
            dgvartiste.RowHeadersVisible = false;

            foreach (Artiste art in Program.lesArtistes)
            {
                string[] uneLigne = { art.id.ToString(), art.nom, art.prenom, art.desc, art.img, art.tel, art.mail, "Spectacles", "Modifier", "Supprimer" };
                dgvartiste.Rows.Add(uneLigne);

            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FormUnArtiste FormUnArtiste = new FormUnArtiste();
            FormUnArtiste.Show();
            this.Close();
        }

        private void dgvartiste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArt = int.Parse(dgvartiste.Rows[e.RowIndex].Cells[0].Value.ToString());
            switch(e.ColumnIndex)
            {
                case 7 :
                    Program.artChoisi = idArt;
                    FormSpectacle formSpectacle = new FormSpectacle();
                    formSpectacle.Show();
                    Program.artChoisi = 0;
                    break;
                case 8:
                    Program.artChoisi = idArt;
                    FormModifArtiste formModifArtiste = new FormModifArtiste();
                    formModifArtiste.Show();
                    this.Close();
                    break;
                case 9:
                    DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer cet artiste ?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (res == DialogResult.OK)
                    {
                        dgvartiste.Rows.Remove(dgvartiste.Rows[e.RowIndex]);
                        foreach (Artiste art in Program.lesArtistes)
                        {
                            if (art.id == idArt)
                            {
                                Program.lesArtistes.Remove(art);
                                art.supprimer();
                                break;
                            }
                        }
                    }


                    break;
            }
        }

        private void dgvartiste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
