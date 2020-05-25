using System;
using System.Collections.Generic;

namespace FASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = new char[] { 'J', 'o', 'r', 'd','a', 'n' };
            var apellido = new char[] { 'B', 'a', 'i', 'l', 'o', 'n' };

            var listaNombre = new List<char>();
            var listaApellido = new List<char>();
            var listFullName = new List<char>();

            for (var i = 0; i < nombre.Length; i++)
            {
                listaNombre.Add(nombre[i]);
            }

            for (var i = 0; i < apellido.Length; i++)
            {
                listaApellido.Add(apellido[i]);
            }

            listFullName.AddRange(listaNombre);
            listFullName.Add(' ');
            listFullName.AddRange(listaApellido);

            Console.Write("FullName: ");
           
            foreach (var full in listFullName)
            {
                Console.Write(full);
            }
        }
    }
}