namespace SenacFoods
{
    partial class FrmCardapio
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btnFechar = new Button();
            button3 = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1075, 576);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(34, 39);
            button2.Name = "button2";
            button2.Size = new Size(153, 57);
            button2.TabIndex = 2;
            button2.Text = "+ Item";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(898, 495);
            button1.Name = "button1";
            button1.Size = new Size(153, 67);
            button1.TabIndex = 1;
            button1.Text = "# Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1017, 376);
            dataGridView1.TabIndex = 0;
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
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
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
            btnFechar.Location = new Point(1040, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 36);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(739, 495);
            button3.Name = "button3";
            button3.Size = new Size(153, 67);
            button3.TabIndex = 3;
            button3.Text = "X Excluir";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 76);
            panel1.TabIndex = 4;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 682);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            Load += FrmCardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button btnFechar;
        private Button button3;
        private Panel panel1;
    }
}