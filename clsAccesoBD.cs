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

       
       
        public void ConectarBD()
        {
            string rutaArchivo = @"../../BD/EMPLEO.accdb";
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            OleDbConnection conexion = new OleDbConnection(CadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (OleDbException)
            {
                MessageBox.Show("BD no Conectada");
            }
            finally
            {
                conexion.Close();
            }
        }

        public void CargaEmpleado(ComboBox cboEmpleado)
        {
            string rutaArchivo = @"../../BD/EMPLEO.accdb";
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                string varSQL = "SELECT CODIGO FROM [DATOS LABORALES] ORDER BY 1 DESC";
                using (OleDbCommand cmdEmpleado = new OleDbCommand(varSQL, conexion))
                {
                    using (OleDbDataReader reader = cmdEmpleado.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboEmpleado.Items.Add(reader["CODIGO"].ToString());
                        }
                    }
                }
            }
        }

        public void LlenarTreeView(string codigo, TreeView Tree)
        {
            string rutaArchivo = @"../../BD/EMPLEO.accdb";
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                DataTable schema = conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                foreach (DataRow row in schema.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    TreeNode tableNode = Tree.Nodes.Add(tableName);
                    LlenarNodosFiltrados(tableNode, codigo, tableName);
                }
            }
        }
        public void LlenarNodosFiltrados(TreeNode parentNode, string codigo, string tableName)
        {
            string query = $"SELECT * FROM [{tableName}] WHERE CODIGO = '{codigo}'";
            string rutaArchivo = @"../../BD/EMPLEO.accdb";
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conexion = new OleDbConnection(CadenaConexion))
            {
                conexion.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conexion))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                string columnValue = reader[i].ToString();
                                parentNode.Nodes.Add($"{columnName}: {columnValue}");
                            }
                        }
                    }
                }
            }

        }
    }
}
