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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void FrmMenú_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSuma3_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_la_Suma_de_3_Números suma = new Formularios.FrmCalcular_la_Suma_de_3_Números();
            suma.Show();
        }

        private void BtnPromedio4_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante cali = new Formularios.FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante();
            cali.Show();
        }

        private void BtnMillasaMetros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Millas_a_Metros milla = new Formularios.FrmConvertir_Millas_a_Metros();
            milla.Show();
        }

        private void BtnMillasaKilometros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Millas_a_Kilómetros kilo = new Formularios.FrmConvertir_Millas_a_Kilómetros();
            kilo.Show();
        }

        private void BtnLempirasaDolares_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Lempiras_a_Dólares lempira = new Formularios.FrmConvertir_Lempiras_a_Dólares();
            lempira.Show();
        }

        private void BtnLempiraaEuros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Lempiras_a_Euros euro = new Formularios.FrmConvertir_Lempiras_a_Euros();
            euro.Show();
        }

        private void BtnTotalPagarLlantas_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Total_a_Pagar_por_Llantas llanta = new Formularios.FrmCalcular_el_Total_a_Pagar_por_Llantas();
            llanta.Show();
        }

        private void BtnSalarioDias_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_un_Empleado_con_Dias_Trabajados Dia = new Formularios.FrmCalcular_el_Salario_de_un_Empleado_con_Dias_Trabajados();
            Dia.Show();
        }

        private void BtnSalarioDiasHoras_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas hora = new Formularios.FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas();
            hora.Show();
        }

        private void BtnGalonesaLitros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Galones_a_Litros galon = new Formularios.FrmConvertir_Galones_a_Litros();
            galon.Show();
        }

        private void BtnLibrasaOnzas_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Libras_a_Onzas libra = new Formularios.FrmConvertir_Libras_a_Onzas();
            libra.Show();
        }

        private void BtnPulgadasaCentimetros_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Pulgadas_a_Centimetros pulga = new Formularios.FrmConvertir_Pulgadas_a_Centimetros();
            pulga.Show();
        }

        private void BtnDiasaMinutos_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Dias_a_Minutos minuto = new Formularios.FrmConvertir_Dias_a_Minutos();
            minuto.Show();
        }

        private void BtnSalarioAumento_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento aumento = new Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento();
            aumento.Show();
        }

        private void BtnEdadPromedio_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_la_Edad_Promedio_de_10_Personas person = new Formularios.FrmCalcular_la_Edad_Promedio_de_10_Personas();
            person.Show();
        }

        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Cuadrado_de_un_Número cuadrado = new Formularios.FrmCalcular_el_Cuadrado_de_un_Número();
            cuadrado.Show();
        }

        private void BtnCubo_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Cubo_de_un_Número cub = new Formularios.FrmCalcular_el_Cubo_de_un_Número();
            cub.Show();
        }

        private void BtnDoble_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Doble_de_un_Número doble = new Formularios.FrmCalcular_el_Doble_de_un_Número();
            doble.Show();
        }

        private void BtnMetrosaPies_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Metros_a_Pies pie = new Formularios.FrmConvertir_Metros_a_Pies();
            pie.Show();
        }

        private void BtnSemanasaMinutos_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertir_Semanas_a_Minutos sema = new Formularios.FrmConvertir_Semanas_a_Minutos();
            sema.Show();
        }

        private void BtnPagaraConstructor_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Total_a_Pagar_de_un_Constructor mtr2 = new Formularios.FrmCalcular_el_Total_a_Pagar_de_un_Constructor();
            mtr2.Show();
        }

        private void BtnNotaTotal_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_Nota_Total_del_Estudiante nota = new Formularios.FrmCalcular_Nota_Total_del_Estudiante();
            nota.Show();
        }
    }
}
