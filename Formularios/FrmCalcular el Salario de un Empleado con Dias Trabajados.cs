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
    public partial class FrmCalcular_el_Salario_de_un_Empleado_con_Dias_Trabajados : Form
    {
        Clases.Clases_de_Metodos sald = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Salario_de_un_Empleado_con_Dias_Trabajados()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Salario_de_un_Empleado_con_Dias_Trabajados_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double dias, predia;

            dias = Convert.ToDouble(TxtDias.Text.Trim());
            predia = Convert.ToDouble(TxtPrecioD.Text.Trim());

            sald.SalDia(dias, predia);

            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtDias.Focus();
            }
        }
    }
}
