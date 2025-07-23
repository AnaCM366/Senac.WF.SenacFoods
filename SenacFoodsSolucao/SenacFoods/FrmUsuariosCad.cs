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
    public partial class FrmUsuariosCad : Form
    {
        private Usuario _usuario;
        public FrmUsuariosCad()
        {
            InitializeComponent();
        }
        public FrmUsuariosCad(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            CarregaDadosDaTela();

        }

        private void CarregaDadosDaTela()
        {
            if (_usuario != null)
            {
                txtNome.Text = _usuario.Nome;
                txtEmail.Text = _usuario.Email;
                mskSenha.Text = _usuario.Senha; //deve ter no mínimo 6 caracteres
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarUsuarios_Click(object sender, EventArgs e)
        {
            // INSERIR
            if (_usuario == null)
            {
                InserirUsuarios();
            }
            // ATUALIZAR
            else
            {
                AtualizarUsuarios();
            }
        }

        private void AtualizarUsuarios()
        {
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = mskSenha.Text;

                // atualizar os usuarios
                var usuario = banco.Usuarios.First(x => x.Id == _usuario.Id);
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.Senha = senha;

                // salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirUsuarios()
        {
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = mskSenha.Text;

                // criar um novo cardapio
                var usuario = new Usuario()
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha
                };

                // salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarUsuarios_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
