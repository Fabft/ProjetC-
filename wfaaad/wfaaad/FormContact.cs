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
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void FormContact_Load(object sender, EventArgs e)
        {
            dgvCtc.ColumnCount = 6;
            dgvCtc.Columns[0].Name = "Identifiant";
            dgvCtc.Columns[1].Name = "Nom";
            dgvCtc.Columns[2].Name = "Prénom";
            dgvCtc.Columns[3].Name = "Email";
            dgvCtc.Columns[4].Name = "Objet du message";
            dgvCtc.Columns[5].Name = "Message";
            dgvCtc.RowHeadersVisible = false;

            foreach (Contact Ctc in Program.lesContacts)
            {
                string[] uneLigne = { Ctc.id.ToString(), Ctc.nom, Ctc.prenom, Ctc.email, Ctc.objet, Ctc.message };
                dgvCtc.Rows.Add(uneLigne);

            }
        }
    }
   }

