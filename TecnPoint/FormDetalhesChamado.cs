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
using TecnPoint.Modelo;
using TecnPoint.Interface;

namespace TecnPoint.Interface
{
    public partial class FormDetalhesChamado : Form
    {
        private FormTelaAcompanharChamado formPai;
        private readonly ExibicaoChamado dadosChamado;

        public FormDetalhesChamado(ExibicaoChamado dadosChamado, FormTelaAcompanharChamado acompanharChamado)
        {
            this.formPai = acompanharChamado;
            this.dadosChamado = dadosChamado;
            InitializeComponent();
            PreencherDetalhes();
        }

        private void PreencherDetalhes()
        {
            label1.Text = dadosChamado.Titulo;
            label2.Text = dadosChamado.NomeCliente;
            label3.Text = dadosChamado.Status;
            label4.Text = dadosChamado.NomeFuncionario;
            label5.Text = dadosChamado.Prioridade;
            label6.Text = dadosChamado.Descricao;
        }

        private void FormDetalhesChamado_Load(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPai.MostrarCards();
        }
    }
}

