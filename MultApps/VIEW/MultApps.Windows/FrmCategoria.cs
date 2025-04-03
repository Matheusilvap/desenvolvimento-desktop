﻿using MultApps.Models.Entities;
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
        }
    }
}
