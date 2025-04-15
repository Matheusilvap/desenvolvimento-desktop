namespace MultApps.Windows
{
    partial class FormCadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro e Gestão de Usuários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtAcesso);
            this.panel1.Controls.Add(this.txtCadastro);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblAcesso);
            this.panel1.Controls.Add(this.lblCadastro);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(-5, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 415);
            this.panel1.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(122, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 69);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 18);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 18);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(10, 215);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(125, 18);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Data de cadastro:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.Location = new System.Drawing.Point(8, 269);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(165, 18);
            this.lblAcesso.TabIndex = 4;
            this.lblAcesso.Text = "Data do Ultimo Acesso:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(8, 171);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(11, 192);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(153, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(13, 236);
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(151, 20);
            this.txtCadastro.TabIndex = 10;
            // 
            // txtAcesso
            // 
            this.txtAcesso.Location = new System.Drawing.Point(11, 299);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(151, 20);
            this.txtAcesso.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 415);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboBox1.Location = new System.Drawing.Point(13, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(11, 344);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 29);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.TextBox txtCadastro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}