using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExemplesControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =================================================================================
        // SNIPPET EXEMPLE - ColorDialog (Joan del Tio)
        // =================================================================================
        private void btnCanviarColorFons_Click(object sender, EventArgs e)
        {
            // 1. Configurem el color per defecte a l'obrir al mateix del fons actual
            colorDialog1.Color = this.BackColor; 
            
            // 2. Obrim el diàleg i comprovem si l'usuari ha premut Acceptar
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // 3. Obtenim el color seleccionat per l'usuari i l'apliquem
                this.BackColor = colorDialog1.Color;
            }
        }
        // =================================================================================

        // =================================================================================
        // SNIPPET EXEMPLE - TrackBar (Joan del Tio)
        // =================================================================================
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // 1. Obtenim el valor numèric actual de la barra lliscant
            int volumActual = trackBar1.Value;

            // 2. Mostrem visualment el valor a l'usuari mitjançant l'etiqueta (Label)
            lblNivellVolum.Text = "Volum: " + volumActual.ToString() + "%";

            // 3. Podem emprar aquest valor, per exemple, en un motor d'àudio
            //    motorAudio.EstablirVolum(volumActual);
        }
        // =================================================================================
    }
}
