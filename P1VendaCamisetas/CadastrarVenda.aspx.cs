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
    public partial class CadastrarVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Venda venda = getData();
            var db = new VendaDB();

            if (venda.Id == 0)
            {
                if (db.Insert(venda))
                {
                    lblMsg.Text = "Registro inserido!";
                }
                else
                    lblMsg.Text = "Erro ao inserir registro!";
            }
            else

                if (db.Update(venda))
            {
                lblMsg.Text = "Registro atualizado!";
            }
            else
                lblMsg.Text = "Erro ao atualizar registro!";

            LoadGrid();

        }

        private Venda getData()
        {
            return new Venda()
            {
                Descricao = txtDescricao.Text,
                Modelo = txtModelo.Text,
                Preco = txtPreco.Text,
                Cliente = txtIdCliente.Text,
                Funcionario = txtIdFuncionario.Text

            };
        }

        private void LoadGrid()
        {
            GVVenda.DataSource = new VendaDB().GetAll();
            GVVenda.DataBind();
        }

        protected void GVVenda_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVVenda.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new VendaDB();

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "ALTERAR")
            {
                Venda venda = db.SelectById(id);

                txtDescricao.Text = venda.Descricao;
                txtModelo.Text = venda.Modelo;
                txtPreco.Text = venda.Preco;
                txtIdCliente.Text = venda.Cliente;
                txtIdFuncionario.Text = venda.Funcionario;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}