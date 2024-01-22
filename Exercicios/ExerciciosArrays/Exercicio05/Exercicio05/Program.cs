//usando algoritimo bubble-sort

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio05{
    class Program{
        static int[] numeros;
        static Random rnd;
        static void Main(string[]args){

            rnd = new Random();
            numeros = new int[5];
            // preenchendo o array com nms aleatorios:

            for(int i = 0; i < numeros.Length; i++){
                numeros[i] = rnd.Next(1,100);
            }
            // imprimir sem ordenacao:
            Console.WriteLine(" ----- ORDEM INICIAL -----");
            Imprimir();
            Console.WriteLine();
            // Imprimir ordenado crescente:
            Console.WriteLine(" ----- ORDEM CRESCENTE -----");
            OrdenarCresente();
            Imprimir();
            Console.WriteLine();
            // Imprimir ordenando descrescte:
            Console.WriteLine(" ----- ORDEM DECRESCENTE -----");
            OrdenarDecresente();
            Imprimir();
            Console.WriteLine();

        }
        private static void Imprimir(){
            foreach(int elemento in numeros){
                Console.WriteLine(elemento);
            }
        }

        private static void OrdenarCresente(){
            for(int i = 0; i < numeros.Length; i++){
                for(int j = i+1; j<numeros.Length;j++){
                    if(numeros[i]>numeros[j]){
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
        }

        private static void OrdenarDecresente(){
            for(int i = 0; i < numeros.Length; i++){
                for(int j = i+1; j<numeros.Length;j++){
                    if(numeros[i]<numeros[j]){
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
        }
    }
}
