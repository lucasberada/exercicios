using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {   
            int ano =0;
            int idade =0;


           do {
            Console.WriteLine("digite o  seu ano de nascimento");
            ano=int.Parse(Console.ReadLine());

           } while (ano > 2021);
            idade = 2019 -ano ;

        


           
           if(idade <3) {
            Console.WriteLine("recen nascido");
           }else if((idade >=3)&& (idade<=11)){
               Console.WriteLine("criança");
           } else if((idade >=12)&& (idade<=24)){
               Console.WriteLine("adolescente");
           } else if((idade >=25)&& (idade<=60)){
               Console.WriteLine("adulto");
           } else if(idade >61){
               Console.WriteLine("idoso");
           }
           

        }
    }
}
