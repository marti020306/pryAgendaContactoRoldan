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
            SuspendLayout();
            // 
            // lblAgendaContacto
            // 
            lblAgendaContacto.AutoSize = true;
            lblAgendaContacto.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgendaContacto.Location = new Point(24, 26);
            lblAgendaContacto.Name = "lblAgendaContacto";
            lblAgendaContacto.Size = new Size(312, 25);
            lblAgendaContacto.TabIndex = 0;
            lblAgendaContacto.Text = "Gestion Agenda de Contacto";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(24, 101);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(77, 18);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(24, 137);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 18);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(143, 137);
            mtbNumero.Mask = "(351)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(119, 23);
            mtbNumero.TabIndex = 1;
            mtbNumero.MaskChanged += mtbNumero_MaskChanged;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(198, 196);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 29);
            cmdCancelar.TabIndex = 3;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Enabled = false;
            cmdRegistrar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdRegistrar.Location = new Point(279, 196);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(81, 29);
            cmdRegistrar.TabIndex = 2;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // txtcontacto
            // 
            txtcontacto.Location = new Point(143, 96);
            txtcontacto.Name = "txtcontacto";
            txtcontacto.Size = new Size(217, 23);
            txtcontacto.TabIndex = 0;
            txtcontacto.TextChanged += txtcontacto_TextChanged;
            // 
            // lstbContacto
            // 
            lstbContacto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbContacto.ForeColor = SystemColors.ControlText;
            lstbContacto.FormattingEnabled = true;
            lstbContacto.ItemHeight = 15;
            lstbContacto.Location = new Point(26, 253);
            lstbContacto.Name = "lstbContacto";
            lstbContacto.Size = new Size(334, 94);
            lstbContacto.TabIndex = 4;
            lstbContacto.SelectedIndexChanged += lstbContacto_SelectedIndexChanged;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.Location = new Point(4, 419);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(128, 15);
            lblCantContactos.TabIndex = 8;
            lblCantContactos.Text = "Cantidad de Contactos";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(291, 419);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(69, 15);
            lblFechaHora.TabIndex = 9;
            lblFechaHora.Text = "Fecha-Hora";
            // 
            // frmAgendaContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 463);
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
            Name = "frmAgendaContacto";
            StartPosition = FormStartPosition.CenterScreen;
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
    }
}
