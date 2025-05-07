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


namespace PryMirkoLopezBearzi_2025._05._07
{
    public partial class FrmInicio : Form
    {
        
        
        
        public FrmInicio()
        {
            InitializeComponent();

           
        }

        private void CmbH_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (CmbH.SelectedIndex == 0)
                {

                    PbSuper.Visible = true;
                    PbBatman.Visible = false;
                    PbWonder.Visible = false;
                }
                else if (CmbH.SelectedIndex == 1)
                {
                    PbSuper.Visible = false;
                    PbBatman.Visible = true;
                    PbWonder.Visible = false;
                }
                else if (CmbH.SelectedIndex == 2)
                {
                    PbSuper.Visible = false;
                    PbBatman.Visible = false;
                    PbWonder.Visible = true;
                }
            }

        }



        private void CargarHeroesEnCombo()
        {
            CmbH.Items.Add("SuperMan");
            CmbH.Items.Add("Batman");
            CmbH.Items.Add("Wonder Woman");
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            PbSuper.Visible = false;
            PbBatman.Visible = false;
            PbWonder.Visible = false;
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
            if (CmbH.SelectedItem != null && CmbH.SelectedIndex != -1)
            {
                string nombreHeroe = CmbH.Text; 
                decimal fuerza = NuDFuer.Value;  
                decimal destreza = NuDDestr.Value;

                string contenidoArchivo = $"Héroe: {nombreHeroe}{Environment.NewLine}" +
                                          $"Fuerza: {fuerza}{Environment.NewLine}" +
                                          $"Destreza: {destreza}{Environment.NewLine}" +
                                          $"--------------------{Environment.NewLine}";

                string nombreDelArchivo = "heroes_detalles.txt";

                try
                {
                  
                    File.AppendAllText(nombreDelArchivo, contenidoArchivo);

                    MessageBox.Show($"Datos para '{nombreHeroe}' guardados en '{nombreDelArchivo}'.",
                                    "Datos Guardados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}",
                                    "Error de Archivo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un héroe primero.",
                                "Acción Requerida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void NuDDestr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NuDFuer_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
