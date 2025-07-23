namespace SenacFoods
{
    partial class FrmUsuarios
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
            txtPesquisarUsuarios = new TextBox();
            panel1 = new Panel();
            btnFecharUsuarios = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnExcluirUsuarios = new Button();
            btnAdicionarUsuarios = new Button();
            btnEditarUsuarios = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisarUsuarios
            // 
            txtPesquisarUsuarios.Location = new Point(187, 22);
            txtPesquisarUsuarios.Name = "txtPesquisarUsuarios";
            txtPesquisarUsuarios.Size = new Size(612, 31);
            txtPesquisarUsuarios.TabIndex = 2;
            txtPesquisarUsuarios.TextChanged += txtPesquisarUsuarios_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnFecharUsuarios);
            panel1.Controls.Add(txtPesquisarUsuarios);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 76);
            panel1.TabIndex = 6;
            // 
            // btnFecharUsuarios
            // 
            btnFecharUsuarios.BackColor = SystemColors.ActiveCaptionText;
            btnFecharUsuarios.FlatAppearance.BorderSize = 0;
            btnFecharUsuarios.FlatAppearance.MouseDownBackColor = Color.White;
            btnFecharUsuarios.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFecharUsuarios.FlatStyle = FlatStyle.Flat;
            btnFecharUsuarios.Font = new Font("Rockwell Extra Bold", 12F);
            btnFecharUsuarios.ForeColor = Color.White;
            btnFecharUsuarios.Location = new Point(1031, 12);
            btnFecharUsuarios.Name = "btnFecharUsuarios";
            btnFecharUsuarios.Size = new Size(47, 36);
            btnFecharUsuarios.TabIndex = 5;
            btnFecharUsuarios.Text = "X";
            btnFecharUsuarios.UseVisualStyleBackColor = false;
            btnFecharUsuarios.Click += btnFecharUsuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluirUsuarios);
            groupBox1.Controls.Add(btnAdicionarUsuarios);
            groupBox1.Controls.Add(btnEditarUsuarios);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(7, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 576);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuários";
            // 
            // btnExcluirUsuarios
            // 
            btnExcluirUsuarios.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluirUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluirUsuarios.Location = new Point(739, 495);
            btnExcluirUsuarios.Name = "btnExcluirUsuarios";
            btnExcluirUsuarios.Size = new Size(153, 67);
            btnExcluirUsuarios.TabIndex = 3;
            btnExcluirUsuarios.Text = "X Excluir";
            btnExcluirUsuarios.UseVisualStyleBackColor = false;
            btnExcluirUsuarios.Click += btnExcluirUsuarios_Click;
            // 
            // btnAdicionarUsuarios
            // 
            btnAdicionarUsuarios.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionarUsuarios.FlatStyle = FlatStyle.Flat;
            btnAdicionarUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionarUsuarios.ForeColor = SystemColors.ControlText;
            btnAdicionarUsuarios.Location = new Point(34, 39);
            btnAdicionarUsuarios.Name = "btnAdicionarUsuarios";
            btnAdicionarUsuarios.Size = new Size(174, 57);
            btnAdicionarUsuarios.TabIndex = 2;
            btnAdicionarUsuarios.Text = "+ Adicionar";
            btnAdicionarUsuarios.UseVisualStyleBackColor = false;
            btnAdicionarUsuarios.Click += btnAdicionarUsuarios_Click;
            // 
            // btnEditarUsuarios
            // 
            btnEditarUsuarios.BackColor = Color.FromArgb(128, 255, 128);
            btnEditarUsuarios.Enabled = false;
            btnEditarUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditarUsuarios.Location = new Point(898, 495);
            btnEditarUsuarios.Name = "btnEditarUsuarios";
            btnEditarUsuarios.Size = new Size(153, 67);
            btnEditarUsuarios.TabIndex = 1;
            btnEditarUsuarios.Text = "# Editar";
            btnEditarUsuarios.UseVisualStyleBackColor = false;
            btnEditarUsuarios.Click += btnEditarUsuarios_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1017, 376);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 677);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPesquisarUsuarios;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnExcluirUsuarios;
        private Button btnAdicionarUsuarios;
        private Button btnEditarUsuarios;
        private DataGridView dataGridView1;
        private Button btnFecharUsuarios;
    }
}