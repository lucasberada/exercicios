using System;
using reciclagem.interfaces;


namespace reciclagem.lista_de_lixos
{
    public class papelao :IPapel
    {
        public bool Papel()
        {
            Console.WriteLine("Este objeto e de papel entao descarte na lata azul.  ");
            return true;

        }
        
    }
}