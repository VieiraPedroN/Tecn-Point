using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using TecnPoint.Interface;
using TecnPoint.Modelo.DTO;
using TecnPoint.Service;
using TecnPoint.Modelo;

namespace TecnPoint.Interface
{
    public partial class FormDetalhesChamado : Form
    {
        private FormTelaAcompanharChamado formPai;
        private ExibicaoChamado dadosChamado;

        private ModeloUsuario usuarioLogado;

        //Service para gerenciar as mensagens (carregar o chat e enviá-las)
        public ServMensagens ServMensagensChamado;

        //Service para atualizar os dados do chamado (status, prioridade e funcionário)
        public ServAtualizaChamado ServAtualizaChamado;

        //Inicializando id da última mensagem em 0 para a primeira iteração no foreach
        private int IdUltimaMensagem = 0;

        public FormDetalhesChamado(ExibicaoChamado dadosChamado, FormTelaAcompanharChamado acompanharChamado, ModeloUsuario usuarioParam)
        {
            ServMensagensChamado = new ServMensagens();
            ServAtualizaChamado = new ServAtualizaChamado();
            this.usuarioLogado = usuarioParam;
            this.formPai = acompanharChamado;
            this.dadosChamado = dadosChamado;
            InitializeComponent();
            this.AcceptButton = btnEnviar;
        }

        private bool carregandoCombo = true;

        private void PreencherDetalhes()
        {
            lblTitulo.Text = dadosChamado.Titulo;
            lblCliente.Text = dadosChamado.NomeCliente;
            lblStatus.Text = dadosChamado.Status;
            lblFuncionario.Text = dadosChamado.NomeFuncionario;
            lblPrioridade.Text = dadosChamado.Prioridade;
        }

        private void FormDetalhesChamado_Load(object sender, EventArgs e)
        {
            if (usuarioLogado.TipoUsuario == "Cliente")
            {
                cbxPrioridade.Visible = false;
                cbxStatus.Visible = false;
                cbxNomeFunc.Visible = false;
            }

            PreencherDetalhes();
            Label label6 = new Label { Text = $"{dadosChamado.Descricao}", Location = new Point(22, 40), Size = new Size(250, 200), Font = new Font("Consolas", 9) };
            Controls.Add(label6);
            ServAtualizaChamado.CarregaNomeFunc(cbxNomeFunc);
            CarregaMensagem();
            carregandoCombo = false;
            cbxStatus.SelectedIndex = 0;
            cbxPrioridade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPai.flowLayoutPanel1.Controls.Clear();
            formPai.CarregarChamados();
            formPai.MostrarCards();
        }

        private void cbxNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoCombo && cbxNomeFunc.SelectedItem != null)
            {
                var funcionarioSelecionado = cbxNomeFunc.SelectedItem as ModeloUsuario;
                if (funcionarioSelecionado != null)
                {
                    ServAtualizaChamado.AtribuiChamadoParaFuncionario(dadosChamado.IdChamado, funcionarioSelecionado.IdUsuario);
                    lblFuncionario.Text = funcionarioSelecionado.Nome;
                }
            }
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoCombo && cbxStatus.SelectedItem != null)
            {
                if (cbxStatus.SelectedIndex != 0)
                {
                    string statusAtualizado = cbxStatus.Text;
                    ServAtualizaChamado.AtribuirStatus(dadosChamado.IdChamado, statusAtualizado);
                    lblStatus.Text = statusAtualizado;
                }
            }
        }

        private void cbxPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoCombo && cbxPrioridade.SelectedItem != null)
            {
                if (cbxPrioridade.SelectedIndex != 0)
                {
                    string prioridadeAtualizada = cbxPrioridade.Text;
                    ServAtualizaChamado.AtribuirPrioridades(dadosChamado.IdChamado, prioridadeAtualizada);
                    lblPrioridade.Text = prioridadeAtualizada;
                }
            }
        }

        private void CarregaMensagem()
        {
            List<DadosMensagens> listaMensagens = new List<DadosMensagens>();
            //obtenção da lista de mensagens lidas do banco de dados
            listaMensagens = ServMensagensChamado.ObterMensagens(dadosChamado.IdChamado, IdUltimaMensagem);

            foreach (var mensagem in listaMensagens)
            {
                ExibeMensagens(mensagem.NomeRemetente, mensagem.Mensagem); //Exibe as mensagem, passa os dados da listaMensagens para a função

                //Atualiza o idUltimaConversa
                if (mensagem.IdMensagem > IdUltimaMensagem)
                {
                    IdUltimaMensagem = mensagem.IdMensagem;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DadosMensagens EnvioMensagem = new DadosMensagens(tbxMensagem.Text, dadosChamado.IdChamado, usuarioLogado.IdUsuario);
            ServMensagensChamado.EnviarMensagem(EnvioMensagem);//registra a mensagem no banco
            tbxMensagem.Clear();
        }

        private void ExibeMensagens(string nomeRemetente, string Mensagem)
        {
            Panel mensagemNoPanel = new Panel()
            {
                BackColor = Color.Thistle,
                Width = PanelMsg.Width - 30,
                AutoSize = true,
                Margin = new Padding(5),
                Padding = new Padding(10)
            };

            Label lblMensagem = new Label()
            {
                Text = $"{nomeRemetente} : {Mensagem}",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                MaximumSize = new Size(PanelMsg.Width - 50, 0)
            };

            mensagemNoPanel.Controls.Add(lblMensagem);//adiciona label no panel
            PanelMsg.Controls.Add(mensagemNoPanel);//adiciona panel no flowlayoutpanel
            PanelMsg.ScrollControlIntoView(mensagemNoPanel);//vai pra úlitma mensagem
        }

        private void timerLeituraDeMensagens_Tick(object sender, EventArgs e)
        {
            //a cada 2 segundos carregas as mensagens do banco
            CarregaMensagem();
        }
    }
}

