using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer votre poids en chiffre");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer votre taille en metre");
            double height = double.Parse(Console.ReadLine());
            double IMC = (weight / (Math.Pow(height, 2)));
            Console.WriteLine("Votre IMC est de " + IMC);
            if (IMC <= 16.5)
            {
                Console.WriteLine("Votre IMC indique une Dénutrition");
            }
            else if (IMC > 16.5 && IMC <= 25)
            {
                Console.WriteLine("Votre IMC une Maigreur");
            }
            else if (IMC > 25 && IMC <= 30)
            {
                Console.WriteLine("Votre IMC indique une Corpulence normale");
            }
            else if (IMC > 30 && IMC <= 35)
            {
                Console.WriteLine("Votre IMC indique une Obésité modérée");
            }
            else if (IMC > 35 && IMC <= 40)
            {
                Console.WriteLine("Votre IMC indique une Obésité sévère");
            }
            else if (IMC > 40)
            {
                Console.WriteLine("Votre IMC indique une Obésité morbide ou massive");
            }


        }
    }
}
