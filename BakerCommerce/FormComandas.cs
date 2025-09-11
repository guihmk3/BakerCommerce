using BakerCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;

        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        { 
       Model.Produto produto = new Model.Produto();
           dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // pegar a linha selecionada
                int Ls = dgvProdutos.SelectedCells[0].RowIndex;

                // colocar os valores das celulas nos txb de edição:
                txbCodProduto.Text = dgvProdutos.Rows[Ls].Cells[0].Value.ToString();
                // colocar o nome do produto no campo de informaçoes
                txbProduto.Text = dgvProdutos.Rows[Ls].Cells[1].Value.ToString();

              
            }
        }

        private void btnContinuarInfo_Click(object sender, EventArgs e)
        {
            if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCodProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do Produto",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               // Desativar o grbInfos
               grbInformacoes.Enabled = false;
                // Ativar o grblançamento
                grbLancamento.Enabled = true;
                }
            }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // verificar se a quantidade foi preenchida
            if (txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a Quantidade.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.idFicha = int.Parse(txbComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbCodProduto.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if (ordemComanda.cadastrar())
                {
                    MessageBox.Show("lançamento efetuado.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else 
                {
                    MessageBox.Show("Falha ao efetuar o lançamento.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetarCampos()
        { 
            //limpar os txb
        txbCodProduto.Clear();
            txbQuantidade.Clear();
            txbProduto.Clear();
            txbComanda.Clear();
            // resetar os groupboxes;
            grbLancamento.Enabled = false;
            grbInformacoes.Enabled = true;    
        }
    }
}
