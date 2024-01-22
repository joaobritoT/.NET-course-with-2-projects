//faca um programa que peca ao utilizador 3 notas, guarde-as num vetor e apresente a media final lendo as notas do vetor

using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio01{
    class Program{
        static void Main(string[]args){
            int[] notas = new int[3];
            for(int i=0;i<3;i++){
                Console.WriteLine($"Digite a {i+1} nota");
                int nota = int.Parse(Console.ReadLine());
                notas[i] = nota;
            }

            int soma=0;

            Console.WriteLine("notas:");

            foreach(int elemento in notas){
                soma+=elemento;
                Console.WriteLine(elemento);
            }

            double media = soma / notas.Length;
            Console.WriteLine($"media: {media}");
        }
    }
}