using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double  salario ,aumento;



            Console.WriteLine("digite seu salario");
            salario = double.Parse (Console.ReadLine());
            aumento = (salario * 0.3);

            if(salario 500){
             Console.WriteLine("não tem direito ao aumento");
            }

            else if ( salario =500 )
             Console.WriteLine("tem direito ao aumento");



          
        }
    }
}
