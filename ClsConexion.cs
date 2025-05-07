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
        #region Conexion


        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BDHeroes.mdb";

        #endregion

        #region Carga de Cmb
        public void CargarCategoriasDirectoEnCombo(ComboBox cmb)
        {

            try
            {
                // --- Llama la cadena de conexion ---
                using (OleDbConnection connLocal = new OleDbConnection(CadenaConexion))
                {
                    connLocal.Open();
                    // Consulta a la tabla Categoria (para productos)
                    string query = "SELECT IdCodigo, Nombre FROM Heroes ORDER BY Nombre";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, connLocal))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Configurar el ComboBox
                        cmb.DataSource = null; // Limpiar DataSource anterior por si acaso
                        cmb.DisplayMember = "Nombre";      // Columna de texto a mostrar
                        cmb.ValueMember = "IdCategoria";   // Columna de ID a guardar
                        cmb.DataSource = dt;               // Asignar nuevo origen de datos
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmb.SelectedIndex = -1;          // Sin selección inicial
                    }
                }
                //Para  saber si anda, y si da error fijarme en la consola
                Console.WriteLine($"CATEGORIAS CRUD: ComboBox '{cmb.Name}' cargado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías de producto:\n{ex.Message}", "Error DAL Categorías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb.DataSource = null; cmb.Items.Clear(); // Limpiar combo en error
            }
        }

        #endregion
    }
}
