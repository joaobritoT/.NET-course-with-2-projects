//recrie o exercicio anterior, mas agora dando a possibilidade do usuario escolher a letra que deseja remover do nome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04{
    class Program{
        static void Main(){
            string nome;
            string letra;
            string new_name;

            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();
            nome.ToLower();
            Console.WriteLine("Digite a letra que deseja apagar do seu nome: ");
            letra = Console.ReadLine();
            new_name = nome.Replace(letra,"");
            Console.WriteLine($"Nome sem a letra {letra}: {new_name}");
            

        }
    }
}
