// refaca o exercicio anterior mas agora escrevendo o nome ao contrario;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09{
    class Program{
        static void Main(string[]args){
            string nome;
            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();

            string[] array = nome.Split(' ');

            Array.Reverse(array);
            Console.WriteLine("-----------------");
            foreach(string elemnto in array){
                Console.WriteLine(elemnto);
            }

        }
    }
}
