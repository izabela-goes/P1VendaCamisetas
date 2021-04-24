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
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = getData();
            var db = new ClienteDB();

            if (cliente.Id == 0)
            {
                if (db.Insert(cliente))
                {
                    lblMsg.Text = "Registro inserido!";
                }
                else
                    lblMsg.Text = "Erro ao inserir registro!";
            }
            else

                if (db.Update(cliente))
            {
                lblMsg.Text = "Registro atualizado!";
            }
            else
                lblMsg.Text = "Erro ao atualizar registro!";

            LoadGrid();

        }

        private Cliente getData()
        {
            return new Cliente()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,

            };
        }

        private void LoadGrid()
        {
            GVCliente.DataSource = new ClienteDB().GetAll();
            GVCliente.DataBind();
        }

        protected void GVCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GVCliente.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new ClienteDB();

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "ALTERAR")
            {
                Cliente cliente = db.SelectById(id);

                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone;
                txtEndereco.Text = cliente.Endereco;
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {


        }
    }
}

