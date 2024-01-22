


namespace SwitchCase{

    class Program{
        static void Main(String[]args){
            Console.Write("Escolha uma das seguintes opcoes:");
            Console.WriteLine("1- Criar um ficheiro");
            Console.WriteLine("2- abrir um ficheiro");
            Console.WriteLine("3- Gravar ficheiro");
            Console.WriteLine("4- Criar um ficheiro");
            Console.WriteLine("0- Sair");

            int op = int.Parse(Console.ReadLine());

            switch(op){
                case 1:
                    Console.WriteLine("OPCAO 1");
                    break;
                case 2:
                    Console.WriteLine("OPCAO 2");
                    break;
                case 3:
                    Console.WriteLine("OPCAO 3");
                    break;
                case 4:
                    Console.WriteLine("OPCAO 1");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("opcao invalida");
                    break;
            }
        }
    }
}