using System;
using System.Collections.Generic;

namespace

FASE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var letras = new char[] { 'J', 'o', 'r', 'd', 'a', 'n' };
            var listaLetras = new List<char>();
            var diccionari = new Dictionary<char, int>();
            var valor = 0;

            for(var i=0; i< letras.Length; i++)
            {
                listaLetras.Add(letras[i]);
            }
            foreach(var letra in listaLetras)
            {
                if (char.IsLetter(letra))
                {
                    if (diccionari.ContainsKey(Char.ToUpper(letra)))
                    {
                        diccionari.TryGetValue(Char.ToUpper(letra), out valor);
                        diccionari[Char.ToUpper(letra)] = valor += 1;
                    }
                    else
                    {
                        diccionari.Add(Char.ToUpper(letra), 1);
                    }
                }
            }
            foreach (var dic in diccionari)
            {
                Console.WriteLine($"La letra es: {dic.Key} y hay {dic.Value} en el diccionario.");
            }
        }
    }
}

