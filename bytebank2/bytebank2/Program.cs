using System;
using bytebank2.models;

namespace bytebank2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacorrente contacorrente1 = new Contacorrente(1,1, "alexandro");
            Contacorrente contacorrente2 = new Contacorrente(1,2, "alexandro");


            Depositarconta(contacorrente1);
            Depositarconta(contacorrente2);
            sacarconta(contacorrente1);
            sacarconta(contacorrente2);



        }
        
    }
}
