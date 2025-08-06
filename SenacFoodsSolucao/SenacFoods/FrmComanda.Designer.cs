namespace SenacFoods
{
    partial class FrmComanda
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
            btnExcluir = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtPesquisar = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 576);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(739, 495);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(153, 67);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(255, 255, 128);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdicionar.ForeColor = SystemColors.ControlText;
            btnAdicionar.Location = new Point(34, 39);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(153, 57);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 255, 128);
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(898, 495);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 67);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(txtPesquisar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 76);
            panel1.TabIndex = 6;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(187, 22);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(612, 31);
            txtPesquisar.TabIndex = 2;
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
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ActiveCaptionText;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Rockwell Extra Bold", 12F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(1038, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 36);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 679);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            Text = "FrmComanda";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExcluir;
        private Button btnAdicionar;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtPesquisar;
        private Label label1;
        private Button btnFechar;
    }
}