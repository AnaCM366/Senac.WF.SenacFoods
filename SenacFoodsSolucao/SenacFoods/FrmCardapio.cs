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
    }
}
