//crie uma aplicacao que peca ao utilizador o seu nome completo e em seguida apresente todo em maiuculas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01{
    class Program{
        static void Main(string[]args){
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Nome em maiusculo: {nome.ToUpper()}");
        }
    }
}