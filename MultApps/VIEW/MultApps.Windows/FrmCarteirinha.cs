using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCarteirinha : Form
    {
        public FrmCarteirinha()
        {
            InitializeComponent();
        }

        private void btnCarteirinha_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string dataNascimentoText = txtIdade.Text;

            if (cpf.Length != 11 || !ulong.TryParse(cpf, out _))
            {
                MessageBox.Show("CPF inválido. Por favor, insira um CPF com 11 dígitos.");
                return;
            }

            // Extrair os três dígitos do meio do CPF
            string cpfMeio = cpf.Substring(3, 3);

            // Calcular a idade
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--; // Ajustar se ainda não fez aniversário este ano
           

            if (idade < 12) // Criança
            {
                corZona = Color.Blue;
                pctFaixaEtaria.Image = Image.FromFile("https://cdn-icons-png.flaticon.com/128/3884/3884934.png");
            }
            else if (idade >= 60) // Idoso
            {
                pnlCarteirinha.BackColor = Color.Green;
                pctFaixaEtaria.Image = Image.FromFile ("https://www.picui.pb.gov.br/storage/content/noticias/2824/destaque/1438620643.png");
            }
            else if (idade >= 13 && idade < 20) // Jovem
            {
                corZona = Color.Yellow;
                pctFaixaEtaria.Image = Image.FromFile ("https://img.lovepik.com/png/20231112/group-clipart-group-of-young-people-in-cartoon-vector-illustration_568261_wh1200.png");
            }
            else // Adulto
            {
                corZona = Color.Purple;
                pctFaixaEtaria.Image = Image.FromFile ("https://media.istockphoto.com/id/966013204/vector/business-couple-isometric-avatars.jpg?s=612x612&w=is&k=20&c=QCUJ0Qmc2-weGk8DVvuRYu0rU4tCvmy099IiDuLjvhQ=.png");
            }

         }

    }
    }


