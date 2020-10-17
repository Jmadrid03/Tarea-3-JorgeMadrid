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
    public partial class FrmConvertir_Dias_a_Minutos : Form
    {
        Clases.Clases_de_Metodos dia = new Clases.Clases_de_Metodos();
        public FrmConvertir_Dias_a_Minutos()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Dias_a_Minutos_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double dias;

            dias = Convert.ToDouble(TxtDias.Text.Trim());

            dia.dias(dias);

            TxtDias.Clear();
            TxtDias.Focus();
        }
    }
}
