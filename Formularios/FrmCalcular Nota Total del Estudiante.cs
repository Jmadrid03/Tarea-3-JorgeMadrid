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
    public partial class FrmCalcular_Nota_Total_del_Estudiante : Form
    {
        Clases.Clases_de_Metodos Ntl = new Clases.Clases_de_Metodos();
        public FrmCalcular_Nota_Total_del_Estudiante()
        {
            InitializeComponent();
        }

        private void FrmCalcular_Nota_Total_del_Estudiante_Load(object sender, EventArgs e)
        {    double Acum, Exam;
            Acum = Convert.ToDouble(TxtAcumulativo.Text.Trim());
            Exam = Convert.ToDouble(TxtExamen.Text.Trim());


            Ntl.NotaExam(Acum, Exam);

            TxtAcumulativo.Clear();
            TxtExamen.Clear();
            TxtAcumulativo.Focus();
        }
    }
}
