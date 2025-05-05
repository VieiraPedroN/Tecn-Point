using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnPoint.Interface
{
    public partial class FormTelaChatbot : Form
    {
        private string estadoChat = "inicio";

        public FormTelaChatbot()
        {
            InitializeComponent();
        }

        private void FormTelaChatbot_Load(object sender, EventArgs e)
        {
            AdicionaMensagem("TecnBot", "Olá! sou o TecnBot, que pena que está com problemas :(\nmas estou aqui para te ajudar! Onde está o problema? " +
                            "\n\t1 - Sistema\n\t2 - Equipamentos\n\t3 - Rede");
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            //adicionar usuarioLogado
            AdicionaMensagem("Paulo", tbxMensagem.Text);
            string respostaBot = RetornaRespostaBot(tbxMensagem.Text);
            AdicionaMensagem("TecnBot", respostaBot);
            tbxMensagem.Clear();
        }

        private string RetornaRespostaBot(string opcaoUsuario)
        {
            switch (estadoChat)
            {
                
                case "inicio":

                    if (opcaoUsuario == "1")
                    {
                        //faz o chat começar lá embaixo, quando o estadoChat está definido como subopções_Software
                        estadoChat = "sub_Software";
                        return "O seu problema é relacionado a Software??\nUm programa não abre ❓\nUm programa está travando ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Programa/Aplicativo não está abrindo\n2 - Programa apresentando lentidão e falhas\n3 - Problemas com login";
                    }
                    else if (opcaoUsuario == "2")
                    {
                        //faz o chat começar lá embaixo, quando o estado está definido como subopções de hardware
                        estadoChat = "sub_Hardware";
                        return "O seu problema é relacionado a Hardware??\nUm componente está apresentando falhas ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Problemas com teclado/mouse/monitor/fone\n2 - Nenhum problema relacionado aos componentes externos";
                    }
                    else if (opcaoUsuario == "3")
                    {
                        //também faz o chat começar lá embaixo nas subopções de redes
                        estadoChat = "sub_Rede";
                        return "O seu problema é relacionado a Rede??\nA sua internet está lenta ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Sem conexão com a internet\n2 - Lentidão na internet";
                    }
                    else
                    {
                        return "Opção inválida! Insira uma das respostas acima";
                    }

                case "sub_Software":
                    if (opcaoUsuario == "1")
                    {
                        return "1 - Programa/Aplicativo não está abrindo\n[SOLUÇÂO]";
                    }
                    else if (opcaoUsuario == "2")
                    {
                        return "2 - Programa apresentando lentidão e falhas\n[SOLUÇÂO]";
                    }
                    else if (opcaoUsuario == "3")
                    {
                        return "3 - Problemas com login\n[SOLUÇÃO]";
                    }
                    else
                    {
                        return "Opção inválida";
                    }
                default:
                    return "default";
            }
        }

        //Método para exibir as mensagens no FlowLayoutPanel (apenas)
        private void AdicionaMensagem(string remetente, string mensagem)
        {
            Panel mensagemNoPanel = new Panel()
            {
                BackColor = Color.Thistle,
                AutoSize = true,
                Margin = new Padding(5),
                Padding = new Padding(10),
                MaximumSize = new Size(flpChatbot.Width - 30, 0)
            };

            Label lblMensagem = new Label()
            {
                Text = $"{remetente}: {mensagem}",
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            mensagemNoPanel.Controls.Add(lblMensagem);
            flpChatbot.Controls.Add(mensagemNoPanel);

            flpChatbot.ScrollControlIntoView(mensagemNoPanel);
        }
    }
}
