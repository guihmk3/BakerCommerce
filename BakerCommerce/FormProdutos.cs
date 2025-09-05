using BakerCommerce.Model;
using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {
        Model.Usuario Usuario;
        int idselecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            ListarCategoriasCmb();
            atualizarDgv();
        }

        public void atualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            // mostar as informações do bd no datagridview:
            dgvProdutos.DataSource = produto.Listar();
        }
        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // tabela p/receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1 - Salgados
                // 2 - Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // válidar campos:
            if (txbNomeCadastro.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastro.Text.Length < 1)
            {
                MessageBox.Show("O Preço deve ter no mínimo 1 caracter.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastro.Text.Length < 1)
            {
                MessageBox.Show("a categoria deve ter no mínimo 1 caracteres.",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Produto ProdutoCadastro = new Model.Produto();
                // salvar os valores dos campos nos atributos do obj:
                ProdutoCadastro.Nome = txbNomeCadastro.Text;
                ProdutoCadastro.preco = int.Parse(txbPrecoCadastro.Text);

                // peguei a categoria selecionada
                string categoriaSelecionada = cmbCategoriaCadastro.Text;
                // dividi ele em partes o id que eu preciso vem antes do - então o id ficou na parte 0
                string[] partes = categoriaSelecionada.Split('-');
                int idCategoria = int.Parse(partes[0]);
                ProdutoCadastro.IdCategoria = idCategoria;

                ProdutoCadastro.IdRespCadastro = Usuario.Id;
                // executar o insert:
                if (ProdutoCadastro.cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dgv
                    atualizarDgv();

                    //apagar os campos de cadastro
                    txbNomeCadastro.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.Items.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o Usuario!",
                      "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {
            // atualizar o dgv
            atualizarDgv();
            //limpar campos de exibição
            txbPrecoEditar.Clear();
            txbNomeEditar.Clear();
            cmbCategoriaCadastro.Items.Clear();

            //retornar o id selecionado para 0
            idselecionado = 0;

            //retornar o texto padrão do "apagar"
            lblApagarProduto.Text = "Selecione um Produto para Apagar";

            //desabilitar os grb
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }
        private void btnCadastrarEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text.Length < 1)
            {
                MessageBox.Show("O Preço deve ter no mínimo 1 caracter.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastro.Text.Length < 1)
            {
                MessageBox.Show("A categoria deve ter no mínimo 1 caractere.",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a Edição:
                Model.Produto produtoEditar = new Model.Produto();

                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.preco = int.Parse(txbPrecoCadastro.Text);

                string categoriaSelecionada = cmbCategoriaCadastro.Text;
                string[] partes = categoriaSelecionada.Split('-');
                int idCategoria = int.Parse(partes[0]);

                produtoEditar.IdCategoria = idCategoria;
                produtoEditar.IdRespCadastro = Usuario.Id;

                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar usuário", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // perguntar se realmente quer apagar
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este Produto?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // prosseguir com a exclusão...
                Model.Produto ProdutoApagar = new Model.Produto();

                ProdutoApagar.Id = idselecionado;
                if (ProdutoApagar.Apagar())
                {
                    MessageBox.Show("Produto Apagado com sucesso", "Show",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar Produto.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada
            int Ls = dgvProdutos.SelectedCells[0].RowIndex;

            // colocar os valores das celulas nos txb de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[Ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[Ls].Cells[2].Value.ToString();

            //ARMAZENAR O ID DE QUEM FOI SELECIONADO 
            idselecionado = (int)dgvProdutos.Rows[Ls].Cells[0].Value;

            //ajustar no gtbapagar:
            lblApagarProduto.Text = $"Apagar: {dgvProdutos.Rows[Ls].Cells[1].Value.ToString()}";
            //ativar o grbApagar
            grbApagar.Enabled = true;
        }
    }
}

