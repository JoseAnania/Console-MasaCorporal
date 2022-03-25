using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasaCorporal
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("Indique su Peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("usted ingresó " + peso + " kg y " + altura +" metros");
            imc = peso / (altura * altura);
            Console.WriteLine("Su indice de masa corporal es: " +imc);
            Console.ReadKey();
        }
    }
}
