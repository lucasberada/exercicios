using System;
using reciclagem.interfaces;

namespace reciclagem.lista_de_lixo
{
    public class frutas :IOrganico
    {
        public bool Organico ()
        {
            Console.WriteLine("Este objeto é organico então descarte na lata marrom.  ");
            return true;
        }
        
    }
    
}