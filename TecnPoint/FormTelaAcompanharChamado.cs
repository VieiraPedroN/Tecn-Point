using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecnPoint.Modelo.ClassDadosEstaticosUsuario;
using TecnPoint.Service.ObterChamadosPorUsuario;

namespace TecnPoint.Interface
{
    public partial class FormTelaAcompanharChamado : Form
    {
        public FormTelaAcompanharChamado()
        {
            InitializeComponent();
        }
        private void CarregarChamados()
        {
            ObterChamadosPorUsuario service = new ObterChamadosPorUsuario();
            var chamados = service.BuscarChamados(ClassDadosEstaticosUsuario.IdUsuario, ClassDadosEstaticosUsuario.TipoUsuario);
            foreach (var chamado in chamados)
            {
                GroupBox card = new GroupBox
                {
                    Text = chamado.Titulo,
                    Size = new Size(300, 150),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                Label lblCliente = new Label { Text = $"Cliente: {chamado.NomeCliente}", Location = new Point(10, 30), AutoSize = true };
                Label lblFuncionario = new Label { Text = $"Funcionário: {chamado.NomeFuncionario}", Location = new Point(10, 55), AutoSize = true };
                Label lblStatus = new Label { Text = $"Status: {chamado.Status}", Location = new Point(10, 80), AutoSize = true };

                card.Controls.Add(lblCliente);
                card.Controls.Add(lblFuncionario);
                card.Controls.Add(lblStatus);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void FormTelaAcompanharChamado_Load(object sender, EventArgs e)
        {
            CarregarChamados();
        }
    }
}
