using System;

namespace Atividade1.Entities
{
    class Aluno : Pessoa 
    {
        public string RA { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, string ra) 
            : base (nome)
        {
            this.RA = ra;
        }
        public  string IdentificarAluno()
        {
            return base.Identificacao() 
                + this.Nome
                + ", "
                + this.RA;
        }
    }
}
