using System;
using Agencia;

namespace Agencia
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine("   bytebank - cadastro de contas   ");
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");

            Console.Write("digite a agencia: ");
            string  agencia= Console.ReadLine();
        

            Console.Write("digite o conta: ");
            string numero = Console.ReadLine();

            Console.Write("digite o nome do titular da conta: ");
            string titular = Console.ReadLine();


            ContaCorrente contacorrente1 = new ContaCorrente(agencia,numero,titular);
            bool coontacorrente = false;
            do{
                Console.Write("saldo: ");
                string saldo = Console.ReadLine();
                coontacorrente = contacorrente1.ContaCorrente(titular);
                if (coontacorrente){
                    Console.WriteLine("conta criada com suscesso");
                } else {
                    Console.WriteLine("não é possivel cria conta pois seu saldo é negativo!");
                }
            }while(!coontacorrente);
             do{
                Console.Write("saldo: ");
                string saldo = Console.ReadLine();
                coontacorrente = contacorrente1.ContaCorrente(titular);
                if (coontacorrente){
                    Console.WriteLine("conta criada com suscesso");
                } else {
                    Console.WriteLine("não é possivel cria conta pois seu saldo é negativo!");
                }
            }while(!coontacorrente);

 do{
                Console.Write("saldo: ");
                string saldo = Console.ReadLine();
                coontacorrente = contacorrente1.ContaCorrente(titular);
                if (coontacorrente){
                    Console.WriteLine("conta criada com suscesso");
                } else {
                    Console.WriteLine("não é possivel realizar a operação!");
                }
            }while(!coontacorrente);








        }
    }
}
