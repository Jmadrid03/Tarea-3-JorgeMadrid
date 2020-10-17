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
    public partial class FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante : Form
    {
        Clases.Clases_de_Metodos pr = new Clases.Clases_de_Metodos();  
        public FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcularP_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4;

            cal1 = Convert.ToDouble(TxtCal1.Text.Trim());
            cal2 = Convert.ToDouble(TxtCal2.Text.Trim());
            cal3 = Convert.ToDouble(TxtCal3.Text.Trim());
            cal4 = Convert.ToDouble(TxtCal4.Text.Trim());

            pr.promedio(cal1, cal2, cal3, cal4);

            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtCal1.Focus();
            }
        }

        private void FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
