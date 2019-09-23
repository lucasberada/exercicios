using System;

namespace menuex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcao = "";
            
            Console.WriteLine("Calcular a área");
            Console.WriteLine("1- Triângulo");
            Console.WriteLine("2- Quadrado");
            Console.WriteLine("3- Losango");
            Console.WriteLine("4- TRAPEZIO");
            Console.WriteLine("RETANGULO");
            Console.WriteLine("CIRCULO");




            switch(opcao){
                case "1":
                    Console.WriteLine("Área do Triângulo");
                    Console.WriteLine("Coloque a base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Coloque a Altura: ");
                    double altTri = double.Parse(Console.ReadLine());
                    double areaTri = (baseTri * altTri) / 2;
                    Console.WriteLine("A área do Triângulo é: " + areaTri);
                    break;

                case "2":   
                    Console.WriteLine("Área do Quadrado");
                    Console.Write("Qual o lado do Quadrado?? ");
                    double ladoQuad = double.Parse(Console.ReadLine());
                    double areaQuad = (ladoQuad * ladoQuad * ladoQuad * ladoQuad);
                    Console.WriteLine(" A área é + areaQuad");
                    break;
            }

        }
    }
}
