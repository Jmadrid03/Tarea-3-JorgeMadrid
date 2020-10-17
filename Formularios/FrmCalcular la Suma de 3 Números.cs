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
    public partial class FrmCalcular_la_Suma_de_3_Números : Form
    {
        Clases.Clases_de_Metodos a = new Clases.Clases_de_Metodos();
        public FrmCalcular_la_Suma_de_3_Números()
        {
            InitializeComponent();
        }

        private void FrmCalcular_la_Suma_de_3_Números_Load(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            num1 = Convert.ToDouble(TxtPrimerV.Text.Trim());
            num2 = Convert.ToDouble(TxtSegundoV.Text.Trim());
            num3 = Convert.ToDouble(TxtTercerV.Text.Trim());

            a.Sumar(num1, num2, num3); 

            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtPrimerV.Focus();
            }
        }
    }
}
