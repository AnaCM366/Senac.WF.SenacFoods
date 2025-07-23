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
    public partial class FrmUsuarios : Form
    {
        Usuario? usuarioSelecionado;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }
        private void BuscarUsuarios()
        {
            // conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // consultar a tabela Usuario SELECT * FROM CARDAPIO
                var usuarios = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisarUsuarios.Text))
                {
                    // filtrar os usuarios pelo nome/email
                    usuarios = usuarios.Where(c => c.Nome.ToLower().Contains(txtPesquisarUsuarios.Text) ||
                                              c.Email.Contains(txtPesquisarUsuarios.Text));
                }

                // popular o grid com a tabela consultada
                dataGridView1.DataSource = usuarios.ToList(); ;
            }
        }

        private void btnAdicionarUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuariosCad().ShowDialog();
            BuscarUsuarios();
        }

        private void btnFecharUsuarios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisarUsuarios_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // pegar o usuario selecionado
                usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditarUsuarios.Enabled = true;
            }
        }

        private void btnEditarUsuarios_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                var usuario = new FrmUsuariosCad(usuarioSelecionado);
                usuario.ShowDialog();

                BuscarUsuarios();
                usuarioSelecionado = null;
            }
        }

        private void btnExcluirUsuarios_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Usuarios.Remove(usuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Usuário foi excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}