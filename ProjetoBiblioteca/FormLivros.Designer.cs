namespace ProjetoBiblioteca
{
    partial class FormLivros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblQuantidadeTotal = new System.Windows.Forms.Label();
            this.lblQuantidadeDisponivel = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDisponivel = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutor.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(256, 9);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(237, 31);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditora
            // 
            this.lblEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditora.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(495, 9);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(238, 31);
            this.lblEditora.TabIndex = 2;
            this.lblEditora.Text = "Editora";
            this.lblEditora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(17, 43);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(232, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(258, 43);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(231, 20);
            this.txtAutor.TabIndex = 4;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(498, 43);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(232, 20);
            this.txtEditora.TabIndex = 5;
            // 
            // lblAno
            // 
            this.lblAno.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(11, 115);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(238, 31);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(255, 115);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(238, 31);
            this.lblQuantidadeTotal.TabIndex = 7;
            this.lblQuantidadeTotal.Text = "Quantidade";
            this.lblQuantidadeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantidadeDisponivel
            // 
            this.lblQuantidadeDisponivel.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDisponivel.Location = new System.Drawing.Point(499, 115);
            this.lblQuantidadeDisponivel.Name = "lblQuantidadeDisponivel";
            this.lblQuantidadeDisponivel.Size = new System.Drawing.Size(238, 31);
            this.lblQuantidadeDisponivel.TabIndex = 8;
            this.lblQuantidadeDisponivel.Text = "Quantidade Disponivel";
            this.lblQuantidadeDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(17, 149);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(232, 20);
            this.txtAno.TabIndex = 9;
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(261, 149);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(232, 20);
            this.txtQuantidadeTotal.TabIndex = 10;
            // 
            // txtQuantidadeDisponivel
            // 
            this.txtQuantidadeDisponivel.Location = new System.Drawing.Point(501, 149);
            this.txtQuantidadeDisponivel.Name = "txtQuantidadeDisponivel";
            this.txtQuantidadeDisponivel.Size = new System.Drawing.Size(232, 20);
            this.txtQuantidadeDisponivel.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Noto Naskh Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(256, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(238, 31);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(258, 237);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(232, 20);
            this.txtStatus.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(335, 334);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(742, 369);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtQuantidadeDisponivel);
            this.Controls.Add(this.txtQuantidadeTotal);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblQuantidadeDisponivel);
            this.Controls.Add(this.lblQuantidadeTotal);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormLivros";
            this.Text = "FormLivros";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblQuantidadeTotal;
        private System.Windows.Forms.Label lblQuantidadeDisponivel;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtQuantidadeTotal;
        private System.Windows.Forms.TextBox txtQuantidadeDisponivel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnCadastrar;
    }
}