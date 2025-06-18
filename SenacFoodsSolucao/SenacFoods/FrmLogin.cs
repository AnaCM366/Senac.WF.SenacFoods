namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { //true, false
            bool loginValido = ValidarLogin(txtLogin.Text, txtSenha.Text);
            // SE true
            if (loginValido)
            {
                //oculta a tela de Login
                this.Hide();
                // criar uma instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                // exibe a tela de Principal
                frmPrincipal.Show();

            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            using (var banco = new ComandaDBContext())
            {
                // CONSULTAR A TABELA USUARIO SELECT + FROM USUARIOS WHERE EMAIL = ? AND SENHA = ?
                var usuario = banco
                             .Usuarios
                             .FirstOrDefault(u => u.Email == nome && u.Senha == senha);
                if(usuario is not null)
                    usuarioValido = true;
            }
                //SE nome é igual a admin E senha é igual a 123
                if (usuarioValido)
                { //RETURNA veradadeiro
                    return true;
                }
                else
                { // EXIBE uma mensagem de erro
                    MessageBox.Show("Login ou Senha inválidos");
                } //RETORNA false
                return false;
        } 

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // fecha a tela de login
            Close();
            // encerra o aplicativo
            Application.Exit();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
