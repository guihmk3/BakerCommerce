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
                MessageBox.Show("O Senha deve ter no mínimo 6 caracteres.",
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
    }
}
