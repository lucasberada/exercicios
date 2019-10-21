using System;
using reciclagem.interfaces;


namespace reciclagem.lista_de_lixos
{
    public class Guardachuva :Iindefinido
    {
        public bool LixoIndefinido()
        {
            Console.WriteLine("Este objeto não tem uma definição exata então descarte na lata cinza.  ");
            return true;
        }
        
    }
}