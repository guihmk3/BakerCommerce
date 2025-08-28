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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // verificar se apessoa digitou o email e a senha 
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um Email válido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma Senha válida!",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            // prosseguir...
            Model.Usuario usuario = new Model.Usuario();

                // colocar os valores dos campos nos atributos do usuario
                usuario.Email =txbEmail.Text;
                usuario.Senha = txbSenha.Text;

            }
        }
    }
}
