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
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void btnAfiliado_Click(object sender, EventArgs e)
        {
            FrmAfiliadoMensual frmAfiliado = new FrmAfiliadoMensual();
            frmAfiliado.Show();
            this.Hide();

        }

        private void btnActividad_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
