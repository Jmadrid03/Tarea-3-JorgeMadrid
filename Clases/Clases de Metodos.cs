using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_Orientada_a_Objetos_JorgeMadrid.Clases
{
    class Clases_de_Metodos
    {
        public void Sumar(double vl1, double vl2, double vl3)
        {
            double suma = (vl1 + vl2 + vl3);
            MessageBox.Show(suma.ToString(), "Resultado:");

        }

        public void promedio(double n1, double n2, double n3, double n4)
        {
            double promediar = (n1 + n2 + n3 + n4) / 4;
            MessageBox.Show(promediar.ToString("F"), "El Promedio es de:");

        }

        public void millas(double mil)
        {
            double milla = mil * 1609.34;
            MessageBox.Show(milla.ToString("F"), "La Cantidad a Metros es:");

        }

        public void millakil(double mil)
        {
            double milla = mil * 1.609;
            MessageBox.Show(milla.ToString("F"), "Las Millas a Kilómetros es:");

        }

        public void lempiras(double lemp)
        {
            double lempira = lemp * 0.041;
            MessageBox.Show(lempira.ToString("F"), "La Cantidad en Dólares es de:");

        }

        public void lempiraEuro(double lemp)
        {
            double lempira = lemp * 0.035;
            MessageBox.Show(lempira.ToString("F"), "La Cantidad en Euros es de:");

        }

        public void totalp(double cant, double prec)
        {
            double total = cant * prec;
            MessageBox.Show(total.ToString("F"), "El Total a Pagar es:");
        }

        public void SalDia(double dia, double precd)
        {
            double total = dia * precd;
            MessageBox.Show(total.ToString("F"), "El Total a Pagar es:");
        }

        public void SalaHrE(double dia, double precd, double hre, double prehre)
        {
            double total = (dia * precd) + (hre * prehre);
            MessageBox.Show(total.ToString("F"), "El Total a Pagar es de:");
        }

        public void galones(double gln)
        {
            double galon = gln * 4.54609;
            MessageBox.Show(galon.ToString("F"), "La Conversion a Litros es:");

        }

        public void libras(double lb)
        {
            double res = lb * 16;
            MessageBox.Show(res.ToString("F"), "La Conversion a Onzas es:");

        }

        public void pulgadas(double pulg)
        {
            double res = pulg * 2.54;
            MessageBox.Show(res.ToString("F"), "La Conversion a Centimetros es:");

        }

        public void dias(double dia)
        {
            double res = dia * 1440;
            MessageBox.Show(res.ToString("F"), "La Conversion a Minutos es:");

        }

        public void Aumsal(double sal, double aum)
        {
            double res = sal + ((aum/100) * sal);
            MessageBox.Show(res.ToString("F"), "El Salario Mas Aumento es:");

        }

        public void PromEdad(double sumedades)
        {
            double prom = sumedades / 10;
            MessageBox.Show(prom.ToString("F"), "El Promedio de Edades es:");

        }

        public void Cuadrado(double num)
        {
            double res = num * num;
            MessageBox.Show(res.ToString("F"), "El Resultado es:");

        }

        public void Cubo(double num)
        {
            double res = num * 3;
            MessageBox.Show(res.ToString("F"), "El Resultado es:");

        }

        public void Doble(double num)
        {
            double res = num * 2;
            MessageBox.Show(res.ToString("F"), "El Resultado es:");

        }

        public void Metro(double metr)
        {
            double res = metr * 3.28084;
            MessageBox.Show(res.ToString("F"), "La Conversion a Pies es de:");

        }

        public void Semana(double num)
        {
            double res = num * 10080;
            MessageBox.Show(res.ToString("F"), "La Conversion a Minutos es de:");

        }

        public void Mt2(double num, double prm2)
        {
            double res = num * prm2;
            MessageBox.Show(res.ToString("F"), "El Total a Pagar al Constructor es:");

        }

        public void NotaExam(double ntacum, double ntexam)
        {
            double res = ntacum + ntexam;
            MessageBox.Show(res.ToString("F"), "El Total de la Nota es:");
        }
    }
}
