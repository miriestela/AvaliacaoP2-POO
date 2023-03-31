
using System;
using System.Globalization;

namespace calculadoraParaCircunferencias
{
    class Program
{
    static void Main(string[] args)
    {

        Calculadora Circunferencias = new Calculadora(2,3);

        Console.WriteLine("Calcula a área, circunferência e diâmetro.");

        //Console.WriteLine("Informe a área: ");
        //Circunferencias.area = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Informe o raio: ");
        //Circunferencias.raio = Convert.ToDouble(Console.ReadLine());

        //Área: pi * raio²
        //Circunferência = 2 * pi * raio
        //Diâmetro = 2 * raio

        Console.WriteLine("Área = " + Circunferencias.Area().ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Circunferência = " + Circunferencias.Circunferencia().ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Diâmetro = " + Circunferencias.Diametro().ToString("F1", CultureInfo.InvariantCulture));

      }
    }
}