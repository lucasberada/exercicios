using System;

namespace Sala
{
     class Sala
    {
            public int capacidadeTotal;
            public int capacidadeAtual;
            public int numerosala;
            public string[] Alunos;
            public Sala (int numerosala,int capacidadeTotal)
            {
                this.numerosala=numerosala;
                this.capacidadeTotal=capacidadeTotal;
                this.capacidadeAtual=this.capacidadeTotal;
                this.Alunos =new string[capacidadeTotal];

            }
            public string AlocarAluno(string nomealuno)
            {
                int index =0;

                if(this.capacidadeAtual >0)
                {
                    foreach(string aluno in this.Alunos)
                    {
                        if (aluno =="")
                        {
                            this.Alunos[index] = nomealuno;
                            break;
                        }
                        index++;
                    }
                    this.capacidadeAtual--;
                    return"oK";
                }else{
                    return" Sala lotada não foi possivel alocar o aluno";
                }
            }



            public string RemoverAluno(string nomealuno)
            {
                int index = 0;
                if(this.capacidadeAtual == this.capacidadeTotal)
                {
                    return "sala vazia";
                }


                foreach(string aluno in this.Alunos)
                {
                    if(nomealuno == aluno)
                    {
                        this.Alunos[index] ="";
                        return"ok";

                    }
                    index ++;
                }
                return "NAOENCONTRADO";

            }
            public string MostrarAlunos()
            {
                string ListaAlunos="";
                foreach (string aluno in this.Alunos)
                {
                    if (aluno !="")
                    {
                        ListaAlunos =ListaAlunos + aluno +",";
                    }
                }
                return ListaAlunos;
            }
                    
    }
    
}
