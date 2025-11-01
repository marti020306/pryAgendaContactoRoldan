namespace pryAgendaContactoRoldan
{
    partial class frmAgendaContacto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaContacto));
            lblAgendaContacto = new Label();
            lblContacto = new Label();
            lblNumero = new Label();
            mtbNumero = new MaskedTextBox();
            cmdCancelar = new Button();
            cmdRegistrar = new Button();
            txtcontacto = new TextBox();
            lstbContacto = new ListBox();
            lblCantContactos = new Label();
            lblFechaHora = new Label();
            cmdAgenda = new Button();
            SuspendLayout();
            // 
            // lblAgendaContacto
            // 
            lblAgendaContacto.AutoSize = true;
            lblAgendaContacto.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgendaContacto.Location = new Point(96, 31);
            lblAgendaContacto.Name = "lblAgendaContacto";
            lblAgendaContacto.Size = new Size(400, 32);
            lblAgendaContacto.TabIndex = 0;
            lblAgendaContacto.Text = "Gestion Agenda de Contacto";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(57, 129);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(94, 23);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(57, 228);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(85, 23);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(193, 228);
            mtbNumero.Margin = new Padding(3, 4, 3, 4);
            mtbNumero.Mask = "(351)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(135, 27);
            mtbNumero.TabIndex = 3;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(59, 351);
            cmdCancelar.Margin = new Padding(3, 4, 3, 4);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(92, 39);
            cmdCancelar.TabIndex = 4;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdRegistrar.Location = new Point(312, 351);
            cmdRegistrar.Margin = new Padding(3, 4, 3, 4);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(99, 39);
            cmdRegistrar.TabIndex = 5;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // txtcontacto
            // 
            txtcontacto.Location = new Point(193, 129);
            txtcontacto.Margin = new Padding(3, 4, 3, 4);
            txtcontacto.Name = "txtcontacto";
            txtcontacto.Size = new Size(135, 27);
            txtcontacto.TabIndex = 6;
            txtcontacto.TextChanged += txtcontacto_TextChanged;
            txtcontacto.KeyPress += txtcontacto_KeyPress_1;
            // 
            // lstbContacto
            // 
            lstbContacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbContacto.ForeColor = SystemColors.ControlText;
            lstbContacto.FormattingEnabled = true;
            lstbContacto.Location = new Point(59, 439);
            lstbContacto.Margin = new Padding(3, 4, 3, 4);
            lstbContacto.Name = "lstbContacto";
            lstbContacto.Size = new Size(381, 124);
            lstbContacto.TabIndex = 7;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.Location = new Point(34, 660);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(160, 20);
            lblCantContactos.TabIndex = 8;
            lblCantContactos.Text = "Cantidad de Contactos";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(362, 660);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(86, 20);
            lblFechaHora.TabIndex = 9;
            lblFechaHora.Text = "Fecha-Hora";
            // 
            // cmdAgenda
            // 
            cmdAgenda.Location = new Point(209, 597);
            cmdAgenda.Name = "cmdAgenda";
            cmdAgenda.Size = new Size(94, 36);
            cmdAgenda.TabIndex = 10;
            cmdAgenda.Text = "Ver Agenda";
            cmdAgenda.UseVisualStyleBackColor = true;
            cmdAgenda.Click += cmdAgenda_Click;
            // 
            // frmAgendaContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 763);
            Controls.Add(cmdAgenda);
            Controls.Add(lblFechaHora);
            Controls.Add(lblCantContactos);
            Controls.Add(lstbContacto);
            Controls.Add(txtcontacto);
            Controls.Add(cmdRegistrar);
            Controls.Add(cmdCancelar);
            Controls.Add(mtbNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Controls.Add(lblAgendaContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgendaContacto";
            Text = "Agenda de Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgendaContacto;
        private Label lblContacto;
        private Label lblNumero;
        private MaskedTextBox mtbNumero;
        private Button cmdCancelar;
        private Button cmdRegistrar;
        private TextBox txtcontacto;
        private ListBox lstbContacto;
        private Label lblCantContactos;
        private Label lblFechaHora;
        private Button cmdAgenda;
    }
}
