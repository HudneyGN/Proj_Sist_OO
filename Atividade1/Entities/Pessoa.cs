using System;

namespace Atividade1.Entities
{
    class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public virtual string Identificacao()
        {
            return "Aluno" + Nome; 
               
        }
      
    }
}
