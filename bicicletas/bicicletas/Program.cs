using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicicletas
{
    class Program
    {
        public static double calcularSubtotal(String tipoAlq,  int cantBicis)
        {
            int precioHora = 20;
            int precioDia = 100;
            int precioSem = 500;
            double tiempo = 0;
            double subtotal = 0;
            switch (tipoAlq)
            {
                case "H":
                    Console.Write("Cuantas horas?: ");
                    tiempo = double.Parse(Console.ReadLine());
                    subtotal = cantBicis * tiempo * precioHora;      
                    break;
                case "D":
                    Console.Write("Cuantos días?: ");
                    tiempo = double.Parse(Console.ReadLine());
                    subtotal = cantBicis * tiempo * precioDia;
                    break;
                case "S":
                    Console.Write("Cuantas semanas?: ");
                    tiempo = double.Parse(Console.ReadLine());
                    subtotal = cantBicis * tiempo * precioSem;
                    break;
            }
            return subtotal;
        }
        static void Main(string[] args)
        {
            
            double descuento = 0.30;
            double subtotal = 0;
            double total = 0;
            int cantBicis = 0;
            String tipoAlq = "";
            String corte = "";

            while (corte !="N")
            {
                Console.Write("Cuantas bicicletas vas a alquilar?: ");
                cantBicis = int.Parse(Console.ReadLine());
                Console.Write("Indique el tipo de alquiler [H] - para alquiler por hora - [D] - por día y [S] - por semana: ");
                tipoAlq = Console.ReadLine();
                if (cantBicis < 3)
                {
                    subtotal = calcularSubtotal(tipoAlq, cantBicis);
                    Console.WriteLine("Total a pagar: $ {0}", subtotal);
                }
                else
                {
                    subtotal = calcularSubtotal(tipoAlq, cantBicis);
                    total = subtotal - (subtotal * descuento);
                    Console.WriteLine("Total a pagar: $ {0}", total);
                }
                
                Console.Write("Deseas continuar [S]i o [N]o?: ");
                corte = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
