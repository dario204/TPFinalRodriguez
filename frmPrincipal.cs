using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalRodriguez
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        clsAccesoBD objAcceso = new clsAccesoBD();
        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBD();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado Listado = new frmListado();
            Listado.ShowDialog();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {

        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            DateTime fechayHoraActual = DateTime.Now;

            //Hora.Text = fechayHoraActual.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado Listado = new frmListado();
            Listado.ShowDialog();
        }
    }
}
