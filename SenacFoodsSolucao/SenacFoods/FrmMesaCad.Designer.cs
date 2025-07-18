namespace SenacFoods
{
    partial class FrmMesaCad
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
            btnFecharMesa = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTituloMesa = new TextBox();
            label2 = new Label();
            btnCancelarMesa = new Button();
            btnSalvarMesa = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(btnFecharMesa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 76);
            panel1.TabIndex = 6;
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
            btnFecharMesa.Location = new Point(1035, 10);
            btnFecharMesa.Name = "btnFecharMesa";
            btnFecharMesa.Size = new Size(47, 36);
            btnFecharMesa.TabIndex = 5;
            btnFecharMesa.Text = "X";
            btnFecharMesa.UseVisualStyleBackColor = false;
            btnFecharMesa.Click += btnFecharMesa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 1;
            label1.Text = "Cadastro Mesas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTituloMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelarMesa);
            groupBox1.Controls.Add(btnSalvarMesa);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 568);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // txtTituloMesa
            // 
            txtTituloMesa.Location = new Point(54, 99);
            txtTituloMesa.Name = "txtTituloMesa";
            txtTituloMesa.Size = new Size(744, 39);
            txtTituloMesa.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 64);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 4;
            label2.Text = "Número";
            // 
            // btnCancelarMesa
            // 
            btnCancelarMesa.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelarMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelarMesa.Location = new Point(739, 495);
            btnCancelarMesa.Name = "btnCancelarMesa";
            btnCancelarMesa.Size = new Size(153, 67);
            btnCancelarMesa.TabIndex = 3;
            btnCancelarMesa.Text = "X Cancelar";
            btnCancelarMesa.UseVisualStyleBackColor = false;
            // 
            // btnSalvarMesa
            // 
            btnSalvarMesa.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvarMesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarMesa.Location = new Point(898, 495);
            btnSalvarMesa.Name = "btnSalvarMesa";
            btnSalvarMesa.Size = new Size(153, 67);
            btnSalvarMesa.TabIndex = 1;
            btnSalvarMesa.Text = "# Salvar";
            btnSalvarMesa.UseVisualStyleBackColor = false;
            btnSalvarMesa.Click += btnSalvarMesa_Click;
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 674);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFecharMesa;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTituloMesa;
        private Label label2;
        private Button btnCancelarMesa;
        private Button btnSalvarMesa;
    }
}