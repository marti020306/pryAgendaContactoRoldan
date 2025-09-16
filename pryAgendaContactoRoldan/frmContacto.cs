using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaContactoRoldan
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }
        string[] vecNombre = new string[3];
        int indice = 0;
        private void frmContacto_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Guadalupe";
            vecNombre[1] = "Sofia";
            vecNombre[2] = "Leo";
            lblContacto.Text = vecNombre[0];
        }

        private void mrgContactos_Enter(object sender, EventArgs e)
        {

        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            lblContacto.Text = vecNombre[indice];
            if (vecNombre.Length <= (indice + 1))
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblContacto.Text = vecNombre[indice];

            //if (vecNombre.Length >= 0)
            //{
             //   cmdAtras.Enabled = false;
            //}

        }
    }
}
