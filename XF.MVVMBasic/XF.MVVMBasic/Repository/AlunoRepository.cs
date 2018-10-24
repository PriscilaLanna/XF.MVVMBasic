using System;
using System.Collections.Generic;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.Repository
{
    public class AlunoRepository
    {
        public List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(new Aluno() { Id = Guid.NewGuid(), RM = "313131", Nome = "Priscila", Email = "priscila@teste.com" });
            alunos.Add(new Aluno() { Id = Guid.NewGuid(), RM = "313131", Nome = "Priscila", Email = "priscila@teste.com" });
            alunos.Add(new Aluno() { Id = Guid.NewGuid(), RM = "313131", Nome = "Priscila", Email = "priscila@teste.com" });
            alunos.Add(new Aluno() { Id = Guid.NewGuid(), RM = "313131", Nome = "Priscila", Email = "priscila@teste.com" });

            return alunos;
        }
    }
}
