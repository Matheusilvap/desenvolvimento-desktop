using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CarregarTodasCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoriaRepository = new CategoriaRepository();

            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cbStatus.SelectedIndex;



            var CategoriaRepository = new CategoriaRepository ();
            var resultado = categoriaRepository.CadastrarCategoria(categoria);
            if (resultado)
            {
                MessageBox.Show(text: "Categoria cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show(text: "Erro ao cadastrar categoria");
            }
            CarregarTodasCategorias();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                MessageBox.Show($"Houver um erro ao clicar 2 vezes sobre o Grid");
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var CategoriaId = (int)row.Cells[0].Value;

            var categoriaRepository = new CategoriaRepository();
            var categoria = categoriaRepository.obterCategoroaPorId(2);

            if (categoria == null)
            {
                MessageBox.Show($"Categoria: #{CategoriaId} não foi encontrada");
                return;
            }

            txtId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            cbStatus.SelectedIndex = (int) categoria.Status;  
            txtCriacao.Text = categoria.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtAlteracao.Text = categoria.DataAlteracao.ToString("dd/MM/yyyy HH:mm");
        }

        private void CarregarTodasCategorias()
        {
            
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategoria();
            

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da Categoria"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de cadastro",
                DefaultCellStyle = new DataGridViewCellStyle {Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Altercação",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            });

            dataGridView1.DataSource = listaDeCategorias;

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtAlteracao.Text = string.Empty;
            txtCriacao.Text = string.Empty;
            cbStatus.SelectedIndex = -1;
        }
    }
}
