using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = new char[] { 'J', 'O', 'R', 'D', 'A', 'N','7'};
            var letrasnombre = new List<char>();

            for (var i = 0; i < nombre.Length; i++)
            {
                letrasnombre.Add(nombre[i]);
            }
            foreach (var letra in letrasnombre)
            {
                if (Char.IsLetter(letra))
                {

                    if (Char.ToLower(letra) == 'a' || Char.ToLower(letra) == 'e' || Char.ToLower(letra) == 'i' || Char.ToLower(letra) == 'o' || Char.ToLower(letra) == 'u')
                    {
                        Console.WriteLine($"{letra} és una VOCAL");
                    }
                    else
                    {
                        Console.WriteLine($"{letra} és una CONSONANT");
                    }
                }

                else if (Char.IsNumber(letra))
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }

            }
        }
    }
}
