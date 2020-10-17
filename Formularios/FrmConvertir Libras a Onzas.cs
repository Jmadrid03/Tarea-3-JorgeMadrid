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
    public partial class FrmConvertir_Libras_a_Onzas : Form
    {
        Clases.Clases_de_Metodos lbs = new Clases.Clases_de_Metodos();
        public FrmConvertir_Libras_a_Onzas()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Libras_a_Onzas_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double lb;

            lb = Convert.ToDouble(TxtLibras.Text.Trim());

            lbs.libras(lb);

            TxtLibras.Clear();
            TxtLibras.Focus();
        }
    }
}
