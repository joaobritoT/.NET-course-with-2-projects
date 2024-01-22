using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExemploArray{
    class Program{
        static void Main(string[]args){

            string nome1= "ana";
            string nome2 = "jose";
            string nome3 = "afonso";

            string[] nomes = new string[]{"ana","jose","afonso"};
           
            foreach(string element in nomes){
                Console.WriteLine(element);
            }

            Random rnd = new Random();
            int[] numeros = new int[10];

            for(int i=0;i<numeros.Length;i++){
                numeros[i] = rnd.Next(1,100);
            }

            int[,] tabuada = new int[10,10];

            for(int i = 0;i<10;i++){
                for(int j = 0; j<10; j++){
                    tabuada[i,j]  = (i + 1) * (j + 1);
                    Console.WriteLine(tabuada[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}