namespace SenacFoods
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnUsuario = new Button();
            btnPedido = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            lblMensagem = new Label();
            btnMesa = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnMesa);
            groupBox1.Controls.Add(btnPedido);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(32, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1016, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(255, 128, 128);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.White;
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Rockwell", 16F);
            btnUsuario.ForeColor = Color.Black;
            btnUsuario.Location = new Point(618, 89);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(172, 155);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuários";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.DeepSkyBlue;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatAppearance.MouseDownBackColor = Color.White;
            btnPedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Rockwell", 16F);
            btnPedido.ForeColor = Color.Black;
            btnPedido.Location = new Point(420, 89);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(172, 155);
            btnPedido.TabIndex = 0;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.FromArgb(128, 255, 128);
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.FlatAppearance.MouseDownBackColor = Color.White;
            btnComanda.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("Rockwell", 16F);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(222, 89);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(172, 155);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.FromArgb(255, 255, 128);
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.FlatAppearance.MouseDownBackColor = Color.White;
            btnCardapio.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCardapio.FlatStyle = FlatStyle.Flat;
            btnCardapio.Font = new Font("Rockwell", 16F);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(28, 89);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(172, 155);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Rockwell Extra Bold", 12F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1032, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 36);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Rockwell Extra Bold", 15F);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(981, 11);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(47, 36);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 20F);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(348, 27);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(263, 54);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "lblMensagem";
            lblMensagem.Click += label1_Click;
            // 
            // btnMesa
            // 
            btnMesa.BackColor = Color.FromArgb(255, 128, 0);
            btnMesa.FlatAppearance.BorderSize = 0;
            btnMesa.FlatAppearance.MouseDownBackColor = Color.White;
            btnMesa.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMesa.FlatStyle = FlatStyle.Flat;
            btnMesa.Font = new Font("Rockwell", 16F);
            btnMesa.ForeColor = Color.Black;
            btnMesa.Location = new Point(815, 89);
            btnMesa.Name = "btnMesa";
            btnMesa.Size = new Size(172, 155);
            btnMesa.TabIndex = 0;
            btnMesa.Text = "Mesa";
            btnMesa.UseVisualStyleBackColor = false;
            btnMesa.Click += btnMesa_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1087, 500);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnUsuario;
        private Button btnPedido;
        private Button btnComanda;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblMensagem;
        private Button btnMesa;
    }
}