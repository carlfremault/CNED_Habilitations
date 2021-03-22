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
    public partial class FrmHabilitations : Form
    {
        private Controle controle;
        public FrmHabilitations(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
