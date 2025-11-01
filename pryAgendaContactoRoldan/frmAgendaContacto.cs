namespace pryAgendaContactoRoldan
{
    public partial class frmAgendaContacto : Form
    {
        public frmAgendaContacto()
        {
            InitializeComponent();
        }

        public static class DatosCompartidos
        {
            public static string[] Nombres = new string[20];
            public static string[] Numeros = new string[20];
            public static int Cantidad = 0;
        }

       
        string vContacto = "";
        string vNumero = "";
        int vCantContactos = 0;
        DateTime vFecha = DateTime.Now;
        private void txtcontacto_TextChanged(object sender, EventArgs e)
        {
            
            mtbNumero.Enabled = txtcontacto.TextLength > 0;
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
           
            cmdRegistrar.Enabled = mtbNumero.MaskFull;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtcontacto.Text;
            vNumero = mtbNumero.Text;

           
            if (DatosCompartidos.Cantidad < DatosCompartidos.Nombres.Length)
            {
                DatosCompartidos.Nombres[DatosCompartidos.Cantidad] = vContacto;
                DatosCompartidos.Numeros[DatosCompartidos.Cantidad] = vNumero;
                DatosCompartidos.Cantidad++;
            }

            lstbContacto.Items.Add($"Contacto: {vContacto} - Número: {vNumero}");

            
            vCantContactos++;
            lblCantContactos.Text = $"Cantidad de Contactos: {vCantContactos}";
            lblFechaHora.Text = $"Fecha y Hora: {vFecha}";

            LimpiarControles();
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

        private void cmdAgenda_Click(object sender, EventArgs e)
        {
           
            frmContacto frmContacto = new frmContacto();
            frmContacto.ShowDialog();
        }

        private void txtcontacto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }


}
    