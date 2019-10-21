using System;
using reciclagem.interfaces;


namespace reciclagem.lista_de_lixos
{
    public class Potedemanteiga :IPlastico
    {
        public bool Plastico()
        {
            Console.WriteLine("esse objeto e de plastico entao descarte no vermelho.   ");
            return true;
        }
        
    }
}