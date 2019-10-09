using System;

namespace Agencia
{
    public class ContaCorrente
    {

        public string titular;
        public string numero;
        public string agencia;
        public string saldo;

        public ContaCorrente(string Titular, string agencia, string numero){
            this.titular = Titular;
            this.agencia= agencia;
            this.numero= numero;
            this.saldo= 0.0;
        }

        public double deposito(double valor){
            return this.saldo +=valor;
        }

        public bool saque(double valor){
            if(this.saldo > valor){
                this.saldo -= valor;
                return true;
            }else{
                return false;
            }

        }

        public bool transferencia(ContaCorrente contadestino,double valor){
            if(this.saque(valor)){
                contadestino.deposito(valor);
                return true;
            } else {
                return false;
            }
        }

        


}

}