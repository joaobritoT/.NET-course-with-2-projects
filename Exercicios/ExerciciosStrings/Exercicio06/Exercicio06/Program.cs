//crie uma aplicacao que peca ao utilizador o seu nome completo e em seguida elimine todo o conteudo a partir da posicao que o utilizador escolher

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06{
    class Program{
        static void Main(string[]args){
            string nome;
            int index;
            string new_name;
            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("a partir de qual indice deseja apagar o conteudo: ?");
            index = int.Parse(Console.ReadLine());

            while(index > nome.Length){
                Console.WriteLine("a partir de qual indice deseja apagar o conteudo: ?");
                index = int.Parse(Console.ReadLine());
            }

            new_name = nome.Remove(index);
            Console.WriteLine(new_name);
        }
    }
}