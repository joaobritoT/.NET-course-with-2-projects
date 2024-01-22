using System;
using GestaoPessoas;

namespace ExemploCL
{
    class Program()
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("joao");
            Console.WriteLine(p1.nome);
        }
    }
}