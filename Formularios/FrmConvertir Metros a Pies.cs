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
    public partial class FrmConvertir_Metros_a_Pies : Form
    {
        Clases.Clases_de_Metodos metro = new Clases.Clases_de_Metodos();
        public FrmConvertir_Metros_a_Pies()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Metros_a_Pies_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double num;

            num = Convert.ToDouble(TxtMetro.Text.Trim());

            metro.Metro(num);

            TxtMetro.Clear();
            TxtMetro.Focus();

        }
    }
}
