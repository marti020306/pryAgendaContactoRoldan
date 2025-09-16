namespace pryAgendaContactoRoldan
{
    partial class frmContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            mrgContactos = new GroupBox();
            lblContacto = new Label();
            cmdAtras = new Button();
            cmdSiguiente = new Button();
            mrgContactos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(69, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(308, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agenda De Contactos";
            // 
            // mrgContactos
            // 
            mrgContactos.Controls.Add(lblContacto);
            mrgContactos.Location = new Point(30, 124);
            mrgContactos.Name = "mrgContactos";
            mrgContactos.Size = new Size(381, 125);
            mrgContactos.TabIndex = 1;
            mrgContactos.TabStop = false;
            mrgContactos.Text = "Contactos";
            mrgContactos.Enter += mrgContactos_Enter;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(140, 59);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(0, 20);
            lblContacto.TabIndex = 2;
            // 
            // cmdAtras
            // 
            cmdAtras.Location = new Point(47, 300);
            cmdAtras.Name = "cmdAtras";
            cmdAtras.Size = new Size(94, 29);
            cmdAtras.TabIndex = 3;
            cmdAtras.Text = "Atrás";
            cmdAtras.UseVisualStyleBackColor = true;
            cmdAtras.Click += cmdAtras_Click;
            // 
            // cmdSiguiente
            // 
            cmdSiguiente.Location = new Point(263, 300);
            cmdSiguiente.Name = "cmdSiguiente";
            cmdSiguiente.Size = new Size(94, 29);
            cmdSiguiente.TabIndex = 4;
            cmdSiguiente.Text = "Siguiente";
            cmdSiguiente.UseVisualStyleBackColor = true;
            cmdSiguiente.Click += cmdSiguiente_Click;
            // 
            // frmContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(cmdSiguiente);
            Controls.Add(cmdAtras);
            Controls.Add(mrgContactos);
            Controls.Add(lblTitulo);
            Name = "frmContacto";
            Text = "Contactos";
            Load += frmContacto_Load;
            mrgContactos.ResumeLayout(false);
            mrgContactos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox mrgContactos;
        private Label lblContacto;
        private Button cmdAtras;
        private Button cmdSiguiente;
    }
}