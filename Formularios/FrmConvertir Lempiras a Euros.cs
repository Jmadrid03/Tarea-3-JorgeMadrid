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
    public partial class FrmConvertir_Lempiras_a_Euros : Form
    {
        Clases.Clases_de_Metodos lpsEr = new Clases.Clases_de_Metodos();
        public FrmConvertir_Lempiras_a_Euros()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Lempiras_a_Euros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double lps;

            lps = Convert.ToDouble(TxtLempiras.Text.Trim());

            lpsEr.lempiraEuro(lps);

            TxtLempiras.Clear();
            TxtLempiras.Focus();
        }
    }
}
