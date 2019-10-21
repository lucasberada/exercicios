using System;
using reciclagem.interfaces;


namespace reciclagem.lista_de_lixos
{
    public class latinha :IMetal
    {
        public bool Metal ()
        {
            Console.WriteLine("este objeto e um metal entao descate na lata amarela.  ");
            return true;

        }
        
    }
}