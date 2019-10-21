using System;
using reciclagem.interfaces;
using reciclagem.lista_de_lixo;

namespace reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao =0;

            Console.WriteLine("##############################");
            Console.WriteLine("BEM VINDO AO SELETOR DE LIXO");
            Console.WriteLine("##############################");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("digite a opção que seseja:  ");
            Console.WriteLine("1-garrafa PET ");
            Console.WriteLine("2-garrafa de vidro ");
            Console.WriteLine("3-frutas");
            Console.WriteLine("4-latinha");
            Console.WriteLine("5-guarda chuva");
            Console.WriteLine("6-papelao");
            Console.WriteLine("7-pote de manteiga");
            Console.ReadLine();


             GarrafaPET GarrafaPET =new GarrafaPET();

            switch (opcao){
                    case 1:
                       GarrafaPET .Plastico();
                        break;
                    case 2:
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.ReadLine();
                        break;
                }

        }
    }
}


