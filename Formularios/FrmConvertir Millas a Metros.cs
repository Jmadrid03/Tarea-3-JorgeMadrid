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
    public partial class FrmConvertir_Millas_a_Metros : Form
    {
        Clases.Clases_de_Metodos mil = new Clases.Clases_de_Metodos();
        public FrmConvertir_Millas_a_Metros()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Millas_a_Metros_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double mill;

            mill = Convert.ToDouble(TxtMillas.Text.Trim());

            mil.millas(mill);

            TxtMillas.Clear();
            TxtMillas.Focus();
        }
    }
}
