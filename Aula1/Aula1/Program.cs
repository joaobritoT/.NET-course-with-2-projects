using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa("joao", "sp", 20, "joaobrito265@outlook.com");
            Pessoa p3 = new Pessoa(p2);
            p3.Nome = "pedro";

            Console.WriteLine(p1.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(p2.ToString());
            Console.WriteLine("====================");
            Console.WriteLine(p3.Email);
            Console.WriteLine("========has1========");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine("========has2========");
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine("========has3========");
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p1));
        }
    }
}