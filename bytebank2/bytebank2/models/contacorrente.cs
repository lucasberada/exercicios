using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.models
{
    public class Contacorrente : Contabancaria
    {
        public Contacorrente(int agencia, int numeroconta,string titular) :base(agencia,numeroconta,titular)
        {

        }

        public override bool saque(double valor)
        {
            if (valor >=0)
            {
                if(valor <=this.saldo)
                {
                    this.saldo -=valor;
                    return true;
                
                }else {
                    return false;
                }
                return false;

            }
        }
       
    }
}