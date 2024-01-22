using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus{
    class Program{
        static void Main(string[]args){
            bool inicializadora = true;
            int opcao;

            while(inicializadora == true){
                Console.Clear();
                Console.WriteLine("Digite uma opcao: ");
                Console.WriteLine("1 - somar");
                Console.WriteLine("2 - subtrair");
                Console.WriteLine("3 - multiplicar");
                Console.WriteLine("4 - dividir");
                Console.WriteLine("0 - Sair do menu");

                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1){
                    Console.Clear();
                    Somar();
                    Console.ReadKey();
                }else if(opcao == 2){
                    Console.Clear();
                    Subtrair();
                    Console.ReadKey();
                }else if (opcao == 0){
                    break;
                }else if(opcao == 3){
                    Console.Clear();
                    Multiplicar();
                    Console.ReadKey();
                }else if(opcao == 4){
                    Console.Clear();
                    Dividir();
                    Console.ReadKey();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Opcao Invalida");
                    Console.ReadKey();
                }
                
            }
        }

        private static void Somar(){
            Console.Clear();
            Console.WriteLine("Digite o numero 1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos numeros eh de "+ (n1+n2));
        }

        private static void Subtrair(){
            Console.Clear();
            Console.WriteLine("Digite o numero 1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2");
            double n2 = double.Parse(Console.ReadLine());
            double subtracao = n1 - n2;
            Console.WriteLine("A subtracao dos numeros eh de "+ subtracao);
        }

        private static void Multiplicar(){
            Console.Clear();
            Console.WriteLine("Digite o numero 1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2");
            double n2 = double.Parse(Console.ReadLine());
            double multiplicacao = n1 * n2;
            Console.WriteLine("A multiplicacao dos numeros eh de "+ multiplicacao);
        }

        private static void Dividir(){
            Console.Clear();
            Console.WriteLine("Digite o numero 1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero 2");
            double n2 = double.Parse(Console.ReadLine());
            double divisao = n1 / n2;
            Console.WriteLine("A divisao dos numeros eh de "+ divisao);
        }
    }
}
