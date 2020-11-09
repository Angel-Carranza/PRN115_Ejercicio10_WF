using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Guia9Ejercicio10
{
    public partial class Form1 : Form
    {

        Cambios Evolution = new Cambios();

        public Form1()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(btnInsPhr, "PRESIONE ESTE BOTON PARA INGRESAR LA FRASE O PALABRA QUE DESEA CODIFICAR");
            ttAyuda.SetToolTip(btnClear, "PRESIONE ESTE BOTON PARA LIMPIAR LAS FRASES O PALABRAS INGRESADAS");
            ttAyuda.SetToolTip(btnClose, "PRESIONE PARA PODER CERRAR DEL PROGRAMA");
            ttAyuda.SetToolTip(lblFrasOri, "ESTA ES LA FRASE QUE USTED INGRESO SIN CODIFICAR");
            ttAyuda.SetToolTip(lblFrasCod, "ESTA ES LA FRASE QUE USTED INGRESO PERO CODIFICADA");
        }

        private void btnInsPhr_Click(object sender, EventArgs e)
        {
            string variable = null;

            do
            {
                variable = Microsoft.VisualBasic.Interaction.InputBox("INGRESE UNA PALABRA O FRASE", "FRASE O PALABRA");
            } while (variable == string.Empty);

            Evolution.Pokemon = variable;
            variable = variable.ToUpper();

            lblFrasOri.Text = "" + variable;
            lblFrasCod.Text = "" + Evolution.Codificacion();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFrasCod.Text = "-";
            lblFrasOri.Text = "-";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cerrar;
            cerrar = MessageBox.Show("DESEA CERRAR EL PROGRAMA?", "ADVERTENCIA DE CERRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cerrar == DialogResult.Yes)
                Close();
        }
    }
}