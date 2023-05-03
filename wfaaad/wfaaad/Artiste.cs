using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace wfaaad
{
    class Artiste
    {
    private int idArt;
    private string nomArt;
    private string prenomArt;
    private string descArt;
    private string imgArt;
    private string telArt;
    private string mailArt;
    private string loginArt;
    private string mdpArt;


        public Artiste(int idArt, string nomArt, string prenomArt, string descArt, string imgArt, string telArt, string mailArt)
        {
            this.idArt = idArt;
            this.nomArt = nomArt;
            this.prenomArt = prenomArt;
            this.descArt = descArt;
            this.imgArt = imgArt;
            this.telArt = telArt;
            this.mailArt = mailArt;
        }

        public int GetId()
        {
            return this.idArt;
        }
        public string mail
        {
            get
            {
                // accesseur en lecture : getter
                return this.mailArt;
            }
            set
            {
                // accesseur en écriture : setter
                this.mailArt = value;
            }
        }
        public string tel
        {
            get
            {
                // accesseur en lecture : getter
                return this.telArt;
            }
            set
            {
                // accesseur en écriture : setter
                this.telArt = value;
            }
        }
        public string img
        {
            get
            {
                // accesseur en lecture : getter
                return this.imgArt;
            }
            set
            {
                // accesseur en écriture : setter
                this.imgArt = value;
            }
        }

        public string desc
        {
            get
            {
                // accesseur en lecture : getter
                return this.descArt;
            }
            set
            {
                // accesseur en écriture : setter
                this.descArt = value;
            }
        }
        public string prenom
        {
            get
            {
                // accesseur en lecture : getter
                return this.prenomArt;
            }
            set
            {
                // accesseur en écriture : setter
                this.prenomArt = value;
            }
        }
        public string nom
    {
        get
        {
            // accesseur en lecture : getter
            return this.nomArt;
        }
        set
        {
            // accesseur en écriture : setter
            this.nomArt = value;
        }
    }

    public int id
    {
        get
        {
            // accesseur en lecture : getter
            return this.idArt;
        }
        set
        {
            // accesseur en écriture : setter

        }
    }


        /// <summary>
        /// méthode publique permettant l'enregistrement en BDD
        /// et l'ajout dans la liste lesArtistes
        /// </summary>
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
                cmdInsert.CommandText = "INSERT_ARTISTE"; // Nom de la procédure stockée


                //Paramètre en entrée de la procédure stockée
                cmdInsert.Parameters.Add(new MySqlParameter("nom", this.nomArt));
                cmdInsert.Parameters.Add(new MySqlParameter("prenom", this.prenomArt));
                cmdInsert.Parameters.Add(new MySqlParameter("description", this.descArt));
                cmdInsert.Parameters.Add(new MySqlParameter("image", this.imgArt));
                cmdInsert.Parameters.Add(new MySqlParameter("telephone", this.telArt));
                cmdInsert.Parameters.Add(new MySqlParameter("mail", this.mailArt));

                //Paramètre en sortie de la procédure stockée
                MySqlParameter P = new MySqlParameter("newId", MySqlDbType.Int16);
                P.Direction = System.Data.ParameterDirection.Output;
                cmdInsert.Parameters.Add(P);

                cmdInsert.ExecuteNonQuery();

                //  Console.WriteLine(P.Value.ToString());

                this.idArt = int.Parse(P.Value.ToString());

                cnxaad.Close();
                Program.lesArtistes.Add(this);
            }
        }
         public void modifier()
        {
            using (MySqlConnection cnxaad = new MySqlConnection(wfaaad.Properties.Resources.Connexionaad))
            {
                cnxaad.Open();
                string strRequete = "UPDATE artiste SET nomArt = @nom, prenomArt = @prenom, descArt = @description, imgArt = @image, telArt = @telephone, mailArt = @mail WHERE idArt = @id;";
                // gestion des paramètres
                MySqlParameter paramId = new MySqlParameter();
                paramId.ParameterName = "id";
                paramId.Value = this.idArt;

                MySqlParameter paramNom = new MySqlParameter();
                paramNom.ParameterName = "nom";
                paramNom.Value = this.nom;

                MySqlParameter paramPrenom = new MySqlParameter();
                paramPrenom.ParameterName = "prenom";
                paramPrenom.Value = this.prenomArt;

                MySqlParameter paramDesc = new MySqlParameter();
                paramDesc.ParameterName = "description";
                paramDesc.Value = this.descArt;

            
                MySqlParameter paramImage = new MySqlParameter();
                paramImage.ParameterName = "image";
                paramImage.Value = this.imgArt;

                MySqlParameter paramTelephone = new MySqlParameter();
                paramTelephone.ParameterName = "telephone";
                paramTelephone.Value = this.telArt;

                MySqlParameter paramMail = new MySqlParameter();
                paramMail.ParameterName = "mail";
                paramMail.Value = this.mailArt;

                MySqlCommand cmdUpdate = new MySqlCommand(strRequete, cnxaad);

                cmdUpdate.Parameters.Add(paramId);
                cmdUpdate.Parameters.Add(paramNom);
                cmdUpdate.Parameters.Add(paramPrenom);
                cmdUpdate.Parameters.Add(paramDesc);
                cmdUpdate.Parameters.Add(paramImage);
                cmdUpdate.Parameters.Add(paramTelephone);
                cmdUpdate.Parameters.Add(paramMail);

                cmdUpdate.ExecuteNonQuery();
                cnxaad.Close();
            }
        }

         public void supprimer()
         {
             using (MySqlConnection cnxaad = new MySqlConnection(wfaaad.Properties.Resources.Connexionaad))
            {
                cnxaad.Open();
                string strRequete = "DELETE FROM artiste WHERE idArt = " + id;
                MySqlCommand cmd = new MySqlCommand(strRequete, cnxaad);
                cmd.ExecuteNonQuery();
                cnxaad.Close();
            }
         }
            
        }

       
    }
