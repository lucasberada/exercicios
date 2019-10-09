using System;

namespace bank
{
    public class cliente
    {

        public string CPF;
        public string nome;
        public string Email;
        public string senha;

        public cliente(string nome, string CPF, string Email){
            this.nome =nome;
            this.CPF = CPF;
            this.Email= Email;
        }

        public bool TrocaSenha(string senha){
            if ((senha.Length > 6)&& (senha.Length < 16)){
                this.senha =senha;
                    return true;
            }else {
                return false;
            }
        }


}

}