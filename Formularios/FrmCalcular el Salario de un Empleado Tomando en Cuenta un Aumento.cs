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
    public partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento : Form
    {
        Clases.Clases_de_Metodos SalAum = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double sal, aum;

            sal = Convert.ToDouble(TxtSalario.Text.Trim());
            aum = Convert.ToDouble(TxtAumento.Text.Trim());

            SalAum.Aumsal(sal, aum);

            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtSalario.Focus();
            }
        }
    }
}
