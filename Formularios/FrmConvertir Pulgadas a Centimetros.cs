﻿using System;
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
    public partial class FrmConvertir_Pulgadas_a_Centimetros : Form
    {
        Clases.Clases_de_Metodos plg = new Clases.Clases_de_Metodos();
        public FrmConvertir_Pulgadas_a_Centimetros()
        {
            InitializeComponent();
        }

        private void FrmConvertir_Pulgadas_a_Centimetros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double pulg;

            pulg = Convert.ToDouble(TxtPulgadas.Text.Trim());

            plg.pulgadas(pulg);

            TxtPulgadas.Clear();
            TxtPulgadas.Focus();
        }
    }
}
