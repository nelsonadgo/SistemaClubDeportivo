namespace ClubDeportivo
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblLogin = new Label();
            lblPass = new Label();
            lbLusuario = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            picClubDep = new PictureBox();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picClubDep).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(345, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(98, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(150, 171);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(165, 32);
            lblPass.TabIndex = 1;
            lblPass.Text = "CONTRASEÑA";
            // 
            // lbLusuario
            // 
            lbLusuario.AutoSize = true;
            lbLusuario.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLusuario.Location = new Point(169, 94);
            lbLusuario.Name = "lbLusuario";
            lbLusuario.Size = new Size(112, 32);
            lbLusuario.TabIndex = 2;
            lbLusuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(402, 97);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(293, 31);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtPass_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(402, 174);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(293, 31);
            txtPass.TabIndex = 4;
            txtPass.Text = "CONTRASEÑA";
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(427, 246);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(215, 78);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // picClubDep
            // 
            picClubDep.Image = (Image)resources.GetObject("picClubDep.Image");
            picClubDep.Location = new Point(146, 233);
            picClubDep.Name = "picClubDep";
            picClubDep.Size = new Size(169, 192);
            picClubDep.SizeMode = PictureBoxSizeMode.Zoom;
            picClubDep.TabIndex = 6;
            picClubDep.TabStop = false;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(427, 347);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(215, 78);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(picClubDep);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lbLusuario);
            Controls.Add(lblPass);
            Controls.Add(lblLogin);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)picClubDep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPass;
        private Label lbLusuario;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private PictureBox picClubDep;
        private Button btnBorrar;
    }
}
