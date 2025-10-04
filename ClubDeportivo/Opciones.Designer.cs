namespace ClubDeportivo
{
    partial class FrmOpciones
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
            btnAfiliado = new Button();
            btnLista = new Button();
            btnActividad = new Button();
            SuspendLayout();
            // 
            // btnAfiliado
            // 
            btnAfiliado.Location = new Point(93, 53);
            btnAfiliado.Name = "btnAfiliado";
            btnAfiliado.Size = new Size(250, 132);
            btnAfiliado.TabIndex = 0;
            btnAfiliado.Text = "AFILIADO MENSUAL";
            btnAfiliado.UseVisualStyleBackColor = true;
            btnAfiliado.Click += btnAfiliado_Click;
            // 
            // btnLista
            // 
            btnLista.Location = new Point(274, 271);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(250, 132);
            btnLista.TabIndex = 1;
            btnLista.Text = "LISTAR SOCIOS VENCIDOS HOY";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // btnActividad
            // 
            btnActividad.Location = new Point(447, 53);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new Size(250, 132);
            btnActividad.TabIndex = 3;
            btnActividad.Text = "POR ACTIVIDAD";
            btnActividad.UseVisualStyleBackColor = true;
            btnActividad.Click += btnActividad_Click;
            // 
            // FrmOpciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActividad);
            Controls.Add(btnLista);
            Controls.Add(btnAfiliado);
            Name = "FrmOpciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAfiliado;
        private Button btnLista;
        private Button btnActividad;
    }
}