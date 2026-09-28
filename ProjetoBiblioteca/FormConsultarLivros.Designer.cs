namespace ProjetoBiblioteca
{
    partial class FormConsultarLivros
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
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.chkSomenteDisponiveis = new System.Windows.Forms.CheckBox();
            this.dvgLivros = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(109, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(82, 23);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar";
            this.lblPesquisar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(283, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(398, 61);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarTitulo.TabIndex = 2;
            this.btnBuscarTitulo.Text = "Buscar por Título";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(340, 32);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(107, 23);
            this.btnBuscarAutor.TabIndex = 3;
            this.btnBuscarAutor.Text = "Buscar por Autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(453, 32);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(107, 23);
            this.btnListarTodos.TabIndex = 4;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkSomenteDisponiveis
            // 
            this.chkSomenteDisponiveis.AutoSize = true;
            this.chkSomenteDisponiveis.Location = new System.Drawing.Point(12, 64);
            this.chkSomenteDisponiveis.Name = "chkSomenteDisponiveis";
            this.chkSomenteDisponiveis.Size = new System.Drawing.Size(127, 17);
            this.chkSomenteDisponiveis.TabIndex = 5;
            this.chkSomenteDisponiveis.Text = "Somente Disponíveis";
            this.chkSomenteDisponiveis.UseVisualStyleBackColor = true;
            this.chkSomenteDisponiveis.CheckedChanged += new System.EventHandler(this.chkSomenteDisponiveis_CheckedChanged);
            // 
            // dvgLivros
            // 
            this.dvgLivros.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvgLivros.AllowUserToAddRows = false;
            this.dvgLivros.AllowUserToDeleteRows = false;
            this.dvgLivros.AllowUserToResizeColumns = false;
            this.dvgLivros.AllowUserToResizeRows = false;
            this.dvgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colAutor,
            this.colEditora,
            this.colAno,
            this.colQuantidadeDisponivel,
            this.colStatus});
            this.dvgLivros.Location = new System.Drawing.Point(14, 93);
            this.dvgLivros.Name = "dvgLivros";
            this.dvgLivros.ReadOnly = true;
            this.dvgLivros.RowHeadersVisible = false;
            this.dvgLivros.Size = new System.Drawing.Size(604, 254);
            this.dvgLivros.TabIndex = 6;
            this.dvgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstLivros_CellContentClick);
            // 
            // colTitulo
            // 
            this.colTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            // 
            // colQuantidadeDisponivel
            // 
            this.colQuantidadeDisponivel.HeaderText = "Disponivel";
            this.colQuantidadeDisponivel.Name = "colQuantidadeDisponivel";
            this.colQuantidadeDisponivel.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // FormConsultarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.dvgLivros);
            this.Controls.Add(this.chkSomenteDisponiveis);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisar);
            this.Name = "FormConsultarLivros";
            this.Text = "Consulta de Livros";
            this.Load += new System.EventHandler(this.FormConsultarLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.CheckBox chkSomenteDisponiveis;
        private System.Windows.Forms.DataGridView dvgLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}