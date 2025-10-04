namespace ClubDeportivo
{
    partial class FrmAfiliadoMensual
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            cboTipo = new ComboBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            dtgvAfiliadoMensual = new DataGridView();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            lblAptoF = new Label();
            chkAptoF = new CheckBox();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            NrodeDNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            AptoFisico = new DataGridViewTextBoxColumn();
            IdAfiliado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvAfiliadoMensual).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(132, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(132, 94);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(103, 32);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(91, 138);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(144, 32);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de DNI";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(12, 180);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(223, 32);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Nro de Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(349, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 31);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(349, 183);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(290, 31);
            txtDocumento.TabIndex = 5;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(349, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(290, 31);
            txtApellido.TabIndex = 6;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(349, 141);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(290, 33);
            cboTipo.TabIndex = 7;
            cboTipo.Text = "Elija El Tipo de Documento";
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(791, 65);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(243, 89);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(791, 199);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(243, 89);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtgvAfiliadoMensual
            // 
            dtgvAfiliadoMensual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAfiliadoMensual.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Tipo, NrodeDNI, Telefono, Email, AptoFisico, IdAfiliado });
            dtgvAfiliadoMensual.Location = new Point(31, 389);
            dtgvAfiliadoMensual.Name = "dtgvAfiliadoMensual";
            dtgvAfiliadoMensual.ReadOnly = true;
            dtgvAfiliadoMensual.RowHeadersWidth = 62;
            dtgvAfiliadoMensual.Size = new Size(1214, 114);
            dtgvAfiliadoMensual.TabIndex = 10;
            dtgvAfiliadoMensual.CellContentClick += dtgvAfiliadoMensual_CellContentClick;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(118, 226);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(117, 32);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(147, 277);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 32);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-Mail";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(349, 229);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(290, 31);
            txtTelefono.TabIndex = 13;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(349, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 31);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblAptoF
            // 
            lblAptoF.AutoSize = true;
            lblAptoF.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAptoF.Location = new Point(93, 323);
            lblAptoF.Name = "lblAptoF";
            lblAptoF.Size = new Size(142, 32);
            lblAptoF.TabIndex = 15;
            lblAptoF.Text = "Apto Fisico";
            // 
            // chkAptoF
            // 
            chkAptoF.AutoSize = true;
            chkAptoF.Location = new Point(349, 328);
            chkAptoF.Name = "chkAptoF";
            chkAptoF.Size = new Size(22, 21);
            chkAptoF.TabIndex = 16;
            chkAptoF.UseVisualStyleBackColor = true;
            chkAptoF.CheckedChanged += chkAptoF_CheckedChanged;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 8;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 150;
            // 
            // NrodeDNI
            // 
            NrodeDNI.HeaderText = "Nro. de DNI";
            NrodeDNI.MinimumWidth = 8;
            NrodeDNI.Name = "NrodeDNI";
            NrodeDNI.ReadOnly = true;
            NrodeDNI.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // AptoFisico
            // 
            AptoFisico.HeaderText = "Apto Fisico";
            AptoFisico.MinimumWidth = 8;
            AptoFisico.Name = "AptoFisico";
            AptoFisico.ReadOnly = true;
            AptoFisico.Width = 150;
            // 
            // IdAfiliado
            // 
            IdAfiliado.HeaderText = "IdAfiliado";
            IdAfiliado.MinimumWidth = 8;
            IdAfiliado.Name = "IdAfiliado";
            IdAfiliado.ReadOnly = true;
            // 
            // FrmAfiliadoMensual
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1272, 515);
            Controls.Add(chkAptoF);
            Controls.Add(lblAptoF);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(dtgvAfiliadoMensual);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtApellido);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FrmAfiliadoMensual";
            Text = "AfiliadoMensual";
            Load += FrmAfiliadoMensual_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvAfiliadoMensual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private ComboBox cboTipo;
        private Button btnIngresar;
        private Button btnLimpiar;
        private DataGridView dtgvAfiliadoMensual;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label lblAptoF;
        private CheckBox chkAptoF;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn NrodeDNI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn AptoFisico;
        private DataGridViewTextBoxColumn IdAfiliado;
    }
}