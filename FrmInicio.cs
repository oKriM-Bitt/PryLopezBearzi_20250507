using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryPueblox;

namespace PryMirkoLopezBearzi_2025._05._07
{
    public partial class FrmInicio : Form
    {

        ClsConexion Cate = new ClsConexion();
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void CmbH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PbH_Click(object sender, EventArgs e)
        {

        }

        private void CargarCategoriasCombos()
        {
            try
            {
                Console.WriteLine("Cargando categorías en ComboBoxes...");
                
                Cate.CargarCategoriasDirectoEnCombo(CmbH);

                if (CmbH != null)
                {
                    Cate.CargarCategoriasDirectoEnCombo(CmbH);
                }

            }
            catch (Exception ex) { MessageBox.Show($"Error cargando categorías:\n{ex.Message}"); }
        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CargarCategoriasCombos();
        }

      
    }
}
