using System;

namespace bank
{
    public class ContaCorrente
    {

        public cliente Titular{get;set;}
        public int agencia{get;set;}
        public int numero{get;set;}
         double saldo{get;set;}

        public ContaCorrente(int agencia, int numero, cliente Titular){
            this.agencia=agencia;
            this.numero=numero;
            this.Titular=Titular;
            this.saldo =0.0;
        }

        public double deposito(double valor){
            return this.saldo +=valor;       
            }


            public  bool  saque (double valor) {
        if ( this.saldo  >  valor ) {
            this.saldo -=  valor ;
            return  true ;
        } else {
            return false ;
        }

         }


}
