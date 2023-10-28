using System;

namespace VectoresEjer1
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
             //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int[] vector = new int [10];
            int n, max = 0, acu = 0, posicion = 0;
            Console.WriteLine("Ingrese un numero: ");
            
            for (int x = 0; x < 10; x++)
            {
                n = int.Parse(Console.ReadLine());
                vector[x] = n;
                acu = vector[x];

                if (acu > max)
                {
                    max = acu;
                    posicion = x + 1;
                }
            
            
            }
            Console.WriteLine("El numero maximo es: " + max + " y su posicion es :" + posicion);
            

        }
    }
}
