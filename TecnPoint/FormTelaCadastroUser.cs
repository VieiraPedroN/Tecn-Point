using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo;
using TecnPoint.Service;

namespace TecnPoint.Interface
{
    public partial class FormTelaCadastroUser : Form
    {
        ServUsuario validarCadastro;
        ServUsuario cadastroUsuarios;
        FormTelaFuncionario telaFuncionario;
        ModeloUsuario modeloUsuario;
        public FormTelaCadastroUser(FormTelaFuncionario telaFuncionarioParam, ModeloUsuario usuario)
        {
            modeloUsuario = usuario;
            validarCadastro = new ServUsuario();
            cadastroUsuarios = new ServUsuario();
            telaFuncionario = telaFuncionarioParam;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarCadastro.ValidarNome(txtbNome.Text) &&
                validarCadastro.ValidarEmail(txtbEmail.Text) &&
                validarCadastro.ValidarSenha(txtbSenha.Text) &&
                validarCadastro.ValidarTipoUsuario(cbbTipoUsuário.Text))
            {
                var cadastro = cadastroUsuarios.CadastrarUsuario(txtbNome.Text, txtbEmail.Text.ToLower(), txtbSenha.Text, cbbTipoUsuário.Text);
                if (cadastro)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    telaFuncionario.CarregarTelaInicio();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            telaFuncionario.CarregarTelaInicio();
            this.Close();
        }

        private void txtbNome_Leave(object sender, EventArgs e)
        {
            if (!validarCadastro.ValidarNome(txtbNome.Text))
            {
                errorProvider1.SetError(txtbNome, "Nome inválido");
            }
            else
            {
                errorProvider1.SetError(txtbNome, "");
            }
        }

        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if (!validarCadastro.ValidarEmail(txtbEmail.Text))
            {
                errorProvider1.SetError(txtbEmail, "Email inválido");
            }
            else
            {
                errorProvider1.SetError(txtbEmail, "");
            }
        }

        private void txtbSenha_Leave(object sender, EventArgs e)
        {
            if (!validarCadastro.ValidarSenha(txtbSenha.Text))
            {
                errorProvider1.SetError(txtbSenha, "Senha inválido");
            }
            else
            {
                errorProvider1.SetError(txtbSenha, "");
            }
        }

        private void cbbTipoUsuário_Leave(object sender, EventArgs e)
        {
            if (!validarCadastro.ValidarTipoUsuario(cbbTipoUsuário.Text))
            {
                errorProvider1.SetError(cbbTipoUsuário, "Tipo de usuário inválido");
            }
            else
            {
                errorProvider1.SetError(cbbTipoUsuário, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if((lblInfoEmail.Visible == false && lblExclamacao.Visible == false))
            {
                lblInfoEmail.Visible = true;
                lblExclamacao.Visible = true;
            }
            else
            {
                lblInfoEmail.Visible = false;
                lblExclamacao.Visible = false;
            }
        }
    }
}
