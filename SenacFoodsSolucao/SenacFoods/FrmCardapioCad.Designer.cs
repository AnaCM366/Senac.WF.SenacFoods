namespace SenacFoods
{
    partial class FrmCardapioCad
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
            panel1 = new Panel();
            btnFechar = new Button();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            txtDescricao = new RichTextBox();
            txtPreco = new TextBox();
            txtTitulo = new TextBox();
            chkPossuiPreparo = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 76);
            panel1.TabIndex = 5;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Cardápio";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(739, 495);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 67);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.Location = new Point(898, 495);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(153, 67);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 567);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(54, 184);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(744, 144);
            txtDescricao.TabIndex = 9;
            txtDescricao.Text = "";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(54, 382);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(744, 39);
            txtPreco.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(54, 99);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(744, 39);
            txtTitulo.TabIndex = 6;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(33, 444);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(222, 36);
            chkPossuiPreparo.TabIndex = 7;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 347);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 6;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 149);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 5;
            label3.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 64);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 4;
            label2.Text = "Título";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(1098, 671);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnFechar;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox chkPossuiPreparo;
        private Label label4;
        private Label label3;
        private RichTextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtTitulo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}