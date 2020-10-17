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
    public partial class FrmConvertir_Millas_a_Kilómetros : Form
    {
        Clases.Clases_de_Metodos mk = new Clases.Clases_de_Metodos();
        public FrmConvertir_Millas_a_Kilómetros()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Millas_a_Kilómetros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double mil;

            mil = Convert.ToDouble(TxtMillas.Text.Trim());

            mk.millakil(mil);

            TxtMillas.Clear();
            TxtMillas.Focus();
        }
    }
}
