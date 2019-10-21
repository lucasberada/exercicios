using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.models
{
    public class contaespecial : Contabancaria
    {
        public double limite;
        public contaespecial(int agencia, int numeroconta,string titular) :base(agencia,numeroconta,titular)
        {
            limite =0.0;

        }
        public bool SetLimite(double valor)
        {
            if(valor >= 0)
            {
                limite=valor;
                return true;

            }
            return false;

        }
         public override bool saque(double valor)
         {
            if(valor >=0)
            {
                if(valor <=Saldo+limite)
                {
                    Saldo-=valor ;
                    return true;

                }
            }
            return false;
         }

       
    }
}