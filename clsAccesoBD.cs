using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace TPFinalRodriguez
{
    internal class clsAccesoBD
    {
        string rutaArchivo;
        string CadenaConexion;
        string estadoConexion;
        OleDbConnection Conexion;
        OleDbCommand Comando;
        OleDbDataReader Lector;

       
        public clsAccesoBD()
        {
            rutaArchivo = @"../../Base de Datos/BrokerSeguros.accdb";
            CadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
            estadoConexion = "Cerrado";

            ConectarBD();
        }
        public void ConectarBD()
        {

            try
            {
                Conexion = new OleDbConnection();
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                estadoConexion = "Abierto";
               // Comando = new OleDbCommand();
                //Comando.Connection = Conexion;
                //Comando.CommandType = System.Data.CommandType.Text;
                //Comando.CommandText = "";
                //Lector = Comando.ExecuteReader();
                //MessageBox.Show("BD");
            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;

            }


        }

        public void CargaEmpleado(ComboBox cboEmpleado)
        {
            string CargarCbo = "SELECT DISTINCT CODIGO From DATOS_ACADEMICOS";
            try
            {
                //llamo los objetos conexion y comando para manipular la base de datos 
                Comando = new OleDbCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = CargarCbo;
                //reader para leer los datos que contiene
                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    //Agrego la tabla paises al cboLugarNacimiento
                    cboEmpleado.Items.Add(Lector["Pais"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           // Lector.Close();
        }
    }
}
