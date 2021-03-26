using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations.modele
{
    public class Developpeur
    {
        private int idDeveloppeur;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string pwd;
        private int idProfil;
        private string profil;

        public Developpeur(int idDeveloppeur, string nom, string prenom, string tel, string mail, int idProfil, string profil)
        {
            this.idDeveloppeur = idDeveloppeur;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idProfil = idProfil;
            this.profil = profil;
        }

        public int IdDeveloppeur { get => idDeveloppeur; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        
        public int IdProfil { get => idProfil; }
        public string Profil { get => profil; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
