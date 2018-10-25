using System;
using System.Collections.Generic;
using System.Text;
using XF.MVVMBasic.Model;
using XF.MVVMBasic.Repository;

namespace XF.MVVMBasic.Business
{
    public class AlunoService
    {
        public List<Aluno> GetAlunos()
        {            
            return new AlunoRepository().GetAlunos();
        }
    }
}
