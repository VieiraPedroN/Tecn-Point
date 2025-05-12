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
using TecnPoint.Modelo.DTO;
using TecnPoint.Service;

namespace TecnPoint.Interface
{
    public partial class FormTelaAcompanharChamado : Form
    {
        private bool _modoDaltonico;
        private ModeloUsuario usuarioLogado;
        ServChamado ServObtemChamados;

        public FormTelaAcompanharChamado(ModeloUsuario dadosUsuario, bool modoDaltonico)
        {
            ServObtemChamados = new ServChamado();
            this.usuarioLogado = dadosUsuario;
            this._modoDaltonico = modoDaltonico;
            InitializeComponent();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        public void CarregarChamados()
        {
            var dadosChamados = ServObtemChamados.BuscarChamados(usuarioLogado.IdUsuario, usuarioLogado.TipoUsuario);
            foreach (var dadosChamado in dadosChamados)
            {
                GroupBox card = new GroupBox
                {
                    Size = new Size(500, 100),
                    Font = new Font("Consolas", 11, FontStyle.Bold),

                    Cursor = Cursors.Hand,

                };

                Label lblTitulo = new Label { Text = $"{dadosChamado.Titulo}", Location = new Point(10, 20), AutoSize = false, Size = new Size(250,40)};
                Label lblCliente = new Label { Text = $"Criado por: {dadosChamado.NomeCliente}", Location = new Point(10, 70), AutoSize = true };
                Label lblFuncionario = new Label { Text = $"Atribuído: {dadosChamado.NomeFuncionario}", Location = new Point(275, 70), AutoSize = true };
                Label lblStatus = new Label { Text = $"Status: {dadosChamado.Status}", Location = new Point(275, 20), AutoSize = true };

                card.Controls.Add(lblTitulo);
                card.Controls.Add(lblCliente);
                card.Controls.Add(lblFuncionario);
                card.Controls.Add(lblStatus);

                card.Tag = dadosChamado;

                card.Click += (s, e) =>
                {
                    AbrirDetalhes((ExibicaoChamado)card.Tag);
                };

                lblTitulo.Click += (s, e) => AbrirDetalhes(dadosChamado);
                lblCliente.Click += (s, e) => AbrirDetalhes(dadosChamado);
                lblFuncionario.Click += (s, e) => AbrirDetalhes(dadosChamado);
                lblStatus.Click += (s, e) => AbrirDetalhes(dadosChamado);


                void AbrirDetalhes(ExibicaoChamado dadosChamado)
                {
                    ModeloUsuario usuarioParam = new ModeloUsuario();
                    usuarioParam = usuarioLogado;
                    panel1.BringToFront();

                    FormDetalhesChamado detalhesChamado = new FormDetalhesChamado(dadosChamado, this, usuarioParam, _modoDaltonico);
                    detalhesChamado.TopLevel = false;

                    panel1.Controls.Clear();
                    panel1.Controls.Add(detalhesChamado);
                    detalhesChamado.Show();
                }


                int marginHorizontal = (flowLayoutPanel1.ClientSize.Width - card.Width) / 2;
                card.Margin = new Padding(marginHorizontal, 2, 0, 12);

                flowLayoutPanel1.Controls.Add(card);
                flowLayoutPanel1.Controls.SetChildIndex(card, 0);
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
