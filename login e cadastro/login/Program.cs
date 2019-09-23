using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string admlogin = " admin";
            string admpasswd = " admin";

            Console.Write("entre com o usuario: ");
            string login = Console.ReadLine();
            Console.Write("entre com a senha: ");
            string passwd = Console.ReadLine();

            if ((login == admlogin) && passwd == admpasswd){
                Console.WriteLine("Bam vindo admin");

            }else{
                Console.WriteLine("Bem vindo usuario");
            }







        }
    }
}
