using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se declaran variables
            int grados, resultado;
            //se piden los grados C°
            Console.WriteLine("dame los grados C°: ");
            //se agarran los grados que ingresamos con el teclado
            grados = Convert.ToInt32(Console.ReadLine());
            //formula para transformar
            resultado = (grados *9/5)+32;
            //se muestra el resultado de C a F
            Console.WriteLine("Ingresaste "+grados+"C°, que es igual a "+resultado+"F°");
            Console.ReadLine();
            
        }
    }
}
