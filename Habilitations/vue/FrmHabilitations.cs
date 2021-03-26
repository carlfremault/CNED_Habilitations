using Habilitations.controleur;
using Habilitations.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habilitations.vue
{
    public partial class FrmHabilitations : Form
    {
        private Controle controle;

        private Boolean enCoursDeModif = false;

        private BindingSource bdgDeveloppeurs = new BindingSource();

        private BindingSource bdgProfils = new BindingSource();

        public FrmHabilitations(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        public void Init()
        {
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
            grbMdp.Enabled = false;
        }

        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controle.GetLesDeveloppeurs();
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvLesDeveloppeurs.DataSource = bdgDeveloppeurs;
            dgvLesDeveloppeurs.Columns["iddeveloppeur"].Visible = false;
            dgvLesDeveloppeurs.Columns["idprofil"].Visible = false;
            dgvLesDeveloppeurs.Columns["pwd"].Visible = false;
            dgvLesDeveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void RemplirListeProfils()
        {
            List<Profil> lesProfils = controle.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cboProfil.DataSource = bdgProfils;
            if (cboProfil.Items.Count > 0)
            {
                cboProfil.SelectedIndex = 0;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " de la liste?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
            } 
            else
            {
                MessageBox.Show("Selectionnez une ligne", "Information");
            }
        }

        private void btnDevEnregistrer_Click(object sender, EventArgs e)
        {
            /*if(!txtNom.Equals("") && !txtPrenom.Equals("") && !txtTel.Equals("") && !txtMail.Equals("") && cboProfil.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                int idDeveloppeur = 0;
                if (enCoursDeModif)
                {
                    idDeveloppeur = (int)dgvLesDeveloppeurs.SelectedRows[0].Cells["iddeveloppeur"].Value;
                }
                Developpeur developpeur = new Developpeur(idDeveloppeur, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil.IdProfil, profil.Nom);
                if (enCoursDeModif)
                {
                    controle.UpdateDeveloppeur(developpeur);
                    enCoursDeModif = false;
                    grbAjouterModifier.Text = "Ajouter un développeur";
                    grbLesDeveloppeurs.Enabled = true;
                }
                else
                {
                    controle.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                ViderDeveloppeur();

            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis");
            }*/

            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboProfil.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                int iddeveloppeur = 0;
                if (enCoursDeModif)
                {
                    iddeveloppeur = (int)dgvLesDeveloppeurs.SelectedRows[0].Cells["iddeveloppeur"].Value;
                }
                Developpeur developpeur = new Developpeur(iddeveloppeur, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil.IdProfil, profil.Nom);
                if (enCoursDeModif)
                {
                    controle.UpdateDeveloppeur(developpeur);
                    enCoursDeModif = false;
                    grbLesDeveloppeurs.Enabled = true;
                    grbAjouterModifier.Text = "ajouter un développeur";

                }
                else
                {
                    controle.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                ViderDeveloppeur();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void ViderDeveloppeur()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cboProfil.SelectedIndex = 0;
        }

        private void ViderPassword()
        {
            mdp1.Text = "";
            mdp2.Text = "";
            grbLesDeveloppeurs.Enabled = true;
            grbAjouterModifier.Enabled = true;
            grbMdp.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbAjouterModifier.Text = "Modifier un développeur";
                grbLesDeveloppeurs.Enabled = false;
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                cboProfil.SelectedItem = cboProfil.FindStringExact(developpeur.Profil);
            } 
            else
            {
                MessageBox.Show("Selectionnez une ligne", "Information");
            }
        }

        private void btnDevAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderDeveloppeur();
                grbLesDeveloppeurs.Enabled = true;
                enCoursDeModif = false;
                grbAjouterModifier.Text = "ajouter un développeur";
            }
        }

        private void btnChangerPwd_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                grbLesDeveloppeurs.Enabled = false;
                grbAjouterModifier.Enabled = false;
                grbMdp.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selectionnez une ligne", "Information");
            }
        }

        private void btnMdpEnregistrer_Click(object sender, EventArgs e)
        {
            if (!mdp1.Text.Equals("") && !mdp2.Text.Equals("") && mdp1.Text.Equals(mdp2.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = mdp1.Text;
                controle.UpdatePwd(developpeur);
                ViderPassword();
            }
            else
            {
                MessageBox.Show("Les deux champs doivent être remplis et identiques", "Information");
            }
        }

        private void btnMdpAnnuler_Click(object sender, EventArgs e)
        {
           ViderPassword();        
        }
    }
}
