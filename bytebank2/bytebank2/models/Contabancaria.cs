using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank2.models
{
    public abstract class Contabancaria
    {
        public string Titular;
        public int agencia;
        public int NumeroConta;
        public double Saldo;

        public Contabancaria(int agencia, int NumeroConta, string Titular)
        {
            this.agencia =agencia;
            this.NumeroConta=NumeroConta;
            this.Titular=Titular;
            this.Saldo =0.0;
        }
        public  abstract bool saque(double valor);

         public bool deposito(double valor)
        {
            if(valor >=0)
            {
                this.Saldo+=valor;
                return true;
            }
            return false;

        }
         public bool transferencia(Contabancaria destino,double valor)
        {
            if (this.saque(valor))
            {
                destino.deposito(valor);
                return true;
            } else 
            {
                return false;
            }

        }

    }

}