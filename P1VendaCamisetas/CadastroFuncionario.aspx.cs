using System;
using Dal;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace P1VendaCamisetas
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = getData();
            var db = new FuncionarioDB();

            if (funcionario.Id == 0)
            {
                if (db.Insert(funcionario))
                {
                    lblMsg.Text = "Registro inserido!";
                }
                else
                    lblMsg.Text = "Erro ao inserir registro!";
            }
            else

                if (db.Update(funcionario))
            {
                lblMsg.Text = "Registro atualizado!";
            }
            else
                lblMsg.Text = "Erro ao atualizar registro!";

            LoadGrid();

        }

        private Funcionario getData()
        {
            return new Funcionario()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,

            };
        }

        private void LoadGrid()
        {
            GVFuncionario.DataSource = new FuncionarioDB().GetAll();
            GVFuncionario.DataBind();
        }

        protected void GVFuncionario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVFuncionario.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new FuncionarioDB();

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "ALTERAR")
            {
                Funcionario funcionario = db.SelectById(id);

                txtNome.Text = funcionario.Nome;
                txtTelefone.Text = funcionario.Telefone;
                txtEndereco.Text = funcionario.Endereco;
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {


        }
    }
}