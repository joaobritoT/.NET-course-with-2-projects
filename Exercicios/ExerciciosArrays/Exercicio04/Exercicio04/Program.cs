/*faca um programa que leia 15 numeros, colocando eles em um vetor, calcule e exiba a media deles, em seguida o programa deve apresentar todos os valores armazenados no vetor 
que sao menores que a media*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04{
    class Program{
        static void Main(string[]args){
            double[] numeros = new double[15];

            for(int i =0;i<numeros.Length;i++){
                Console.WriteLine($"DIGITE O {i+1} NUMERO: ");
                numeros[i] = double.Parse(Console.ReadLine());

            }

            double soma = 0;
            foreach(double elemento in numeros){
                soma+=elemento;
            }
            double media = soma / numeros.Length;
            Console.WriteLine($"Media: {Math.Round(media,2)}");

            Console.WriteLine("numeros menores que a media:");
            foreach(double elemento in numeros){
                if(elemento<media){
                    Console.WriteLine(elemento);
                }
            }
        }
    }
}