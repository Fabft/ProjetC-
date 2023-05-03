using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace wfaaad
{
    class Contact
    {
        private int idContact;
        private string nomContact;
        private string prenomContact;
        private string emailContact;
        private string objetContact;
        private string messageContact;

        public Contact(int idContact, string nomContact , string prenomContact, string emailContact, string objetContact , string messageContact)
        {
            this.idContact = idContact;
            this.nomContact = nomContact;
            this.prenomContact = prenomContact;
            this.emailContact = emailContact;
            this.objetContact = objetContact;
            this.messageContact = messageContact;
        }
        public int id
        {
            get
            {
                // accesseur en lecture : getter
                return this.idContact;
            }
            set
            {
                // accesseur en écriture : setter

            }
        }

        public string nom
        {
            get
            {
                // accesseur en lecture : getter
                return this.nomContact;
            }
            set
            {
                // accesseur en écriture : setter
                this.nomContact = value;
            }
        }

        public string prenom
        {
            get
            {
                // accesseur en lecture : getter
                return this.prenomContact;
            }
            set
            {
                // accesseur en écriture : setter
                this.prenomContact = value;
            }
        }
        public string email
        {
            get
            {
                // accesseur en lecture : getter
                return this.emailContact;
            }
            set
            {
                // accesseur en écriture : setter
                this.emailContact = value;
            }
        }
        public string objet
        {
            get
            {
                // accesseur en lecture : getter
                return this.objetContact;
            }
            set
            {
                // accesseur en écriture : setter
                this.objetContact = value;
            }
        }
        public string message
        {
            get
            {
                // accesseur en lecture : getter
                return this.messageContact;
            }
            set
            {
                // accesseur en écriture : setter
                this.messageContact = value;
            }
        }

        public void enregistrer()
        {
            using (MySqlConnection cnxaad = new MySqlConnection(wfaaad.Properties.Resources.Connexionaad))
            {
                cnxaad.Open();
                //        string strRequete = "INSERT INTO artiste(nomArt, prenomArt, descArt, imgArt, telArt, MailArt) VALUES('"
                //   + this.nomArt + "', '" + this.prenomArt + "','" + this.descArt + "','" + this.imgArt + "','" + this.telArt + "','" + this.mailArt + "')";

                //        MySqlCommand cmdInsert = new MySqlCommand(strRequete, cnxaad);
                //       cmdInsert.ExecuteNonQuery();

                MySqlCommand cmdInsert = new MySqlCommand(); cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;

                cmdInsert.Connection = cnxaad;
                cmdInsert.CommandText = "INSERT_CONTACT"; // Nom de la procédure stockée


                //Paramètre en entrée de la procédure stockée
                cmdInsert.Parameters.Add(new MySqlParameter("nom", this.nomContact));
                cmdInsert.Parameters.Add(new MySqlParameter("prenom", this.prenomContact));
                cmdInsert.Parameters.Add(new MySqlParameter("email", this.emailContact));
                cmdInsert.Parameters.Add(new MySqlParameter("objet", this.objetContact));
                cmdInsert.Parameters.Add(new MySqlParameter("message", this.messageContact));

                //Paramètre en sortie de la procédure stockée
                MySqlParameter P = new MySqlParameter("newId", MySqlDbType.Int16);
                P.Direction = System.Data.ParameterDirection.Output;
                cmdInsert.Parameters.Add(P);

                cmdInsert.ExecuteNonQuery();

                //  Console.WriteLine(P.Value.ToString());

                this.idContact = int.Parse(P.Value.ToString());

                cnxaad.Close();
                Program.lesContacts.Add(this);
            }
        }

    }
}
