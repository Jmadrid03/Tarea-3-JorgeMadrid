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
    public partial class FrmCalcular_el_Total_a_Pagar_por_Llantas : Form
    {
        Clases.Clases_de_Metodos tlp = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Total_a_Pagar_por_Llantas()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Total_a_Pagar_por_Llantas_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, prec;

            cant = Convert.ToDouble(TxtCantidad.Text.Trim());
            prec = Convert.ToDouble(TxtPrecio.Text.Trim());

            tlp.totalp(cant, prec);

            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtCantidad.Focus();
            }

        }
    }
}
