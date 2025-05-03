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
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Interface
{
    public partial class FormDetalhesChamado : Form
    {
        private FormTelaAcompanharChamado formPai;
        private ExibicaoChamado dadosChamado;
        public CarregaCbxStatus ServCarregaStatus = new CarregaCbxStatus();
        public CarregaCbxFunc ServCarregaNomesFunc = new CarregaCbxFunc();
        public CarregaCbxPrioridade ServCarregaPrioridade = new CarregaCbxPrioridade();
        public AtribuiPrioridade ServAtribuiPrioridade = new AtribuiPrioridade();
        public AtribuiStatus ServAtribuiStatus = new AtribuiStatus();
        public AtribuicaoChamado ServAtribuiCham = new AtribuicaoChamado();
        public ServCarregarMensagens ServCarregarMensagens = new ServCarregarMensagens();
        public ServEnviarMensagem ServEnviarMensagem = new ServEnviarMensagem();
        private DadosUsuario usuarioLogado;

        public FormDetalhesChamado(ExibicaoChamado dadosChamado, FormTelaAcompanharChamado acompanharChamado, DadosUsuario usuarioParam)
        {
            this.usuarioLogado = usuarioParam;
            this.formPai = acompanharChamado;
            this.dadosChamado = dadosChamado;
            InitializeComponent();
        }

        private bool carregandoCombo = true;

        private void PreencherDetalhes()
        {
            label1.Text = dadosChamado.Titulo;
            label2.Text = dadosChamado.NomeCliente;
            label3.Text = dadosChamado.Status;
            label4.Text = dadosChamado.NomeFuncionario;
            label5.Text = dadosChamado.Prioridade;
        }

        private void FormDetalhesChamado_Load(object sender, EventArgs e)
        {
            PreencherDetalhes();
            Label label6 = new Label { Text = $"{dadosChamado.Descricao}", Location = new Point(22, 40), Size = new Size(250, 200), Font = new Font("Consolas", 9) };
            Controls.Add(label6);
            //ServCarregaStatus.CarregaStatus(cbxStatus);
            ServCarregaNomesFunc.CarregaNomeFunc(cbxNomeFunc);
            //ServCarregaPrioridade.CarregaPrioridade(cbxPrioridade);
            CarregaMensagem();
            carregandoCombo = false;
            cbxStatus.SelectedIndex = 0;
            cbxPrioridade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPai.CarregarChamados();
            formPai.MostrarCards();
        }

        private void cbxNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoCombo && cbxNomeFunc.SelectedItem != null)
            {
                var funcionarioSelecionado = cbxNomeFunc.SelectedItem as DadosUsuario;
                if (funcionarioSelecionado != null)
                {
                    ServAtribuiCham.AtribuiChamado(dadosChamado.IdChamado, funcionarioSelecionado.IdUsuario);
                    label4.Text = funcionarioSelecionado.Nome;
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
                    ServAtribuiStatus.AtribuirStatus(dadosChamado.IdChamado, statusAtualizado);
                    label3.Text = statusAtualizado;
                }
            }
        }

        private void cbxPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregandoCombo && cbxPrioridade.SelectedItem != null)
            {
                if(cbxPrioridade.SelectedIndex != 0)
                { 
                    string prioridadeAtualizada = cbxPrioridade.Text;
                    ServAtribuiPrioridade.AtribuirPrioridades(dadosChamado.IdChamado, prioridadeAtualizada);
                    label5.Text = prioridadeAtualizada;
                }
            }
        }

        private void CarregaMensagem()
        {
            List<DadosMensagens> listaMensagens = new List<DadosMensagens>();
            listaMensagens = ServCarregarMensagens.ObterMensagens(dadosChamado.IdChamado);

            foreach (var mensagem in listaMensagens)
            {
                ExibeMensagens(mensagem.NomeRemetente, mensagem.Mensagem); //Exibe as mensagem, passa os dados da listaMensagens para a função
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DadosMensagens EnvioMensagem = new DadosMensagens(tbxMensagem.Text, dadosChamado.IdChamado, usuarioLogado.IdUsuario);
            ServEnviarMensagem.EnviarMensagem(EnvioMensagem);//registra a mensagem no banco
            ExibeMensagens(usuarioLogado.Nome, tbxMensagem.Text);//exibe a mensagem que o usuárioLogado acabou de enviar
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

        
    }
}

