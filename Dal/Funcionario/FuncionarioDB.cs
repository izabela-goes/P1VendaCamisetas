using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FuncionarioDB : IFuncionarioDB
    {

        public List<Funcionario> GetAll()
        {
            string sql = Funcionario.GETALL;
            List<Funcionario> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Funcionario> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Funcionario>();

            while (returnData.Read())
            {
                var item = new Funcionario()
                {
                    Id = int.Parse(returnData["idfuncionario"].ToString()),
                    Nome = returnData["nome"].ToString(),
                    Telefone = returnData["telefone"].ToString(),
                    Endereco = returnData["endereco"].ToString(),
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Funcionario funcionario)
        {
            bool status = false;
            string sql = string.Format(Funcionario.INSERT, funcionario.Nome, funcionario.Telefone, funcionario.Endereco);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Funcionario SelectById(int id)
        {
            string sql = string.Format(Funcionario.GETBYID, id);
            Funcionario funcionario;

            using (var connection = new DB())
            {
                funcionario = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return funcionario;
        }

        public bool Update(Funcionario funcionario)
        {
            bool status = false;
            string sql = string.Format(Funcionario.UPDATE, funcionario.Nome, funcionario.Telefone, funcionario.Endereco);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Funcionario.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}