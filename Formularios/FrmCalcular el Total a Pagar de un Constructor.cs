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
    public partial class FrmCalcular_el_Total_a_Pagar_de_un_Constructor : Form
    {
        Clases.Clases_de_Metodos M2 = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Total_a_Pagar_de_un_Constructor()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Total_a_Pagar_de_un_Constructor_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num, precm2;

            num = Convert.ToDouble(TxtMetro2.Text.Trim());
            precm2 = Convert.ToDouble(TxtPrecm2.Text.Trim());

            M2.Mt2(num, precm2);

            TxtMetro2.Clear();
            TxtPrecm2.Clear();
            TxtMetro2.Focus();
        }
    }
}
