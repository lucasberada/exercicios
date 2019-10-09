using System;
using bank;

namespace bank
{
    class Program
    {
       static void Main(string[] args)
        {

            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine("    bytebank - cadastro de clientes  ");
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.Write("digite o nome: ");
            string nome = Console.ReadLine();
           

            Console.Write("digite o CPF: ");
            string CPF = Console.ReadLine();

            Console.Write("digite o Email: ");
            string Email = Console.ReadLine();

            

            cliente cliente1 = new cliente(nome,CPF,Email);
            bool trocousenha = false;
            do{
                Console.Write("senha; ");
                string senha = Console.ReadLine();
                trocousenha = cliente1.TrocaSenha(senha);
                if (trocousenha){
                    Console.WriteLine("senha alterada com suscesso");
                } else {
                    Console.WriteLine("senha invalida");
                }
            }while(!trocousenha);







        }
    }
}
