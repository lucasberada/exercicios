using System;
using reciclagem.interfaces;

namespace reciclagem.lista_de_lixo
{
    public class GarrafaPET :IPlastico
    {
        public bool Plastico()
        {
            Console.WriteLine("Este objeto é de plastico então descarte na lata vermelha.  ");
            return true;

        }
        
    }
}