namespace Projetocadastro
{
    partial class F_cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxcontato = new System.Windows.Forms.TextBox();
            this.tbxcargo = new System.Windows.Forms.TextBox();
            this.tbxusuario2 = new System.Windows.Forms.TextBox();
            this.tbxcpf = new System.Windows.Forms.TextBox();
            this.tbxnome = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo Ocupado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contato:";
            // 
            // tbxcontato
            // 
            this.tbxcontato.Location = new System.Drawing.Point(201, 248);
            this.tbxcontato.Name = "tbxcontato";
            this.tbxcontato.Size = new System.Drawing.Size(419, 26);
            this.tbxcontato.TabIndex = 5;
            // 
            // tbxcargo
            // 
            this.tbxcargo.Location = new System.Drawing.Point(201, 197);
            this.tbxcargo.Name = "tbxcargo";
            this.tbxcargo.Size = new System.Drawing.Size(419, 26);
            this.tbxcargo.TabIndex = 6;
            // 
            // tbxusuario2
            // 
            this.tbxusuario2.Location = new System.Drawing.Point(201, 141);
            this.tbxusuario2.Name = "tbxusuario2";
            this.tbxusuario2.Size = new System.Drawing.Size(419, 26);
            this.tbxusuario2.TabIndex = 7;
            // 
            // tbxcpf
            // 
            this.tbxcpf.Location = new System.Drawing.Point(201, 91);
            this.tbxcpf.Name = "tbxcpf";
            this.tbxcpf.Size = new System.Drawing.Size(419, 26);
            this.tbxcpf.TabIndex = 8;
            this.tbxcpf.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbxnome
            // 
            this.tbxnome.Location = new System.Drawing.Point(269, 46);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(351, 26);
            this.tbxnome.TabIndex = 9;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(318, 350);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(167, 35);
            this.btncadastrar.TabIndex = 10;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // F_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.tbxnome);
            this.Controls.Add(this.tbxcpf);
            this.Controls.Add(this.tbxusuario2);
            this.Controls.Add(this.tbxcargo);
            this.Controls.Add(this.tbxcontato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_cadastro";
            this.Text = "F_cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxcontato;
        private System.Windows.Forms.TextBox tbxcargo;
        private System.Windows.Forms.TextBox tbxusuario2;
        private System.Windows.Forms.TextBox tbxcpf;
        private System.Windows.Forms.TextBox tbxnome;
        private System.Windows.Forms.Button btncadastrar;
    }
}