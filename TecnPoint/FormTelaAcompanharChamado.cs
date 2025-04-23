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
using TecnPoint.Modelo.DadosUsuario;
using TecnPoint.Service.ObterChamadosPorUsuario;

namespace TecnPoint.Interface
{
    public partial class FormTelaAcompanharChamado : Form
    {
        private DadosUsuario usuarioLogado;
        public FormTelaAcompanharChamado(DadosUsuario dadosUsuario)
        {
            this.usuarioLogado = dadosUsuario;
            InitializeComponent();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void CarregarChamados()
        {
            ObterChamadosPorUsuario service = new ObterChamadosPorUsuario();
            var chamados = service.BuscarChamados(usuarioLogado.IdUsuario, usuarioLogado.TipoUsuario);
            foreach (var chamado in chamados)
            {
                GroupBox card = new GroupBox
                {
                    Size = new Size(500, 85),
                    Font = new Font("Consolas", 11, FontStyle.Bold),

                    Cursor = Cursors.Hand
                };

                Label lblTitulo = new Label { Text = $"{chamado.Titulo}", Location = new Point(10, 20), AutoSize = true };
                Label lblCliente = new Label { Text = $"Criado por: {chamado.NomeCliente}", Location = new Point(10, 55), AutoSize = true };
                Label lblFuncionario = new Label { Text = $"Atribuido: {chamado.NomeFuncionario}", Location = new Point(275, 55), AutoSize = true };
                Label lblStatus = new Label { Text = $"Status: {chamado.Status}", Location = new Point(275, 20), AutoSize = true };

                card.Controls.Add(lblTitulo);
                card.Controls.Add(lblCliente);
                card.Controls.Add(lblFuncionario);
                card.Controls.Add(lblStatus);

                card.Tag = chamado;

                card.Click += (s, e) =>
                {
                    AbrirDetalhes((ExibicaoChamado)card.Tag);
                };

                lblTitulo.Click += (s, e) => AbrirDetalhes(chamado);
                lblCliente.Click += (s, e) => AbrirDetalhes(chamado);
                lblFuncionario.Click += (s, e) => AbrirDetalhes(chamado);
                lblStatus.Click += (s, e) => AbrirDetalhes(chamado);


                void AbrirDetalhes(ExibicaoChamado chamado)
                {
                    panel1.BringToFront();

                    FormDetalhesChamado detalhesChamado = new FormDetalhesChamado(chamado, this);
                    detalhesChamado.TopLevel = false;

                    panel1.Controls.Clear();
                    panel1.Controls.Add(detalhesChamado);
                    detalhesChamado.Show();
                }


                int marginHorizontal = (flowLayoutPanel1.ClientSize.Width - card.Width) / 2;
                card.Margin = new Padding(marginHorizontal, 2, 0, 12);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        public void MostrarCards() 
        {
            flowLayoutPanel1.BringToFront();
        }

        private void FormTelaAcompanharChamado_Load(object sender, EventArgs e)
        {
            CarregarChamados();
            flowLayoutPanel1.BringToFront();
        }
    }
}
