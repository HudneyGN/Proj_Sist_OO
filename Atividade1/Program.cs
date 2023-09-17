using System;
using Atividade1.Entities;

namespace Atividade1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Entre com os dados do Aluno: ");
            Console.Write("RA");
            string ra = Console.ReadLine();
            Console.WriteLine("Nome");
            string nome = Console.ReadLine();

            Console.WriteLine(aluno.IdentificarAluno());
        }      
        
    }
}