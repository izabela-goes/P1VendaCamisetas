using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda
    {
        #region Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Modelo{ get; set; }
        public string Preco { get; set; }
        public string Cliente { get; set; }
        public string Funcionario { get; set; }

        public const string INSERT = "INSERT INTO TB_VENDA (descricao, modelo, preco, idcliente, idfuncionario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
        public const string GETALL = "SELECT idvenda, descricao, modelo, preco, idcliente, idfuncionario FROM TB_VENDA";
        public const string UPDATE = "UPDATE TB_VENDA SET descricao = '{0}', modelo = '{1}', preco = '{2}', idcliente = '{3}', idfuncionario = '{4}' WHERE idvenda = {5}";
        public const string DELETE = "DELETE FROM TB_VENDA WHERE idvenda = {0}";
        public const string GETBYID = "SELECT idvenda, descricao, modelo, preco, idcliente, idfuncionario FROM TB_VENDA WHERE idvenda = {0}";

        #endregion

    }
}
