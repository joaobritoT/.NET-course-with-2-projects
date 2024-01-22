//faca um programa que guarde em um vetor os nomes de pelo menos 5 alunos da turma. adicione a funcionalidade de acessar o nome do aluno atraves do indice do vetor;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02{
    class Program{
        static void Main(string[]args){
            string[] alunos = new string[5];

            for(int i=0;i<alunos.Length;i++){
                Console.WriteLine($"Digite aluno numero {i}");
                alunos[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite o indice do aluno que deseja ver o nome (0-4)");
            int indice = int.Parse(Console.ReadLine());

            Console.WriteLine(alunos[indice]);
        }
    }
}


