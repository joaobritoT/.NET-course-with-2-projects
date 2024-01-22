//faca um programa que peca o nome completo do usuario e exiba todo em minusculas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02{
    class Program{
        static void Main(string[]args){
            string nome;

            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Nome em minusculo: {nome.ToLower()}");
        }
    }
}
