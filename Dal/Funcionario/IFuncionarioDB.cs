using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IFuncionarioDB
    {
        bool Insert(Funcionario funcionario);
        bool Update(Funcionario funcionario);
        bool Delete(int id);
        Funcionario SelectById(int id);
        List<Funcionario> GetAll();
    }
}
