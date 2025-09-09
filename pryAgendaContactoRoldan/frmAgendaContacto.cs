namespace pryAgendaContactoRoldan
{
    public partial class frmAgendaContacto : Form
    {
        public frmAgendaContacto()
        {
            InitializeComponent();
        }
        // Definir variables globales

        string vContacto = "";
        string vNumero = "";
        int vCantContactos = 0;
        DateTime vFecha = DateTime.Now;

        //Declarar vectores 
        string[] vecTelofono = new string[5];
        String[] vecContacto = new string[5];

        //indice
        int Indice = 0;


        private void txtcontacto_TextChanged(object sender, EventArgs e)
        {
            if (txtcontacto.TextLength > 0)
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            vecContacto[Indice] = txtcontacto.Text;
            vecTelofono[Indice] = mtbNumero.Text;
      
            lstbContacto.Items.Add("Contacto:" + " " + vecContacto[Indice] + " - " + "Numero:" + " " + vecTelofono[Indice]);
            vCantContactos = vCantContactos + 1;
            lblCantContactos.Text = "Cantidad de Contactos:" + " " + vCantContactos;
            lblFechaHora.Text = "Fecha y Hora:" + " " + vFecha;
            txtcontacto.Focus();
           
            Indice++;
            LimpiarControles();
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.MaskFull) //fijarse en la compu si anda con == True
            {
                cmdRegistrar.Enabled = true;
            }

            else
            {
                cmdRegistrar.Enabled = false;
            }
        }

        private void mtbNumero_MaskChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            txtcontacto.Clear();
            mtbNumero.Clear();
            txtcontacto.Focus();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void lstbContacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    