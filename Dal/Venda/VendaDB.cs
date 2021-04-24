using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class VendaDB : IVendaDB
    {

        public List<Venda> GetAll()
        {
            string sql = Venda.GETALL;
            List<Venda> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Venda> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Venda>();

            while (returnData.Read())
            {
                var item = new Venda()
                {
                    Id = int.Parse(returnData["idvenda"].ToString()),
                    Descricao = returnData["descricao"].ToString(),
                    Modelo = returnData["modelo"].ToString(),
                    Preco = returnData["preco"].ToString(),
                    Cliente = returnData["idcliente"].ToString(),
                    Funcionario = returnData["idfuncionario"].ToString()
                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Venda venda)
        {
            bool status = false;
            string sql = string.Format(Venda.INSERT, venda.Descricao, venda.Modelo, venda.Preco, venda.Cliente, venda.Funcionario);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Venda SelectById(int id)
        {
            string sql = string.Format(Venda.GETBYID, id);
            Venda venda;

            using (var connection = new DB())
            {
                venda = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return venda;
        }

        public bool Update(Venda venda)
        {
            bool status = false;
            string sql = string.Format(Venda.UPDATE, venda.Descricao, venda.Modelo, venda.Preco, venda.Cliente, venda.Funcionario);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            string sql = string.Format(Venda.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}