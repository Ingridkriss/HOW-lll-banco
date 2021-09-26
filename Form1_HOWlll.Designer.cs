
namespace HOW_lll
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao_novo = new System.Windows.Forms.Button();
            this.botao_excluir = new System.Windows.Forms.Button();
            this.botao_salvar = new System.Windows.Forms.Button();
            this.botao_editar = new System.Windows.Forms.Button();
            this.botao_cancelar = new System.Windows.Forms.Button();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.label_ano = new System.Windows.Forms.Label();
            this.label_editora = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_editora = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.Coluna_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_genero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // botao_novo
            // 
            this.botao_novo.Location = new System.Drawing.Point(31, 31);
            this.botao_novo.Name = "botao_novo";
            this.botao_novo.Size = new System.Drawing.Size(75, 23);
            this.botao_novo.TabIndex = 0;
            this.botao_novo.Text = "Novo";
            this.botao_novo.UseVisualStyleBackColor = true;
            // 
            // botao_excluir
            // 
            this.botao_excluir.Location = new System.Drawing.Point(178, 31);
            this.botao_excluir.Name = "botao_excluir";
            this.botao_excluir.Size = new System.Drawing.Size(75, 23);
            this.botao_excluir.TabIndex = 1;
            this.botao_excluir.Text = "Excluir";
            this.botao_excluir.UseVisualStyleBackColor = true;
            // 
            // botao_salvar
            // 
            this.botao_salvar.Location = new System.Drawing.Point(317, 31);
            this.botao_salvar.Name = "botao_salvar";
            this.botao_salvar.Size = new System.Drawing.Size(75, 23);
            this.botao_salvar.TabIndex = 2;
            this.botao_salvar.Text = "Salvar";
            this.botao_salvar.UseVisualStyleBackColor = true;
            this.botao_salvar.Click += new System.EventHandler(this.botao_salvar_Click);
            // 
            // botao_editar
            // 
            this.botao_editar.Location = new System.Drawing.Point(450, 31);
            this.botao_editar.Name = "botao_editar";
            this.botao_editar.Size = new System.Drawing.Size(75, 23);
            this.botao_editar.TabIndex = 3;
            this.botao_editar.Text = "Editar";
            this.botao_editar.UseVisualStyleBackColor = true;
            // 
            // botao_cancelar
            // 
            this.botao_cancelar.Location = new System.Drawing.Point(588, 31);
            this.botao_cancelar.Name = "botao_cancelar";
            this.botao_cancelar.Size = new System.Drawing.Size(75, 23);
            this.botao_cancelar.TabIndex = 4;
            this.botao_cancelar.Text = "Cancelar";
            this.botao_cancelar.UseVisualStyleBackColor = true;
            this.botao_cancelar.Click += new System.EventHandler(this.botao_cancelar_Click);
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(28, 99);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(40, 13);
            this.label_codigo.TabIndex = 5;
            this.label_codigo.Text = "Código";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(28, 130);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(42, 13);
            this.label_genero.TabIndex = 6;
            this.label_genero.Text = "Gênero";
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(28, 162);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(35, 13);
            this.label_titulo.TabIndex = 7;
            this.label_titulo.Text = "Título";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Location = new System.Drawing.Point(28, 194);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(32, 13);
            this.label_autor.TabIndex = 8;
            this.label_autor.Text = "Autor";
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.Location = new System.Drawing.Point(28, 222);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(26, 13);
            this.label_ano.TabIndex = 9;
            this.label_ano.Text = "Ano";
            // 
            // label_editora
            // 
            this.label_editora.AutoSize = true;
            this.label_editora.Location = new System.Drawing.Point(28, 257);
            this.label_editora.Name = "label_editora";
            this.label_editora.Size = new System.Drawing.Size(40, 13);
            this.label_editora.TabIndex = 10;
            this.label_editora.Text = "Editora";
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(28, 290);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(55, 13);
            this.label_descricao.TabIndex = 11;
            this.label_descricao.Text = "Descrição";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(104, 99);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(62, 20);
            this.tb_codigo.TabIndex = 12;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(104, 162);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(161, 20);
            this.tb_titulo.TabIndex = 14;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(104, 287);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(161, 71);
            this.tb_descricao.TabIndex = 15;
            // 
            // tb_editora
            // 
            this.tb_editora.Location = new System.Drawing.Point(104, 257);
            this.tb_editora.Name = "tb_editora";
            this.tb_editora.Size = new System.Drawing.Size(161, 20);
            this.tb_editora.TabIndex = 16;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(104, 222);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(62, 20);
            this.tb_ano.TabIndex = 17;
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(104, 194);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(161, 20);
            this.tb_autor.TabIndex = 18;
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_codigo,
            this.Coluna_genero,
            this.Coluna_autor,
            this.Coluna_titulo,
            this.Coluna_ano,
            this.Coluna_editora,
            this.Coluna_descricao});
            this.dtgrid.Location = new System.Drawing.Point(1, 364);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(752, 179);
            this.dtgrid.TabIndex = 20;
            // 
            // Coluna_codigo
            // 
            this.Coluna_codigo.HeaderText = "Código";
            this.Coluna_codigo.Name = "Coluna_codigo";
            this.Coluna_codigo.Width = 70;
            // 
            // Coluna_genero
            // 
            this.Coluna_genero.HeaderText = "Gênero";
            this.Coluna_genero.Name = "Coluna_genero";
            this.Coluna_genero.Width = 90;
            // 
            // Coluna_autor
            // 
            this.Coluna_autor.HeaderText = "Autor";
            this.Coluna_autor.Name = "Coluna_autor";
            // 
            // Coluna_titulo
            // 
            this.Coluna_titulo.HeaderText = "Título";
            this.Coluna_titulo.Name = "Coluna_titulo";
            this.Coluna_titulo.Width = 150;
            // 
            // Coluna_ano
            // 
            this.Coluna_ano.HeaderText = "Ano";
            this.Coluna_ano.Name = "Coluna_ano";
            this.Coluna_ano.Width = 50;
            // 
            // Coluna_editora
            // 
            this.Coluna_editora.HeaderText = "Editora";
            this.Coluna_editora.Name = "Coluna_editora";
            this.Coluna_editora.Width = 90;
            // 
            // Coluna_descricao
            // 
            this.Coluna_descricao.HeaderText = "Descrição";
            this.Coluna_descricao.Name = "Coluna_descricao";
            this.Coluna_descricao.Width = 200;
            // 
            // tb_genero
            // 
            this.tb_genero.Location = new System.Drawing.Point(104, 130);
            this.tb_genero.Name = "tb_genero";
            this.tb_genero.Size = new System.Drawing.Size(118, 20);
            this.tb_genero.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 550);
            this.Controls.Add(this.tb_genero);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_editora);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.label_editora);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label_genero);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.botao_cancelar);
            this.Controls.Add(this.botao_editar);
            this.Controls.Add(this.botao_salvar);
            this.Controls.Add(this.botao_excluir);
            this.Controls.Add(this.botao_novo);
            this.Name = "Form1";
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_novo;
        private System.Windows.Forms.Button botao_excluir;
        private System.Windows.Forms.Button botao_salvar;
        private System.Windows.Forms.Button botao_editar;
        private System.Windows.Forms.Button botao_cancelar;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.Label label_editora;
        private System.Windows.Forms.Label label_descricao;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_editora;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_descricao;
        private System.Windows.Forms.TextBox tb_genero;
    }
}

