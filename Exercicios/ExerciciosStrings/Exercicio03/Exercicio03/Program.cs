// crir um programa que peca ao utiliziador o seu nome completo e de seguida o apresente eliminando a letra A sempre que esta aparecer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03{
    class Program{
        static void Main(string[]args){
            string nome;
            string new_name;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            new_name = nome.Replace("a","");
            Console.WriteLine($"Nome sem a letra A: {new_name}");
        }
    }
}
