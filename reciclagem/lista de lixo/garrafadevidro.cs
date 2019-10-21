using System;
using reciclagem.interfaces;

namespace reciclagem.lista_de_lixo
{
    public class Garrafadevidro :IVidro
    {
        public bool vidro()
        {
            Console.WriteLine("Este objeto é de vidro então descarte na lata verde.  ");
            return true;
        }
        
    }
    
}