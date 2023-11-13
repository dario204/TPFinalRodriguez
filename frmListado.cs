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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            //PopulateDirectory();
            InitializeComponent();
            // Establece la ruta de la carpeta raíz que deseas explorar. (esta en bin/debug que es el lugar por defecto q levanta el proyecto)
            String rootFolderPath = "EMPLEO.accdb";

            // Llama a la función para llenar el TreeView.
            //PopulateTreeView(tvArchivos, rootFolderPath);
        }
        clsAccesoBD Conectar = new clsAccesoBD();
        private void frmListado_Load(object sender, EventArgs e)
        {
            Conectar.CargaEmpleado(cboCodigoEmpleado);
        }
       
        private void tvArchivos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Verifica si el nodo seleccionado tiene una ruta de archivo adjunta.
            //if (e.Node.Tag is string filePath)
            {
                //    if (File.Exists(filePath) && filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // try
                    {
                        // Lee el contenido del archivo de texto y muéstralo.
                        //          string fileContent = File.ReadAllText(filePath);

                        // Puedes mostrar el contenido en un control TextBox o RichTextBox, por ejemplo.
                        //        rtbContenido.Text = fileContent;
                        //   }
                        //    catch (IOException ex)
                        //  {
                        //  MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
            }
        }
    }
}
