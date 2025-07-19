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
    public partial class FrmMesaCad : Form
    {
        private Mesa _mesa;
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        public FrmMesaCad(Mesa mesaSelecionado)
        {
            _mesa = mesaSelecionado;
            InitializeComponent();

            // Carregar os dados da mesa selecionada na tela
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            // popular os campos de texto e chechbox
            if (_mesa != null)
            {
                txtTituloMesa.Text = _mesa.NumeroMesa.ToString();
            }
        }

        private void btnFecharMesa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarMesa_Click(object sender, EventArgs e)
        {
            // INSERIR
            if (_mesa == null)
            {
                InserirMesa();
            }
            // ATUALIZAR
            else
            {
                AtualizarMesa();
            }
        }

        private void AtualizarMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                // captar os dados da tela
                int.TryParse(txtTituloMesa.Text, out var numeroMesa);

                // atualizar a mesa
                var mesa = banco.Mesas.First(x => x.Id == _mesa.Id);
                mesa.NumeroMesa = numeroMesa;

                // salvar as alterações no banco
                banco.Mesas.Update(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirMesa()
        {
            // conectar
            using (var banco = new ComandaDBContext())
            {

                // captar os dados da tela
                int.TryParse(txtTituloMesa.Text, out var numeroMesa);

                // criar uma nova mesa
                var mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa,
                };
                // adicionar uma mesa   // salvar as alterações no banco
                banco.Mesas.Add(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelarMesa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
