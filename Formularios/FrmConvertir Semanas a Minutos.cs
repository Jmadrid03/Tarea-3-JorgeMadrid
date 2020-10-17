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
    public partial class FrmConvertir_Semanas_a_Minutos : Form
    {
        Clases.Clases_de_Metodos sem = new Clases.Clases_de_Metodos();
        public FrmConvertir_Semanas_a_Minutos()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Semanas_a_Minutos_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double num;

            num = Convert.ToDouble(TxtSemana.Text.Trim());

            sem.Semana(num);

            TxtSemana.Clear();
            TxtSemana.Focus();
        }
    }
}
