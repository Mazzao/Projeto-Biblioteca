namespace ProjetoBiblioteca
{
    partial class FormEmprestimos
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
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblIdLivro = new System.Windows.Forms.Label();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtDataEmprestimo = new System.Windows.Forms.TextBox();
            this.lblDataPrevistaDevolucao = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.txtDataPrevistaDevolucao = new System.Windows.Forms.TextBox();
            this.txtDataDevolucao = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(11, 9);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(238, 31);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "Id do Usuario";
            this.lblIdUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLivro.Location = new System.Drawing.Point(255, 9);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(238, 31);
            this.lblIdLivro.TabIndex = 1;
            this.lblIdLivro.Text = "Id do Livro";
            this.lblIdLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmprestimo.Location = new System.Drawing.Point(495, 9);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(238, 31);
            this.lblDataEmprestimo.TabIndex = 2;
            this.lblDataEmprestimo.Text = "Data do Emprestimo";
            this.lblDataEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(17, 43);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(232, 20);
            this.txtIdUsuario.TabIndex = 3;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(258, 43);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(231, 20);
            this.txtIdLivro.TabIndex = 4;
            // 
            // txtDataEmprestimo
            // 
            this.txtDataEmprestimo.Location = new System.Drawing.Point(498, 43);
            this.txtDataEmprestimo.Name = "txtDataEmprestimo";
            this.txtDataEmprestimo.Size = new System.Drawing.Size(232, 20);
            this.txtDataEmprestimo.TabIndex = 5;
            // 
            // lblDataPrevistaDevolucao
            // 
            this.lblDataPrevistaDevolucao.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPrevistaDevolucao.Location = new System.Drawing.Point(133, 115);
            this.lblDataPrevistaDevolucao.Name = "lblDataPrevistaDevolucao";
            this.lblDataPrevistaDevolucao.Size = new System.Drawing.Size(238, 31);
            this.lblDataPrevistaDevolucao.TabIndex = 6;
            this.lblDataPrevistaDevolucao.Text = "Data Prevista de Devolucao";
            this.lblDataPrevistaDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolucao.Location = new System.Drawing.Point(377, 115);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(238, 31);
            this.lblDataDevolucao.TabIndex = 7;
            this.lblDataDevolucao.Text = "Data da Devolucao";
            this.lblDataDevolucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDataPrevistaDevolucao
            // 
            this.txtDataPrevistaDevolucao.Location = new System.Drawing.Point(139, 149);
            this.txtDataPrevistaDevolucao.Name = "txtDataPrevistaDevolucao";
            this.txtDataPrevistaDevolucao.Size = new System.Drawing.Size(232, 20);
            this.txtDataPrevistaDevolucao.TabIndex = 8;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Location = new System.Drawing.Point(383, 149);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(232, 20);
            this.txtDataDevolucao.TabIndex = 9;
            // 
            // lblAviso
            // 
            this.lblAviso.Location = new System.Drawing.Point(133, 203);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(482, 62);
            this.lblAviso.TabIndex = 10;
            this.lblAviso.Text = "Digite as datas no formato ano-mes-dia (exemplo: 2026-09-25). Deixe a Data da Devo" +
    "lucao em branco se o livro ainda nao foi devolvido.";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(335, 334);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(742, 369);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtDataDevolucao);
            this.Controls.Add(this.txtDataPrevistaDevolucao);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblDataPrevistaDevolucao);
            this.Controls.Add(this.txtDataEmprestimo);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.lblIdLivro);
            this.Controls.Add(this.lblIdUsuario);
            this.Name = "FormEmprestimos";
            this.Text = "FormEmprestimos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblIdLivro;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtDataEmprestimo;
        private System.Windows.Forms.Label lblDataPrevistaDevolucao;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.TextBox txtDataPrevistaDevolucao;
        private System.Windows.Forms.TextBox txtDataDevolucao;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
