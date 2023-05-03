using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace wfaaad
{
    class Spectacle
    {
        private int idSp;
        private string TitreSp;
        private string DescSp;
        private float TarifSp;
        private string TempsSp;
        private string ImgSp;
        private int idArt;
      
        //foreach (KeyValuePair<string, string> element in lstEquipChoisi.Items)
        //{
        //      desEquipements.Add(new Equipement(element.Key, element.Value));
        //}

        // private int idPublic;
        //private int idCateg

        public Spectacle(int idSp, string TitreSp, string DescSp, float TarifSp, string TempsSp, string ImgSp, int idArt)
        {
            this.idSp = idSp;
            this.TitreSp = TitreSp;
            this.DescSp = DescSp;
            this.TarifSp = TarifSp;
            this.TempsSp = TempsSp;
            this.ImgSp = ImgSp;
            this.idArt = idArt;
        }


        public int IdArt => idArt;
        public int id
        {
            get
            {
                // accesseur en lecture : getter
                return this.idSp;
            }

        }

        public string titre
        {
            get
            {
                // accesseur en lecture : getter
                return this.TitreSp;
            }
            set
            {
                // accesseur en écriture : setter
                this.TitreSp = value;
            }
        }
        public string Description
        {
            get
            {
                // accesseur en lecture : getter
                return this.DescSp;
            }
            set
            {
                // accesseur en écriture : setter
                this.DescSp = value;
            }
        }

        public float Tarif
        {
            get
            {
                // accesseur en lecture : getter
                return this.TarifSp;
            }

        }
        public string Temps
        {
            get
            {
                // accesseur en lecture : getter
                return this.TempsSp;
            }

        }
        public string Image
        {
            get
            {
                // accesseur en lecture : getter
                return this.ImgSp;
            }
            set
            {
                // accesseur en écriture : setter
                this.ImgSp = value;
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
                cmdInsert.CommandText = "INSERT_SPECTACLE"; // Nom de la procédure stockée


                //Paramètre en entrée de la procédure stockée
                cmdInsert.Parameters.Add(new MySqlParameter("Titre", this.TitreSp));
                cmdInsert.Parameters.Add(new MySqlParameter("Description", this.DescSp));
                cmdInsert.Parameters.Add(new MySqlParameter("Tarif", this.TarifSp));
                cmdInsert.Parameters.Add(new MySqlParameter("Temps", this.TempsSp));
                cmdInsert.Parameters.Add(new MySqlParameter("Image", this.ImgSp));
              //  cmdInsert.Parameters.Add(new MySqlParameter("idArt", this.idArt));
                //Paramètre en sortie de la procédure stockée
                MySqlParameter P = new MySqlParameter("newId", MySqlDbType.Int16);
                P.Direction = System.Data.ParameterDirection.Output;
                cmdInsert.Parameters.Add(P);

                cmdInsert.ExecuteNonQuery();

                //  Console.WriteLine(P.Value.ToString());

                this.idSp = int.Parse(P.Value.ToString());

                cnxaad.Close();
                Program.lesSpectacles.Add(this);
            }
        }

    }
}
    


