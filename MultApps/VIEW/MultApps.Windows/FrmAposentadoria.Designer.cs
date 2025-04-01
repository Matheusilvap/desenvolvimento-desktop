namespace MultApps.Windows
{
    partial class FrmAposentadoria
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.chkFeminino = new System.Windows.Forms.CheckBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.mktbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(12, 158);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(153, 25);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo biológico";
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasculino.Location = new System.Drawing.Point(17, 186);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(115, 28);
            this.chkMasculino.TabIndex = 3;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeminino.Location = new System.Drawing.Point(156, 186);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(109, 28);
            this.chkFeminino.TabIndex = 4;
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(12, 231);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(307, 24);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Tempo de Contribuição (em Anos):";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(12, 267);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(181, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(16, 306);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 27);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Verificar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(8, 96);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(179, 24);
            this.lblNascimento.TabIndex = 8;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // pnlResultado
            // 
            this.pnlResultado.Location = new System.Drawing.Point(328, 186);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(379, 147);
            this.pnlResultado.TabIndex = 10;
            // 
            // mktbNascimento
            // 
            this.mktbNascimento.Location = new System.Drawing.Point(12, 123);
            this.mktbNascimento.Mask = "00/00/0000";
            this.mktbNascimento.Name = "mktbNascimento";
            this.mktbNascimento.Size = new System.Drawing.Size(93, 20);
            this.mktbNascimento.TabIndex = 11;
            this.mktbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Verificador de aposentadoria:";
            // 
            // FrmAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(736, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mktbNascimento);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.chkFeminino);
            this.Controls.Add(this.chkMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmAposentadoria";
            this.Text = "FrmAposentadoria";
            this.Load += new System.EventHandler(this.FrmAposentadoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.CheckBox chkFeminino;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.MaskedTextBox mktbNascimento;
        private System.Windows.Forms.Label label1;
    }
}