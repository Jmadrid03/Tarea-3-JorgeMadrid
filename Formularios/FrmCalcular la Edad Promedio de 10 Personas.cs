using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    public partial class FrmCalcular_la_Edad_Promedio_de_10_Personas : Form
    {
        Clases.Clases_de_Metodos proedad = new Clases.Clases_de_Metodos();
        int contador = 1;
        double sumed = 0;
        public FrmCalcular_la_Edad_Promedio_de_10_Personas()
        {
            InitializeComponent();
        }

        private void FrmCalcular_la_Edad_Promedio_de_10_Personas_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtNombreP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre de la Persona.");
                TxtNombreP.Focus();
                return;
            }
            
            if (TxtEdadP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Edad de la Persona.");
                TxtEdadP.Focus();
                return;
            }
            
            LsbPersona.Items.Add(TxtNombreP.Text.Trim());
            LsbEdad.Items.Add(TxtEdadP.Text.Trim());
            double edad;
            edad = Convert.ToDouble(TxtEdadP.Text.Trim());
            sumed += edad;
            TxtEdadP.Clear();

            TxtNombreP.Clear();
            TxtNombreP.Focus();

            contador++;
            LblNombreP.Text = "Ingresar Nombre de la Persona # " + contador.ToString() + ": ";
        }

        private void BtnCalcularP_Click(object sender, EventArgs e)
        {
            proedad.PromEdad(sumed);
        }
    }
}
