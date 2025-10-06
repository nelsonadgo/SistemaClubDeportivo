using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmAfiliadoMensual : Form
    {
        int nro;
        public FrmAfiliadoMensual()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string? nombre = txtNombre.Text;
            string? apellido = txtApellido.Text;
            string? tipo = cboTipo.SelectedItem.ToString();
            int documento = int.Parse(txtDocumento.Text);
            int telefono = int.Parse(txtTelefono.Text);
            string? email = txtEmail.Text;
            bool aptoFisico = chkAptoF.Checked;
            Afiliado nuevoAfiliado = new Afiliado
            {
                IdAfiliado = 0,
                Nombre = nombre,
                Apellido = apellido,
                Tipo = tipo,
                Documento = documento,
                Telefono = telefono,
                Email = email,
                AptoFisico = aptoFisico
            };

            int renglon = dtgvAfiliadoMensual.Rows.Add();

            dtgvAfiliadoMensual.Rows[renglon].Cells[0].Value = nuevoAfiliado.Nombre;
            dtgvAfiliadoMensual.Rows[renglon].Cells[1].Value = nuevoAfiliado.Apellido;
            dtgvAfiliadoMensual.Rows[renglon].Cells[2].Value = nuevoAfiliado.Tipo;
            dtgvAfiliadoMensual.Rows[renglon].Cells[3].Value = nuevoAfiliado.Documento;
            dtgvAfiliadoMensual.Rows[renglon].Cells[4].Value = nuevoAfiliado.Telefono;
            dtgvAfiliadoMensual.Rows[renglon].Cells[5].Value = nuevoAfiliado.Email;
            dtgvAfiliadoMensual.Rows[renglon].Cells[6].Value = nuevoAfiliado.AptoFisico ? "Sí" : "No";
            dtgvAfiliadoMensual.Rows[renglon].Cells[7].Value = nuevoAfiliado.IdAfiliado;
            //MessageBox.Show("Afiliado ingresado correctamente.");

            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipo.SelectedIndex = 0;
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            chkAptoF.Checked = false;
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void dtgvAfiliadoMensual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nro = e.RowIndex;
            if (nro != -1)
            {
                MessageBox.Show((string)dtgvAfiliadoMensual.Rows[nro].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("Selecciono el Encabezado");

            }
        }

        private void FrmAfiliadoMensual_Load(object sender, EventArgs e)
        {

        }

        private void chkAptoF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverOpciones_Click(object sender, EventArgs e)
        {
            FrmOpciones frmOpciones = new FrmOpciones();
            frmOpciones.Show();
            this.Hide();
        }
    }
}
