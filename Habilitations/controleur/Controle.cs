using Habilitations.dal;
using Habilitations.modele;
using Habilitations.vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations.controleur
{
    public class Controle
    {
        public Controle()
        {
            FrmHabilitations frmHabilitations = new FrmHabilitations(this);
            frmHabilitations.ShowDialog();
        }

        public List<Developpeur> GetLesDeveloppeurs()
        {
            return AccesDonnees.GetLesDeveloppeurs();
        }

        public List<Profil> GetLesProfils()
        {
            return AccesDonnees.GetLesProfils();
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
            AccesDonnees.DelDeveloppeur(developpeur);
        }

        public void AddDeveloppeur(Developpeur developpeur)
        {
            AccesDonnees.AddDeveloppeur(developpeur);
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            AccesDonnees.UpdateDeveloppeur(developpeur);
        }

        public void UpdatePwd(Developpeur developpeur)
        {
            AccesDonnees.UpdatePwd(developpeur);
        }
    }
}
