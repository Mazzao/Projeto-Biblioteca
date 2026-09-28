namespace ProjetoBiblioteca
{
    partial class FormConsultarUsuario
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
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.btnBuscarEmail = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dataUsuario = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Location = new System.Drawing.Point(313, 11);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarNome.TabIndex = 0;
            this.btnBuscarNome.Text = "Buscar por Nome";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarEmail
            // 
            this.btnBuscarEmail.Location = new System.Drawing.Point(313, 40);
            this.btnBuscarEmail.Name = "btnBuscarEmail";
            this.btnBuscarEmail.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarEmail.TabIndex = 1;
            this.btnBuscarEmail.Text = "Buscar por Email";
            this.btnBuscarEmail.UseVisualStyleBackColor = true;
            this.btnBuscarEmail.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(108, 11);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(108, 25);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(273, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dataUsuario
            // 
            this.dataUsuario.AllowUserToAddRows = false;
            this.dataUsuario.AllowUserToDeleteRows = false;
            this.dataUsuario.AllowUserToResizeColumns = false;
            this.dataUsuario.AllowUserToResizeRows = false;
            this.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colEmail,
            this.colTelefone,
            this.colTipo});
            this.dataUsuario.Location = new System.Drawing.Point(12, 109);
            this.dataUsuario.Name = "dataUsuario";
            this.dataUsuario.ReadOnly = true;
            this.dataUsuario.RowHeadersVisible = false;
            this.dataUsuario.Size = new System.Drawing.Size(422, 210);
            this.dataUsuario.TabIndex = 5;
            this.dataUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsuario_CellContentClick);
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(313, 69);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(102, 23);
            this.btnListarTodos.TabIndex = 6;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // FormConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 331);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.dataUsuario);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnBuscarEmail);
            this.Controls.Add(this.btnBuscarNome);
            this.Name = "FormConsultarUsuario";
            this.Text = "FormConsultarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.Button btnBuscarEmail;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dataUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.Button btnListarTodos;
    }
}