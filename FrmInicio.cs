using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryPueblox;

namespace PryMirkoLopezBearzi_2025._05._07
{
    public partial class FrmInicio : Form
    {
        ClsConexion ConexionBD = new ClsConexion(); // Instancia de ClsConexion
        // Ruta a la carpeta de imágenes. Asume una subcarpeta "Images".
        private string carpetaImagenes = Path.Combine(Application.StartupPath, "Images");
       
        
        public FrmInicio()
        {
            InitializeComponent();

            // Opcional: Verificar si la carpeta de imágenes existe y crearla si no.
            if (!Directory.Exists(carpetaImagenes))
            {
                try
                {
                    Directory.CreateDirectory(carpetaImagenes);
                    MessageBox.Show($"Se ha creado la carpeta 'Images' en: {carpetaImagenes}\nPor favor, coloque las imágenes de los héroes (ej: Batman.jpg, Superman.jpg, Wonder Woman.jpg) allí.", "Carpeta Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo crear la carpeta 'Images': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CmbH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbH.SelectedItem != null && CmbH.SelectedIndex != -1)
            {


            }
        }
               


        private void CargarHeroesEnCombo()
        {
            try
            {
                Console.WriteLine("Cargando héroes en ComboBox...");
                ConexionBD.CargarNombresHeroesEnCombo(CmbH); // CmbH es tu ComboBox para héroes
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando héroes en el formulario:\n{ex.Message}", "Error de Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CargarHeroesEnCombo();
            
            NuDFuer.Minimum = 0; NuDFuer.Maximum = 100; NuDFuer.Value = 10; 
            NuDDestr.Minimum = 0; NuDDestr.Maximum = 100; NuDDestr.Value = 10; 
        }

        private void PbSuper_Click(object sender, EventArgs e)
        {

        }

        private void PbBatman_Click(object sender, EventArgs e)
        {

        }

        private void PbWonder_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

        }

        private void NuDDestr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NuDFuer_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
