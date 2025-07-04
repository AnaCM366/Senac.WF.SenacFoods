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
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void btnFecharMesa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarMesa_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();

        }

    }
}
