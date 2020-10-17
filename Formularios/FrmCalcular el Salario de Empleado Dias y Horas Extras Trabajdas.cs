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
    public partial class FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas : Form
    {
        Clases.Clases_de_Metodos salhe = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double dia, pred, hre, prehe;

            dia = Convert.ToDouble(TxtDias.Text.Trim());
            pred = Convert.ToDouble(TxtPrecioD.Text.Trim());
            hre = Convert.ToDouble(TxtHorasE.Text.Trim());
            prehe = Convert.ToDouble(TxtPrecioH.Text.Trim());

            salhe.SalaHrE(dia, pred, hre, prehe);

            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtDias.Focus();
            }
        }
    }
}
