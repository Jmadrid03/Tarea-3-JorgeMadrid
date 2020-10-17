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
    public partial class FrmCalcular_el_Doble_de_un_Número : Form
    {
        Clases.Clases_de_Metodos dob = new Clases.Clases_de_Metodos();
        public FrmCalcular_el_Doble_de_un_Número()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Doble_de_un_Número_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num;

            num = Convert.ToDouble(TxtNumero.Text.Trim());

            dob.Doble(num);

            TxtNumero.Clear();
            TxtNumero.Focus();
        }
    }
}
