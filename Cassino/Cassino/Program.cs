using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassino{
    class Program{
        static Random rnd = new Random();
        static double saldo = 100;
        static string nome ="";
        static void Main(string[]args){
            Console.WriteLine("Qual o seu nome: ");
            nome = Console.ReadLine();
            Console.ReadKey();
            int op = 1;
            while(op!=0){
                Console.Clear();
                Console.WriteLine($"Bem-Vindo {nome}");
                Console.WriteLine("Escolha uma das seguintes opcoes");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Ver saldo");
                Console.WriteLine("4 - Depositar");
                Console.WriteLine("5 - Sacar");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());

                switch(op){
                    case 0:
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinhas();
                        break;
                    case 3:
                        VerSaldo();
                        break;
                    case 4:
                        Depositar();
                        break;
                    case 5:
                        Sacar();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Raspadinhas(){
            int op = 1;
            while(op!=0){
                Console.Clear();
                Console.WriteLine("Menu raspadinhas");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Voltar");

                op = int.Parse(Console.ReadLine());

                if (op == 0){
                    break;
                }else if(op == 1){
                    RaspadinhaA();
                }else if(op == 2){
                    RaspadinhaB();
                }else{
                    Console.WriteLine("Opcao invalida");
                    Console.ReadKey();
                }
            }
        }

        private static void Loteria(){
            Console.Clear();
            int npremiado = rnd.Next(1000,10000);
            int njogador =0;
            while(njogador <1000 || njogador>9999){
                Console.WriteLine("Qual numero quer jogar?(1000 - 9999) ");
                njogador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("bilhete premiado: "+npremiado);
            if(npremiado == njogador){
                Console.WriteLine("Parabens, voce ganhou o primeiro premio!!");
                saldo +=100;
            }else if(npremiado % 1000 == njogador %1000){
                Console.WriteLine("Voce ganhou o segundo lugar");
                saldo+=50;
            }else if(npremiado % 100 == njogador %100){
                Console.WriteLine("Voce ganhou o terceiro lugar");
                saldo+=25;
            }else{
                Console.WriteLine("Seu bilhete nao foi premiado");
            }
            
            saldo-=5;
            Console.WriteLine($"Seu saldo final eh de R${saldo}");
            Console.ReadKey();
            
        }

        private static void RaspadinhaA(){

            Console.Clear();

            int nprincipal = rnd.Next(1,10);
            int n1 = rnd.Next(1,10); int p1 = rnd.Next(1,100);
            int n2 = rnd.Next(1,10); int p2 = rnd.Next(1,100);
            int n3 = rnd.Next(1,10); int p3 = rnd.Next(1,100);
            int n4 = rnd.Next(1,10); int p4 = rnd.Next(1,100);
            int n5 = rnd.Next(1,10); int p5 = rnd.Next(1,100);

            Console.WriteLine("Numero principal: "+nprincipal);
            Console.WriteLine($"1 numero:{n1}-(R${p1})");
            Console.WriteLine($"2 numero:{n2}-(R${p2})");
            Console.WriteLine($"3 numero:{n3}-(R${p3})");
            Console.WriteLine($"4 numero:{n4}-(R${p4})");
            Console.WriteLine($"5 numero:{n5}-R$({p5})");

            int premio = 0;

            if(n1 == nprincipal) premio+=p1;
            if(n2 == nprincipal) premio+=p2;
            if(n3 == nprincipal) premio+=p3;
            if(n4 == nprincipal) premio+=p4;
            if(n5 == nprincipal) premio+=p5;

            Console.WriteLine("Premio: " + premio);
            
            saldo+=premio;
            saldo -=2;
            Console.WriteLine($"Seu saldo final eh de R${saldo}");
            Console.ReadKey();
        }

        private static void RaspadinhaB(){
            int nprincipal = rnd.Next(1,10);
            int premio = rnd.Next(1,100);

            List<int> sorteados = new List<int>();
            for(int i=0;i<10;i++){
                sorteados.Add(rnd.Next(1,10));
            }
            Console.WriteLine($"Numero principal: {nprincipal}");
            Console.WriteLine("numeros sorteados: ");
            int contains =0;
            for(int i=0;i<sorteados.Count();i++){
                Console.WriteLine(sorteados[i]);
                if(nprincipal == sorteados[i]){
                    contains +=1;
                }
            }
            if(contains>=3){
                Console.WriteLine($"Voce ganhou {premio} reais");
                saldo+=premio;
            }
            else{
                Console.WriteLine("O numero principal precisa ser sorteado 3 vezes para voce ganhar");
            }
            Console.WriteLine($"o numero principal apareceu {contains} vezes");
            
            saldo-=2;
            Console.WriteLine($"Seu saldo final eh de R${saldo}");
            Console.ReadKey();
        }

        private static void VerSaldo(){
            Console.Clear();
            Console.WriteLine($"Seu saldo eh de R${saldo}");
            Console.ReadKey();
        }

        private static void Depositar(){
            Console.Clear();
            Console.WriteLine("DIGITE O VALOR QUE DESEJA DEPOSITAR: ");
            int valor = int.Parse(Console.ReadLine());
            while(valor<0){
                Console.WriteLine("DIGITE O VALOR QUE DESEJA DEPOSITAR: ");
                valor = int.Parse(Console.ReadLine());
            }
            saldo+=valor;
            Console.WriteLine("Valor depositado");
            Console.ReadKey();
            
        }

        private static void Sacar(){
            Console.Clear();
            Console.WriteLine($"saldo: R${saldo}");
            if(saldo > 0){
                Console.WriteLine("Digite o valor que deseja sacar: ");
                int valor = int.Parse(Console.ReadLine());
                while(valor > saldo){
                    Console.WriteLine("Saldo insuficiente, digite um saldo valido");
                    valor = int.Parse(Console.ReadLine());

                }
                saldo-=valor;
            }else{
                Console.WriteLine("Saldo insuficiente");
            }
            Console.WriteLine("Saque efetuado");
            Console.ReadKey();
        }

    }
}
