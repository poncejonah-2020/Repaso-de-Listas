using System;
using System.Collections.Generic;

namespace listasRepaso
{
    /// <summary>
    /// Empezando a trabajar con listas
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumerosUno = new List<int>(); /// Declaracion de una lista de enteros
            listaNumerosUno.Add(1);                ///Agregacion de elementos a la lista
            listaNumerosUno.Add(2);
            listaNumerosUno.Add(3);
            listaNumerosUno.Add(4);

            foreach (int numero in listaNumerosUno)///Iteracion de la lista
            {
                Console.WriteLine(numero);///Impresion por pantalla de la lista
            }



            List<int> listaNumerosDos = new List<int> { 6, 7, 8, 9, 10 };///Otra manera de declarar una lista

            foreach (int numero in listaNumerosDos)///Iteracion de la lista
            {
                Console.Write(numero);///Impresion por pantalla de la lista
            }
        }
    }
}


