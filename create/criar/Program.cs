using System;

namespace criar
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente("jose","55 55 5555-5555","ze@email.com");

            Console.WriteLine("cliente: " + cliente1.nome);
            Console.WriteLine("telefone: " + cliente1.telefone);
            Console.WriteLine("email: " + cliente1.email);

        }
    }
}
