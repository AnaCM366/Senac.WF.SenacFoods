namespace SenacFoods
{
    partial class FrmUsuariosCad
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
            btnFechar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cmbPerfil = new ComboBox();
            mskSenha = new MaskedTextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            mskConfirmacaoSenha = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelarUsuarios = new Button();
            btnSalvarUsuarios = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ActiveCaptionText;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Rockwell Extra Bold", 12F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1035, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 36);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 76);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Usuários";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbPerfil);
            groupBox1.Controls.Add(mskSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(mskConfirmacaoSenha);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelarUsuarios);
            groupBox1.Controls.Add(btnSalvarUsuarios);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(7, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 567);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuários";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 380);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 14;
            label6.Text = "Perfil:";
            // 
            // cmbPerfil
            // 
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(54, 415);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(744, 40);
            cmbPerfil.TabIndex = 13;
            // 
            // mskSenha
            // 
            mskSenha.Location = new Point(54, 240);
            mskSenha.Name = "mskSenha";
            mskSenha.Size = new Size(744, 39);
            mskSenha.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(744, 39);
            txtEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 115);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // mskConfirmacaoSenha
            // 
            mskConfirmacaoSenha.Location = new Point(54, 328);
            mskConfirmacaoSenha.Name = "mskConfirmacaoSenha";
            mskConfirmacaoSenha.Size = new Size(744, 39);
            mskConfirmacaoSenha.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(54, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(744, 39);
            txtNome.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 287);
            label4.Name = "label4";
            label4.Size = new Size(275, 32);
            label4.TabIndex = 6;
            label4.Text = "Confirmação de senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 202);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 5;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 35);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // btnCancelarUsuarios
            // 
            btnCancelarUsuarios.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelarUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelarUsuarios.Location = new Point(739, 495);
            btnCancelarUsuarios.Name = "btnCancelarUsuarios";
            btnCancelarUsuarios.Size = new Size(153, 67);
            btnCancelarUsuarios.TabIndex = 3;
            btnCancelarUsuarios.Text = "X Cancelar";
            btnCancelarUsuarios.UseVisualStyleBackColor = false;
            btnCancelarUsuarios.Click += btnCancelarUsuarios_Click;
            // 
            // btnSalvarUsuarios
            // 
            btnSalvarUsuarios.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvarUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarUsuarios.Location = new Point(898, 495);
            btnSalvarUsuarios.Name = "btnSalvarUsuarios";
            btnSalvarUsuarios.Size = new Size(153, 67);
            btnSalvarUsuarios.TabIndex = 1;
            btnSalvarUsuarios.Text = "# Salvar";
            btnSalvarUsuarios.UseVisualStyleBackColor = false;
            btnSalvarUsuarios.Click += btnSalvarUsuarios_Click;
            // 
            // FrmUsuariosCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 685);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCad";
            Text = "FrmUsuarioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox mskConfirmacaoSenha;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelarUsuarios;
        private Button btnSalvarUsuarios;
        private TextBox txtEmail;
        private Label label5;
        private MaskedTextBox mskSenha;
        private Label label6;
        private ComboBox cmbPerfil;
    }
}