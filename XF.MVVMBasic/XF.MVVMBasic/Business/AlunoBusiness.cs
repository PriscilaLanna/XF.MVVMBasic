using System;
using System.Collections.Generic;
using System.Text;
using XF.MVVMBasic.Model;
using XF.MVVMBasic.Repository;

namespace XF.MVVMBasic.Business
{
    public class AlunoBusiness
    {
        public List<Aluno> GetAlunos()
        {
            AlunoRepository repository = new AlunoRepository();

            return repository.GetAlunos();
        }
    }
}
