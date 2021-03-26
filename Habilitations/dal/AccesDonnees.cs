using Habilitations.connexion;
using Habilitations.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations.dal
{
    public class AccesDonnees
    {
        // private static string connectionString = "user id=habilitations;server=localhost;persistsecurityinfo=True;database=habilitations";
        private static string connectionString = "server=192.168.1.95;user id=habilitations;password=motdepasseuser;database=habilitations;SslMode=none";

        public static List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            string req = "SELECT d.iddeveloppeur as iddeveloppeur, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail, p.idprofil as idprofil, p.nom as profil ";
            req += "FROM developpeur AS d JOIN profil AS p ON(d.idprofil = p.idprofil) ORDER BY nom, prenom";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                Developpeur developpeur = new Developpeur((int)curseur.Field("iddeveloppeur"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"), (int)curseur.Field("idprofil"), (string)curseur.Field("profil"));
                lesDeveloppeurs.Add(developpeur);
            }
            curseur.Close();
            return lesDeveloppeurs;

        }

        public static List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();
            string req = "SELECT * FROM profil ORDER BY nom";
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req);
            while(curseur.Read())
            {
                Profil profil = new Profil((int)curseur.Field("idprofil"), (string)curseur.Field("nom"));
                lesProfils.Add(profil);
            }
            curseur.Close();
            return lesProfils;
        }

        public static void DelDeveloppeur(Developpeur developpeur)
        {
            string req = "delete from developpeur where iddeveloppeur = @iddeveloppeur;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.IdDeveloppeur);
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parameters);
            connexion.Close();
        }

        public static void AddDeveloppeur(Developpeur developpeur)
        {
            string req = "insert into developpeur(nom, prenom, tel, mail, pwd, idprofil) ";
            req += "values (@nom, @prenom, @tel, @mail, @pwd, @idprofil);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", developpeur.Nom);
            parameters.Add("@prenom", developpeur.Prenom);
            parameters.Add("@tel", developpeur.Tel);
            parameters.Add("@mail", developpeur.Mail);
            parameters.Add("@pwd", GetStringSha256Hash(developpeur.Nom));
            parameters.Add("@idprofil", developpeur.IdProfil);
            ConnexionBDD conn = ConnexionBDD.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        public static void UpdateDeveloppeur(Developpeur developpeur)
        {
            string req = "update developpeur set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idprofil = @idprofil where iddeveloppeur = @iddeveloppeur;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@iddeveloppeur", developpeur.IdDeveloppeur);
            parameters.Add("@nom", developpeur.Nom);
            parameters.Add("@prenom", developpeur.Prenom);
            parameters.Add("@tel", developpeur.Tel);
            parameters.Add("@mail", developpeur.Mail);
            parameters.Add("@idprofil", developpeur.IdProfil);
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        public static void UpdatePwd(Developpeur developpeur)
        {
            string req = "update developpeur set pwd = @pwd where iddeveloppeur = @iddeveloppeur";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("iddeveloppeur", developpeur.IdDeveloppeur);
            parameters.Add("@pwd", GetStringSha256Hash(developpeur.Pwd));
            ConnexionBDD connection = ConnexionBDD.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
