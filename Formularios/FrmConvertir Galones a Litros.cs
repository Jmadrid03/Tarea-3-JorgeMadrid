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
    public partial class FrmConvertir_Galones_a_Litros : Form
    {
        Clases.Clases_de_Metodos galn = new Clases.Clases_de_Metodos();
        public FrmConvertir_Galones_a_Litros()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Galones_a_Litros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double gln;

            gln = Convert.ToDouble(TxtGalones.Text.Trim());

            galn.galones(gln);

            TxtGalones.Clear();
            TxtGalones.Focus();
        }
    }
}
