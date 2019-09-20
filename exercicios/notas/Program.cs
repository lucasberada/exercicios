using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 ,num2, num3, num4, media ;
            
            

            Console.WriteLine("nota 1");
            num1 = double.Parse (Console.ReadLine());
            Console.WriteLine("nota 2");
            num2 = double.Parse  (Console.ReadLine());
            Console.WriteLine("nota 3");
            num3 = double.Parse  (Console.ReadLine());
            Console.WriteLine("nota 4");
            num4 = double.Parse  (Console.ReadLine());

            media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("sua media é " + media);

            if (media >= 7){

             Console.WriteLine("Aluno aprovado!");
            }

            if (media < 7){

             Console.WriteLine("Aluno Reprovado!");
            }






        }     
    }
}
