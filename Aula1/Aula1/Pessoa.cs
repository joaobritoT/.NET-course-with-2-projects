using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Pessoa
    {
        string nome;
        string cidade;
        int idade;
        string email;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Email { get => email; set => email = value; }

        public Pessoa()
        {
            nome = "";
            cidade = "";
            idade = 0;
            email = "";
        }

        public Pessoa(string nome, string cidade, int idade, string email)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.idade = idade;
            this.email = email;
        }

        public Pessoa(Pessoa p)
        {
            nome = p.nome;
            cidade = p.cidade;
            idade = p.idade;
            email = p.email;
        }



        public override string? ToString()
        {
            return "nome: " + nome + "\ncidade: " + cidade + "\nidade: " + idade + "\nemail: " + email;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
