using System;

namespace senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {       System.Console.WriteLine("***************************");
                System.Console.WriteLine("digite uma opcao");
                System.Console.WriteLine("***************************");
                System.Console.WriteLine();
                System.Console.WriteLine("1-Cadastrar aluno");
                System.Console.WriteLine("2-remover aluno");
                System.Console.WriteLine("3-alocar aluno");
                System.Console.WriteLine("4-remover aluno");
                System.Console.WriteLine("5-verificar salas"); 
                System.Console.WriteLine("6-verificar salas"); 
                System.Console.WriteLine("0-sair");

                int opcao =0;

                opcao =int.Parse(Console.ReadLine());



                    switch(opcao)
                    {
                    case 1:
                    CadastrarAluno();


                    break;


                    case 2:
                    RemoverAluno();

                    break;


                    case 3:
                    CadastrarAluno();

                    break;


                    case 4:
                    CadastrarAluno();

                    break;


                    case 5:

                    break;


                    case 6:

                    break;


                    case 0:

                    Console.WriteLine("tchau!");

                    break;


                    default:
                    System.Console.WriteLine("opção invalida");
                    Console.ReadLine();
                    
                    break;
                }
        }
            public static void CadastrarAluno()

            {
                                Console.Clear();

                System.Console.WriteLine("Nome do aluno:");
                string Nome=Console.ReadLine();
                Console.Clear();
                System.Console.WriteLine("curso:");
                string curso =Console.ReadLine();
                                Console.Clear();

                System.Console.Write("data de nascimento:");
                string datanascimento =Console.ReadLine();
                                Console.Clear();

                System.Console.Write("numero da sala:");
                string numerosala =Console.ReadLine();
            }

            public static void RemoverAluno()
            {   Console.Clear();
                System.Console.WriteLine("Nome do aluno que deseja remover:  ");
                string Nome = Console.ReadLine();
            }


    }
}
