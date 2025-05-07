using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            // exibe o nome do usuario na tela principal
            lblMensagem.Text = "Bem vindo " + nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a tela principal
            Close();
            // cria uma instancia da tela de login
            var frmLogin = new FrmLogin();
            // exibe a tela de login
            frmLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            // cria uma instancia do FrmCardapio
            var frmCardapio = new FrmCardapio();
            // exibe a tela de cardapio em estilo modal()
            frmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            // altera o estado da tela
            // para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            // cria uma instancia do FrmUsuario
            var frmUsuario = new FrmUsuario();
            // exibe a tela de usuario em estilo modal()
            frmUsuario.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedidoCozinha();
            frmPedido.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
