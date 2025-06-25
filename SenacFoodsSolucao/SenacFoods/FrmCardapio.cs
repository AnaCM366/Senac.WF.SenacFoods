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
                var cardapios = bd.CardapioItems.ToList();

                // popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
