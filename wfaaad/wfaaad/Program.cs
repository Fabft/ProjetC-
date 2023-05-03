using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace wfaaad
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        // variable globale contenant toutes les Artistes
        public static List<Artiste> lesArtistes;
        public static List<Spectacle> lesSpectacles;
        public static List<Contact> lesContacts;
        public static int idSelectedArtiste;
        public static int artChoisi = 0;
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (MySqlConnection cnxaad = new MySqlConnection(wfaaad.Properties.Resources.Connexionaad))
            {
                cnxaad.Open();

               

                // Collection d'artiste
                string strRequeteSelect = "SELECT idArt, nomArt, prenomArt , descArt, imgArt, telArt, mailArt FROM artiste";

                MySqlCommand cmd = new MySqlCommand(strRequeteSelect, cnxaad);
                MySqlDataReader jeuEnr = cmd.ExecuteReader();

                Program.lesArtistes = new List<Artiste>();



                while (jeuEnr.Read())
                {
                    int idArt = int.Parse(jeuEnr[0].ToString());
                    string nomArt = jeuEnr[1].ToString();
                    string prenomArt = jeuEnr[2].ToString();
                    string descArt = jeuEnr[3].ToString();
                    string imgArt = jeuEnr[4].ToString();
                    string telArt = jeuEnr[5].ToString();
                    string mailArt = jeuEnr[6].ToString();


                    Program.lesArtistes.Add(new Artiste(idArt, nomArt, prenomArt, descArt, imgArt, telArt, mailArt));
                }

                jeuEnr.Close();

                strRequeteSelect = "SELECT idSp, TitreSp, DescSp,TarifSp, TempsSp, ImgSp, idArt FROM spectacle";

                cmd = new MySqlCommand(strRequeteSelect, cnxaad);
                jeuEnr = cmd.ExecuteReader();

                Program.lesSpectacles = new List<Spectacle>();

                while (jeuEnr.Read())
                {
                    int idSp = int.Parse(jeuEnr[0].ToString());
                    string TitreSp = jeuEnr[1].ToString();
                    string DescSp = jeuEnr[2].ToString();
                    int TarifSp = int.Parse(jeuEnr[3].ToString());
                    string TempsSp = jeuEnr[4].ToString();
                    string ImgSp = jeuEnr[5].ToString();
                    string idArt = jeuEnr[6].ToString();
                    


                    Program.lesSpectacles.Add(new Spectacle(idSp, TitreSp, DescSp, TarifSp, TempsSp, ImgSp, int.Parse(idArt)));// idArt));

                }
                jeuEnr.Close();

                strRequeteSelect = "SELECT idContact, PrenomContact , NomContact, emailContact, ObjetContact, MessageContact FROM contact";

                cmd = new MySqlCommand(strRequeteSelect, cnxaad);
                jeuEnr = cmd.ExecuteReader();

                Program.lesContacts = new List<Contact>();

                while (jeuEnr.Read())
                {
                    int idContact = int.Parse(jeuEnr[0].ToString());
                    string PrenomContact = jeuEnr[1].ToString();
                    string NomContact = jeuEnr[2].ToString();
                    string EmailContact = jeuEnr[3].ToString();
                    string ObjetContact = jeuEnr[4].ToString();
                    string MessageContact = jeuEnr[5].ToString();


                    Program.lesContacts.Add(new Contact(idContact, PrenomContact, NomContact, EmailContact, ObjetContact, MessageContact));

                }
                jeuEnr.Close();
            }
            Application.Run(new FormAccueil());
            }

        }

    }

