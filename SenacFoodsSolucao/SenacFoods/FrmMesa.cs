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
    public partial class FrmMesa : Form
    {
        Mesa? MesaSelecionado;
        public FrmMesa()
        {
            InitializeComponent();
        }
        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            // conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // consultar a tabela mesa SELECT * FROM CARDAPIO
                var mesa = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisarMesa.Text))
                {
                    // filtrar as mesas pelo titulo
                    mesa = mesa.Where(c => c.NumeroMesa.ToString().Contains(txtPesquisarMesa.Text) ||
                                           c.SituacaoMesa.ToString().Contains(txtPesquisarMesa.Text));
                }

                // popular o grid com a tabela consultada
                dataGridView1.DataSource = mesa.ToList();
            }
        }

        private void btnAdicionarMesa_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesa();

        }
        private void btnFecharMesa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisarMesa_TextChanged(object sender, EventArgs e)
        {
            // chamar o metodo buscar mesa
            BuscarMesa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // pegar a mesa selecionada
                MesaSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btnEditarMesa.Enabled = true;
            }
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            if (MesaSelecionado != null)
            {
                // abrir o formulario de edição
                var mesa = new FrmMesaCad(MesaSelecionado);
                mesa.ShowDialog();
                // atualizar a lista de cardápios
                BuscarMesa();
                MesaSelecionado = null;
            }
        }

        private void btnExcluirMesa_Click(object sender, EventArgs e)
        {
            if (MesaSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Mesas.Remove(MesaSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Mesa excluída com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                MesaSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione sua mesa para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
