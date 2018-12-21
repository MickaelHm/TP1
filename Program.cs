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
            Console.WriteLine("Veuillez entrer votre poids en chiffre"); // on affiche un message demandant le poids du user
            double weight = double.Parse(Console.ReadLine()); // Déclaration de la variable "weight" et on y affecte la valeur poids du user converti en double
            Console.WriteLine("Veuillez entrer votre taille en metre");
            double height = double.Parse(Console.ReadLine());
            double imc = Math.Round(weight / (Math.Pow(height, 2)),2); // déclaration de la variable imc de type double et a quoi elle est égale
            // Pour avoir un chiffre arrondi a seulement 2 décimal on utilise - Math.Round( calcule ),2 - ,2 correspond a l'arrondi
            Console.WriteLine("Votre IMC est de " + imc); // On donne l'IMC au user
            if (imc <= 16.5 && imc >= 10)
            {
                Console.WriteLine("Votre IMC indique une Dénutrition");
            }
            else if (imc > 16.5 && imc <= 25)
            {
                Console.WriteLine("Votre IMC une Maigreur");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Votre IMC indique une Corpulence normale");
            }
            else if (imc > 30 && imc <= 35)
            {
                Console.WriteLine("Votre IMC indique une Obésité modérée");
            }
            else if (imc > 35 && imc <= 40)
            {
                Console.WriteLine("Votre IMC indique une Obésité sévère");
            }
            else if (imc > 40 && imc <=100)
            {
                Console.WriteLine("Votre IMC indique une Obésité morbide ou massive");
            }
            else if (imc < 10 || imc > 100)
            {
                Console.WriteLine("Vous ne devriez pas être vivant");
            }
            else
            {
                Console.WriteLine("oops il doit y avoir une erreur");
            }
        }
    }
}
