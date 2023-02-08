using Microsoft.VisualBasic;
using System;
namespace FuncionesBasicasMath
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;
            int entera;

            Console.WriteLine("DIGITE PRIMER NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE SEGUNDO NÚMERO: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;

            Console.WriteLine("VALOR ABSOLUTO: " + Math.Abs(resultado));  //del resultado
            Console.WriteLine("POTENCIA: " + Math.Pow(num1, num2));       //potencia al segundo numero
            Console.WriteLine("RAIZ CUADRADA: " + Math.Sqrt(resultado));  //de la suma de los dos numeros
            Console.WriteLine("SENO: " + Math.Sin(num1 * Math.PI / 180));
            Console.WriteLine("COSENO" + Math.Cos(num1 * Math.PI / 180));
            Console.WriteLine("NÚMERO MÁXIMO: " + Math.Max(resultado, num2));
            Console.WriteLine("NÚMERO MÍNIMO: " + Math.Min(num1, num2));
            Console.WriteLine("PARTE ENTERA: " + Math.Truncate(Convert.ToDouble(resultado)));
            Console.WriteLine("REDONDEO: " + Math.Round(Convert.ToDouble(resultado)));
            Console.ReadKey();  //Se cierre la app al presionar tecla
        }
    }
}
