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

namespace TecnPoint.Interface
{
    public partial class FormDetalhesChamado : Form
    {
        private FormTelaAcompanharChamado formPai;
        private ExibicaoChamado dadosChamado;
        public CarregaComboBox ServCarregaNomesFunc = new CarregaComboBox();
        public AtribuicaoChamado ServAtribuiCham = new AtribuicaoChamado();

        public FormDetalhesChamado(ExibicaoChamado dadosChamado, FormTelaAcompanharChamado acompanharChamado)
        {
            this.formPai = acompanharChamado;
            this.dadosChamado = dadosChamado;
            InitializeComponent();
        }

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
            Label label6 = new Label { Text = $"{dadosChamado.Descricao}", Location = new Point(51, 70), Size = new Size(250, 200), Font = new Font("Consolas", 13) };
            Controls.Add(label6);
            ServCarregaNomesFunc.CarregaNomeFunc(cbxNomeFunc);//Carregando nome dos clientes para o combobox
            PreencherDetalhes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPai.MostrarCards();
        }

        private void btnAtribuicao_Click(object sender, EventArgs e)
        {
            ServAtribuiCham.AtribuiChamado(dadosChamado.IdChamado, (int)cbxNomeFunc.SelectedValue);
        }
    }
}

