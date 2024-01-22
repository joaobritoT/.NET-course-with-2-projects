// faca um exercicio que a pessoa digite seu nome completo e escolha qual letra quer tirar ate que o nome seja apagado por completo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio05{
    class Program{
        static void Main(string[]args){
            string name;
            string letra;

            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();

            while(name.Length>1){
                Console.WriteLine("Digite a letra do nome que deseja apagar:");
                letra = Console.ReadLine();
                if(name.Contains(letra)){
                    name = name.Replace(letra,"");
                    Console.WriteLine("novo nome: "+name);
                }else{
                    Console.WriteLine("Letra nao encontrada");
                    continue;
                }
                
            }
        }
    }
}
