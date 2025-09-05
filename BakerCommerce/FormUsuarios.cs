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
    public partial class FormUsuarios : Form
    {
        // objetos globais:
        Model.Usuario usuario;

        int idselecionado = 0;

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            atualizarDgv();

            // Mostrar ás informações do banco de dados no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }
        public void atualizarDgv()
        {
            // mostar as informações do bd no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();
        }
        private void btnCadastraCadastro_Click(object sender, EventArgs e)
        {
            // válidar campos:
            if (txbNomeCadastro.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailCadastro.Text.Length < 7)
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show("A Senha deve ter no mínimo 6 caracteres.",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();
                // salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.nome_completo = txbNomeCadastro.Text;
                usuarioCadastro.Email = txbEmailCadastro.Text;
                usuarioCadastro.Senha = txbSenhaCadastro.Text;
                // executar o insert:
                if (usuarioCadastro.cadastrar())
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dgv
                    atualizarDgv();

                    //apagar os campos de cadastro
                    txbNomeCadastro.Clear();
                    txbSenhaCadastro.Clear();
                    txbEmailCadastro.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o Usuario!",
                      "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar a linha selecionada
            int Ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // colocar os valores das celulas nos txb de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[Ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[Ls].Cells[2].Value.ToString();

            //ARMAZENAR O ID DE QUEM FOI SELECIONADO 
            idselecionado = (int)dgvUsuarios.Rows[Ls].Cells[0].Value;

            //ajustar no gtbapagar:
            lblUserApagar.Text = $"Apagar: {dgvUsuarios.Rows[Ls].Cells[1].Value.ToString()}";
            //ativar o grbApagar
            grbApagar.Enabled = true;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // perguntar se realmente quer apagar
            DialogResult r = MessageBox.Show("Tem certezsa que deseja apagar este usuario?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idselecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("usuario Apagado com sucesso", "Show",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                  ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar usuario.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void ResetarCampos()
        {
            // atualizar o dgv
            atualizarDgv();
            //limpar campos de exibição
            txbEmailEditar.Clear();
            txbNomeEditar.Clear();
            txbSenhaEditar.Clear();

            //retornar o id selecionado para 0
            idselecionado = 0;

            //retornar o texto padrão do "apagar"
            lblUserApagar.Text = "Selecione o usuario que deseja apagar";

            //desabilitar os grb
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7)
            {
                MessageBox.Show("O Email deve ter no mínimo 7 caracteres.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("O Senha deve ter no mínimo 6 caracteres.",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a Edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idselecionado;
                usuarioEditar.nome_completo = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
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
    }
}
