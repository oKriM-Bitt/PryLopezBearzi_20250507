using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PryPueblox
{
    class ClsConexion
    {
        #region Conexion y archivo


        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDHeroes.mdb";
        public string ArchivoHeroes = "Heroes.txt";


        #endregion

        public void GrabarEnArchivoTexto(string contenido)
        {
            try
            {
              
                File.WriteAllText(ArchivoHeroes, contenido);

                
                Process.Start(new ProcessStartInfo
                {
                    FileName = ArchivoHeroes,
                    UseShellExecute = true 
                });
                Console.WriteLine($"INFO: Contenido grabado en '{ArchivoHeroes}' y archivo abierto.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al grabar o abrir el archivo '{ArchivoHeroes}':\n{ex.Message}", "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Carga de Cmb

        /// Carga los nombres de los héroes desde la base de datos a un ComboBox.

        public void CargarNombresHeroesEnCombo(ComboBox cmb)
        {
            try
            {
                using (OleDbConnection connLocal = new OleDbConnection(CadenaConexion))
                {
                    connLocal.Open();
                    // Consulta para seleccionar solo IdCodigo y Nombre de la tabla Heroes
                    string query = "SELECT IdCodigo, Nombre FROM Heroes ORDER BY Nombre";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, connLocal))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Configurar el ComboBox
                        cmb.DataSource = null; 
                        cmb.DisplayMember = "Nombre";   
                        cmb.ValueMember = "IdCodigo"; 
                        cmb.DataSource = dt;            
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList; 
                        cmb.SelectedIndex = -1;         
                    }
                }
                Console.WriteLine($"INFO: ComboBox '{cmb.Name}' cargado con nombres de héroes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de héroes en el ComboBox:\n{ex.Message}\nAsegúrese que 'BDHeroes.mdb' existe y la tabla 'Heroes' tiene 'IdCodigo' y 'Nombre'.", "Error de Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb.DataSource = null; cmb.Items.Clear(); // Limpiar combo en caso de error
            }
        }
        #endregion
    }
}
