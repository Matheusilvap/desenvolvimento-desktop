using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultApps.Models.Sevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text) )
            {
                MessageBox.Show("Usuário é obrigatorio");
                txtUsuario.Focus();
                return;
            }

            if(string.IsNullOrEmpty(txtSenha.Text) )
            {
                MessageBox.Show("Senha é obrigatoria");
                txtSenha.Focus();
                return;

            }

            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorEmail(txtUsuario.Text);

            if(usuario == null || usuario.Email != txtUsuario.Text )
            {
                MessageBox.Show("usuário não encontrado");
                txtUsuario.Focus(); 
                return;
            }

            if(usuario.Status == StatusEnum.Inativo)
            {
                MessageBox.Show("O usuário está inativo");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text, usuario.Senha);

            if(senhaConfere)
            {
                var formPrincipal = new Principal(usuario);
                formPrincipal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário e senha Invalido");
            }
        }

      

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o email do seu usuário");
                txtUsuario.Focus();
                return;
            }

            var usuarioRepositotory = new UsuarioRepository();

            var novaSenha = CriptografiaService.Criptografar("123456");

            var SenhaAtualizou = usuarioRepositotory.AtualizarSenha(novaSenha,txtUsuario.Text);

            if(SenhaAtualizou)
            {
                MessageBox.Show("Senha atualizada com sucesso.A nova senha é: 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizae a senha");
            }
        }


    }
}
