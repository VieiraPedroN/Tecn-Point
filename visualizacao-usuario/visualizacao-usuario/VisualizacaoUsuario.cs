namespace visualizacao_usuario
{
    public partial class VisualizacaoUsuario : Form
    {
        private void CarregarFormulario(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }
        public VisualizacaoUsuario()
        {
            InitializeComponent();
            CarregarFormulario(new AcompanharChamado());
        }

        private void buttonAcompanharChamado_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CarregarFormulario(new AcompanharChamado());
        }

        private void buttonCriarChamado_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CarregarFormulario(new CriarChamado());
        }
    }
}
