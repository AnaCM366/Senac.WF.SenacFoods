namespace SenacFoods
{
    partial class FrmMesa
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
            txtPesquisarMesa = new TextBox();
            btnFecharMesa = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnExcluirMesa = new Button();
            btnAdicionarMesa = new Button();
            btnEditarMesa = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(txtPesquisarMesa);
            panel1.Controls.Add(btnFecharMesa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 76);
            panel1.TabIndex = 5;
            // 
            // txtPesquisarMesa
            // 
            txtPesquisarMesa.Location = new Point(187, 22);
            txtPesquisarMesa.Name = "txtPesquisarMesa";
            txtPesquisarMesa.Size = new Size(612, 31);
            txtPesquisarMesa.TabIndex = 2;
            txtPesquisarMesa.TextChanged += txtPesquisarMesa_TextChanged;
            // 
            // btnFecharMesa
            // 
            btnFecharMesa.BackColor = SystemColors.ActiveCaptionText;
            btnFecharMesa.FlatAppearance.BorderSize = 0;
            btnFecharMesa.FlatAppearance.MouseDownBackColor = Color.White;
            btnFecharMesa.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFecharMesa.FlatStyle = FlatStyle.Flat;
            btnFecharMesa.Font = new Font("Rockwell Extra Bold", 12F);
            btnFecharMesa.ForeColor = Color.White;
            btnFecharMesa.Location = new Point(1039, 13);
            btnFecharMesa.Name = "btnFecharMesa";
            btnFecharMesa.Size = new Size(47, 36);
            btnFecharMesa.TabIndex = 6;
            btnFecharMesa.Text = "X";
            btnFecharMesa.UseVisualStyleBackColor = false;
            btnFecharMesa.Click += btnFecharMesa_Click;
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
            groupBox1.Controls.Add(btnExcluirMesa);
            groupBox1.Controls.Add(btnAdicionarMesa);
            groupBox1.Controls.Add(btnEditarMesa);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 576);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // btnExcluirMesa
            // 
            btnExcluirMesa.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluirMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluirMesa.Location = new Point(739, 495);
            btnExcluirMesa.Name = "btnExcluirMesa";
            btnExcluirMesa.Size = new Size(153, 67);
            btnExcluirMesa.TabIndex = 3;
            btnExcluirMesa.Text = "X Excluir";
            btnExcluirMesa.UseVisualStyleBackColor = false;
            btnExcluirMesa.Click += btnExcluirMesa_Click;
            // 
            // btnAdicionarMesa
            // 
            btnAdicionarMesa.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionarMesa.FlatStyle = FlatStyle.Flat;
            btnAdicionarMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionarMesa.ForeColor = SystemColors.ControlText;
            btnAdicionarMesa.Location = new Point(34, 39);
            btnAdicionarMesa.Name = "btnAdicionarMesa";
            btnAdicionarMesa.Size = new Size(240, 57);
            btnAdicionarMesa.TabIndex = 2;
            btnAdicionarMesa.Text = "+ Adicionar Mesa";
            btnAdicionarMesa.UseVisualStyleBackColor = false;
            btnAdicionarMesa.Click += btnAdicionarMesa_Click;
            // 
            // btnEditarMesa
            // 
            btnEditarMesa.BackColor = Color.FromArgb(128, 255, 128);
            btnEditarMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditarMesa.Location = new Point(898, 495);
            btnEditarMesa.Name = "btnEditarMesa";
            btnEditarMesa.Size = new Size(153, 67);
            btnEditarMesa.TabIndex = 1;
            btnEditarMesa.Text = "# Editar";
            btnEditarMesa.UseVisualStyleBackColor = false;
            btnEditarMesa.Click += btnEditarMesa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1017, 376);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 680);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            Text = "FrmMesa";
            Load += FrmMesa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPesquisarMesa;
        private Button btnFecharMesa;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnExcluirMesa;
        private Button btnAdicionarMesa;
        private Button btnEditarMesa;
        private DataGridView dataGridView1;
    }
}