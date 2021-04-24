using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone{ get; set; }
        public string Endereco { get; set; }

        public const string INSERT = "INSERT INTO TB_FUNCIONARIO (nome, telefone, endereco) VALUES ('{0}', '{1}', '{2}')";
        public const string GETALL = "SELECT idfuncionario, nome, telefone, endereco FROM TB_FUNCIONARIO";
        public const string UPDATE = "UPDATE TB_FUNCIONARIO SET nome = '{0}', telefone = '{1}', endereco = '{2}' WHERE idfuncionario = {3}";
        public const string DELETE = "DELETE FROM TB_FUNCIONARIO WHERE idfuncionario = {0}";
        public const string GETBYID = "SELECT idfuncionario, nome, telefone, endereco FROM TB_FUNCIONARIO WHERE idfuncionario = {0}";


        #endregion

    }
}
