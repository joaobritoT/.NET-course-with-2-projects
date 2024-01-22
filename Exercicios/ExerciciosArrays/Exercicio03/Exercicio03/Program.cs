//Faca um programa que receba 10 valores inteiros e os coloque em um vetor. Em seguida exiba os em ordem inversa a ordem de entrada

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03{
    class Program{
        static void Main(string[]args){
            int[] numeros = new int[10];

            for(int i=0;i<numeros.Length;i++){
                Console.WriteLine($"Digite o {i+1} numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numeros digitados ao contrario: ");
            for(int j = numeros.Length -1;j>=0;j--){
                Console.WriteLine(numeros[j]);
            }
        }
    }
}
