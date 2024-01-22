// refaca o exercicio anterior, mas com a possibilidade do usuario escolher o indice de inicio e final de onde deseja apagar o nome


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07{
    class Program{
        static void Main(string[]args){
            string nome;
            int primeiro_indice;
            int segundo_indice;
            string new_name;

            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("digite o indice inicial de onde deseja apagar seu nome: ");
            primeiro_indice = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos caracteres deseja eliminar?: ");
            segundo_indice = int.Parse(Console.ReadLine());

            new_name = nome.Remove(primeiro_indice,segundo_indice+1);

            Console.WriteLine($"Novo nome: {new_name}");

        }
    }
}