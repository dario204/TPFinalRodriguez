using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPFinalRodriguez
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            clsAccesoBD Listado = new clsAccesoBD();
            Listado.CargaEmpleado(cboCodigoEmpleado);
        }

        private void cboCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
           tvArchivos.Nodes.Clear();

            string codigoSeleccionado = cboCodigoEmpleado.SelectedItem.ToString();

            clsAccesoBD Listado = new clsAccesoBD();
            Listado.LlenarTreeView(codigoSeleccionado, tvArchivos);
        }
    }
}
