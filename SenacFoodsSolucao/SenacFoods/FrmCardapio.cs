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
    public partial class FrmCardapio : Form
    {
        CardapioItem? cardapioSelecionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCadapio();
        }

        private void BuscarCadapio()
        {
            // conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                // consultar a tabela cardapioitem SELECT * FROM CARDAPIO
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    // filtrar os cardapios pelo titulo
                    cardapios = cardapios.Where(c => c.Titulo.ToLower().Contains(txtPesquisar.Text) ||
                                                     c.Descricao.Contains(txtPesquisar.Text));
                }

                // popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList(); ;
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCadapio();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // chamar o metodo buscar cardapio
            BuscarCadapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // pegar o cardapio selecionado
                var cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                // abrir o formulario de edição
                var cardapio = new FrmCardapioCad(cardapioSelecionado);
                cardapio.ShowDialog();
                // atualizar a lista de cardápios
                BuscarCadapio();
                cardapioSelecionado = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using(var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.CardapioItems.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                BuscarCadapio();
                cardapioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Aviso",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
