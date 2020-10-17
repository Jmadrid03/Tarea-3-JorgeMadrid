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
    public partial class FrmConvertir_Lempiras_a_Dólares : Form
    {
        Clases.Clases_de_Metodos lps = new Clases.Clases_de_Metodos();
        public FrmConvertir_Lempiras_a_Dólares()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Lempiras_a_Dólares_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double leps;

            leps = Convert.ToDouble(TxtLempiras.Text.Trim());

            lps.lempiras(leps);

            TxtLempiras.Clear();
            TxtLempiras.Focus();
        }
    }
}
