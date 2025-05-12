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
using TecnPoint.Interface;

namespace TecnPoint.Interface
{
    public partial class FormTelaCadastroChamado : Form
    {
        private readonly bool _modoDaltonico;
        private FormTelaCliente telaCliente;
        private ModeloUsuario usuarioLogado;
        ServChamado cadastroChamado;
        public FormTelaCadastroChamado(ModeloUsuario dadosUsuario, FormTelaCliente telaClienteParam, bool modoDaltonico)
        {
            this.usuarioLogado = dadosUsuario;
            this.telaCliente = telaClienteParam;
            InitializeComponent();
            cadastroChamado = new ServChamado();
            cbxModulo.SelectedIndex = 0;
            cbxJornada.SelectedIndex = 0;
            cbxPrioridade.SelectedIndex = 0;
            this.AcceptButton = btnAbrirChamado;
            _modoDaltonico = modoDaltonico;
            ModoDaltonismo();
        }
        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            if (cadastroChamado.ValidarModulo(cbxModulo) &&
                cadastroChamado.ValidarJornada(cbxJornada) &&
                cadastroChamado.ValidarTitulo(txtbTitulo.Text) &&
                cadastroChamado.ValidarDescricao(txtbDescricao.Text))

            {
                var cadastrou = cadastroChamado.AbrirChamado(txtbTitulo.Text, txtbDescricao.Text,
                                                                cbxPrioridade.Text, usuarioLogado.IdUsuario,
                                                                cbxModulo.SelectedIndex, cbxJornada.SelectedIndex);
                if (cadastrou == true)
                {
                    MessageBox.Show("Abertura de chamado realizada",
                                    "TECN SOLUTIONS",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    telaCliente.botaoAcompanharChamado_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Abertura de chamado falhou",
                                    "TECN SOLUTIONS",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            telaCliente.CarregarTelaInicio();
            this.Close();
        }
        private void pictureInfoJornada_Click(object sender, EventArgs e)
        {
            if ((lblExplicaJornada.Visible == false))
            {
                lblExplicaJornada.Visible = true;
            }
            else
            {
                lblExplicaJornada.Visible = false;
            }

        }
        private void pictureInfoModulo_Click(object sender, EventArgs e)
        {
            if(lblExplicaModulo.Visible == false)
            {
                lblExplicaModulo.Visible = true;
            }
            else
            {
                lblExplicaModulo.Visible = false;
            }
        }
        private void txtbTitulo_Leave(object sender, EventArgs e) 
        {
            if (!cadastroChamado.ValidarTitulo(txtbTitulo.Text)) 
            {
                errorProvider1.SetError(txtbTitulo, "Campo obrigatório");
            }
            else 
            {
                errorProvider1.SetError(txtbTitulo, "");
            }
        }
        private void txtbDescricao_Leave(object sender, EventArgs e) 
        {
            if (!cadastroChamado.ValidarDescricao(txtbDescricao.Text))
            {
                errorProvider1.SetError(txtbDescricao, "Campo obrigatório");
            }
            else
            {
                errorProvider1.SetError(txtbDescricao, "");
            }
        }
        private void cbxModulo_Leave(object sender, EventArgs e) 
        {
            if (!cadastroChamado.ValidarModulo(cbxModulo)) 
            {
                errorProvider1.SetError(cbxModulo, "Opção invalida");
            }
            else 
            {
                errorProvider1.SetError(cbxModulo, "");
            }
        }
        private void cbxJornada_Leave(object sender, EventArgs e)
        {
            if (!cadastroChamado.ValidarJornada(cbxJornada)) 
            {
                errorProvider1.SetError(cbxJornada, "Opção invalida");
            }
            else 
            {
                errorProvider1.SetError(cbxJornada, "");
            }
        }

        private void ModoDaltonismo()
        {
            if (_modoDaltonico)
            {
                btnAbrirChamado.BackColor = Color.FromArgb(171, 126, 105);
                btnAbrirChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 137);
                btnAbrirChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 163, 89);

                btnCancelarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 137);
                btnCancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 163, 89);

            }
            else
            {
                btnAbrirChamado.BackColor = Color.FromArgb(126, 105, 171);
                btnAbrirChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
                btnAbrirChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);

                btnCancelarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 137, 254);
                btnCancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 89, 253);
            }
        }
    }
}
