using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public const string INSERT = "INSERT INTO TB_CLIENTE (nome, telefone, endereco) VALUES ('{0}', '{1}', '{2}')";
        public const string GETALL = "SELECT idcliente, nome, telefone, endereco FROM TB_CLIENTE";
        public const string UPDATE = "UPDATE TB_CLIENTE SET nome = '{0}', telefone = '{1}', endereco = '{2}', WHERE idcliente = {3}";
        public const string DELETE = "DELETE FROM TB_CLIENTE WHERE idcliente = {0}";
        public const string GETBYID = "SELECT idcliente, nome, telefone, endereco, FROM TB_CLIENTE WHERE idcliente = {0}";


        #endregion

    }
}
