namespace Projetocadastro
{
    partial class F_buscar
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
            this.tbxproduto = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblinformacoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // tbxproduto
            // 
            this.tbxproduto.Location = new System.Drawing.Point(211, 47);
            this.tbxproduto.Name = "tbxproduto";
            this.tbxproduto.Size = new System.Drawing.Size(255, 26);
            this.tbxproduto.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(487, 47);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 26);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblinformacoes
            // 
            this.lblinformacoes.AutoSize = true;
            this.lblinformacoes.Location = new System.Drawing.Point(140, 147);
            this.lblinformacoes.Name = "lblinformacoes";
            this.lblinformacoes.Size = new System.Drawing.Size(0, 20);
            this.lblinformacoes.TabIndex = 3;
            // 
            // F_buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblinformacoes);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbxproduto);
            this.Controls.Add(this.label1);
            this.Name = "F_buscar";
            this.Text = "F_buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxproduto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblinformacoes;
    }
}