using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryAgendaContactoRoldan.frmAgendaContacto;

namespace pryAgendaContactoRoldan
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        int indice = 0;

        private void frmContacto_Load(object sender, EventArgs e)
        {

            if (DatosCompartidos.Cantidad > 0)
            {
                lblContacto.Text = $"{DatosCompartidos.Nombres[0]} - {DatosCompartidos.Numeros[0]}";
                cmdAtras.Enabled = false;


                if (DatosCompartidos.Cantidad == 1)
                {
                    cmdSiguiente.Enabled = false;
                }
            }
            else
            {
                lblContacto.Text = "No hay contactos registrados.";
                cmdAtras.Enabled = false;
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DatosCompartidos.Cantidad - 1)
            {
                indice++;
                lblContacto.Text = $"{DatosCompartidos.Nombres[indice]} - {DatosCompartidos.Numeros[indice]}";
                cmdAtras.Enabled = true;
            }

            if (indice == DatosCompartidos.Cantidad - 1)
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lblContacto.Text = $"{DatosCompartidos.Nombres[indice]} - {DatosCompartidos.Numeros[indice]}";
                cmdSiguiente.Enabled = true;
            }

            if (indice == 0)
            {
                cmdAtras.Enabled = false;
            }
        }

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
