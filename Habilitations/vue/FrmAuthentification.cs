using Habilitations.controleur;
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
    public partial class FrmAuthentification : Form
    {
        private Controle controle;

        public FrmAuthentification(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if( !txtNom.Equals("") && !txtPrenom.Equals("") && !txtMdp.Equals(""))
            {
                if (!controle.verifierAuthentification(txtNom.Text, txtPrenom.Text, txtMdp.Text))
                {
                    MessageBox.Show("Donnes incorrectes, ou habilitation insuffisante", "Information");
                    txtNom.Text = "";
                    txtPrenom.Text = "";
                    txtMdp.Text = "";
                    txtNom.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information");
            }
        }
    }
}
