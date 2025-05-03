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
        public CarregaComboBox ServCarregaNomesFunc = new CarregaComboBox();
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

        private void PreencherDetalhes()
        {
            label1.Text = dadosChamado.Titulo;
            label2.Text = dadosChamado.Descricao;
            label3.Text = dadosChamado.Status;
            label4.Text = dadosChamado.NomeFuncionario;
            label5.Text = dadosChamado.Prioridade;
        }

        private void FormDetalhesChamado_Load(object sender, EventArgs e)
        {
            PreencherDetalhes();
            Label label6 = new Label { Text = $"{dadosChamado.Descricao}", Location = new Point(51, 70), Size = new Size(250, 200), Font = new Font("Consolas", 13) };
            Controls.Add(label6);
            ServCarregaNomesFunc.CarregaNomeFunc(cbxNomeFunc);//Carregando nome dos clientes para o combobox
            CarregaMensagem();//Carregando mensagens para o FlowlayoutPanel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPai.MostrarCards();
        }

        private void btnAtribuicao_Click(object sender, EventArgs e)
        {
            ServAtribuiCham.AtribuiChamado(dadosChamado.IdChamado, (int)cbxNomeFunc.SelectedValue);
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

