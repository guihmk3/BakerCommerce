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
    public partial class MenuPrincipal : Form
    {
        //variaveis globais
        Model.Usuario Usuario = new Model.Usuario();
        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario; // this usado para diferenciar usuario classe de usuario
            lblDescricao.Text = $"Olá {usuario.nome_completo}.\nEscolha uma opção abaixo";
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            FormComandas formComandas = new FormComandas(Usuario);
            formComandas.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(Usuario);
            formUsuarios.ShowDialog(); // Mostar o Form
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos formprodutos = new FormProdutos(Usuario);
            formprodutos.ShowDialog(); 
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formcaixa = new FormCaixa(Usuario);
            formcaixa.ShowDialog();
        }
    }
}
