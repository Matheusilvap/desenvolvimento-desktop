namespace MultApps.Windows
{
    partial class FrmCarteirinha
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
            this.lblParque = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCarteirinha = new System.Windows.Forms.Button();
            this.pnlCarteirinha = new System.Windows.Forms.Panel();
            this.pctFaixaEtaria = new System.Windows.Forms.PictureBox();
            this.pnlCarteirinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFaixaEtaria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParque
            // 
            this.lblParque.AutoSize = true;
            this.lblParque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParque.Location = new System.Drawing.Point(134, 9);
            this.lblParque.Name = "lblParque";
            this.lblParque.Size = new System.Drawing.Size(484, 25);
            this.lblParque.TabIndex = 0;
            this.lblParque.Text = "Gerador de carteirinha de acesso ao parque:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(57, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(57, 163);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(61, 186);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(221, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(57, 224);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(158, 20);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Data de Nascimento:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(61, 256);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(221, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // btnCarteirinha
            // 
            this.btnCarteirinha.BackColor = System.Drawing.Color.Red;
            this.btnCarteirinha.Location = new System.Drawing.Point(51, 311);
            this.btnCarteirinha.Name = "btnCarteirinha";
            this.btnCarteirinha.Size = new System.Drawing.Size(231, 34);
            this.btnCarteirinha.TabIndex = 7;
            this.btnCarteirinha.Text = "Gerar Carteirinha";
            this.btnCarteirinha.UseVisualStyleBackColor = false;
            this.btnCarteirinha.Click += new System.EventHandler(this.btnCarteirinha_Click);
            // 
            // pnlCarteirinha
            // 
            this.pnlCarteirinha.Controls.Add(this.pctFaixaEtaria);
            this.pnlCarteirinha.Location = new System.Drawing.Point(551, 107);
            this.pnlCarteirinha.Name = "pnlCarteirinha";
            this.pnlCarteirinha.Size = new System.Drawing.Size(221, 304);
            this.pnlCarteirinha.TabIndex = 8;
            // 
            // pctFaixaEtaria
            // 
            this.pctFaixaEtaria.Location = new System.Drawing.Point(24, 25);
            this.pctFaixaEtaria.Name = "pctFaixaEtaria";
            this.pctFaixaEtaria.Size = new System.Drawing.Size(167, 112);
            this.pctFaixaEtaria.TabIndex = 0;
            this.pctFaixaEtaria.TabStop = false;

            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCarteirinha);
            this.Controls.Add(this.btnCarteirinha);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblParque);
            this.Name = "FrmCarteirinha";
            this.Text = "FrmCarteirinha";
            this.pnlCarteirinha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctFaixaEtaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParque;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCarteirinha;
        private System.Windows.Forms.Panel pnlCarteirinha;
        private System.Windows.Forms.PictureBox pctFaixaEtaria;
    }
}