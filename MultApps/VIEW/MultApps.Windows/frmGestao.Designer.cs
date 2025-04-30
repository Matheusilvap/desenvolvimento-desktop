namespace MultApps.Windows
{
    partial class frmGestao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbPreco = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricoa = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblGestao = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.rbInativo);
            this.panel1.Controls.Add(this.rbAtivo);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtImagem);
            this.panel1.Controls.Add(this.lblImagem);
            this.panel1.Controls.Add(this.txtEstoque);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.cmbPreco);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblDescricoa);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Controls.Add(this.lblGestao);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 374);
            this.panel1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1093, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(976, 337);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.Location = new System.Drawing.Point(832, 338);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInativo.Location = new System.Drawing.Point(677, 317);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 20);
            this.rbInativo.TabIndex = 15;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativos";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.Location = new System.Drawing.Point(548, 317);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(62, 20);
            this.rbAtivo.TabIndex = 14;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativos";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(544, 293);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status:";
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(22, 338);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(313, 20);
            this.txtImagem.TabIndex = 12;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(19, 315);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(126, 20);
            this.lblImagem.TabIndex = 11;
            this.lblImagem.Text = "URL da Imagem";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(548, 270);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(313, 20);
            this.txtEstoque.TabIndex = 10;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(544, 247);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(75, 20);
            this.lblEstoque.TabIndex = 9;
            this.lblEstoque.Text = "Estoque*";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(18, 247);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(56, 20);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço*";
            // 
            // cmbPreco
            // 
            this.cmbPreco.FormattingEnabled = true;
            this.cmbPreco.Items.AddRange(new object[] {
            " Todas",
            "Eletrônicos ",
            "Alimentos e Bebidas",
            "Utensílios domésticos",
            "Brinquedos",
            "Materiais Escolares",
            "Calçados",
            "Roupas"});
            this.cmbPreco.Location = new System.Drawing.Point(487, 90);
            this.cmbPreco.Name = "cmbPreco";
            this.cmbPreco.Size = new System.Drawing.Size(244, 21);
            this.cmbPreco.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 145);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1165, 88);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(22, 276);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(313, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblDescricoa
            // 
            this.lblDescricoa.AutoSize = true;
            this.lblDescricoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricoa.Location = new System.Drawing.Point(19, 122);
            this.lblDescricoa.Name = "lblDescricoa";
            this.lblDescricoa.Size = new System.Drawing.Size(86, 20);
            this.lblDescricoa.TabIndex = 3;
            this.lblDescricoa.Text = "Descrição*";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(483, 66);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(84, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria*";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(19, 66);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(139, 20);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Nome do Produto*";
            // 
            // lblGestao
            // 
            this.lblGestao.AutoSize = true;
            this.lblGestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestao.Location = new System.Drawing.Point(16, 16);
            this.lblGestao.Name = "lblGestao";
            this.lblGestao.Size = new System.Drawing.Size(300, 33);
            this.lblGestao.TabIndex = 0;
            this.lblGestao.Text = "Gestão de Produtos ";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(20, 394);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(37, 13);
            this.lblStatus2.TabIndex = 1;
            this.lblStatus2.Text = "Status";
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Location = new System.Drawing.Point(278, 394);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria2.TabIndex = 2;
            this.lblCategoria2.Text = "Categoria";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Todos ",
            "Ativos",
            "Inativos"});
            this.cmbStatus.Location = new System.Drawing.Point(19, 410);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            " Todas",
            "Eletrônicos ",
            "Alimentos e Bebidas",
            "Utensílios domésticos",
            "Brinquedos",
            "Materiais Escolares",
            "Calçados",
            "Roupas"});
            this.cmbCategoria.Location = new System.Drawing.Point(281, 410);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(484, 407);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(160, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo Produto";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(698, 410);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(160, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar Grid";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1193, 214);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblCategoria2);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestao";
            this.Text = "frmGestao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestao;
        private System.Windows.Forms.Label lblDescricoa;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox cmbPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}