using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num = 0;

            do{

            
            Console.WriteLine("digite o nnumero");
            num = int.Parse (Console.ReadLine());

            if ((num % 2 )== 0){
             Console.WriteLine("esse é um número par");
            }  else {
             Console.WriteLine("esse e um número impar");
            }
            }

            while (num != 0);
            

            
            
            
 



        }
    }
}
