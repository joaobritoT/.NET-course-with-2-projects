// faca um programa que leia o nome completo do usuario e armazene separadamente em um array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08{
    class Program{
        static void Main(string[]args){
            string nome;
            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine();
            string[] array = nome.Split(' ');
            Console.WriteLine("----------------");
            foreach(string elemento in array){
                Console.WriteLine(elemento);
            }


        }
    }
}
