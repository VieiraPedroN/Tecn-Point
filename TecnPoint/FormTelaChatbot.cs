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
            AdicionaMensagem("Olá! sou o TecnBot, que pena que está com problemas :(\nmas estou aqui para te ajudar! Onde está o problema? " +
                            "\n\t1 - Software\n\t2 - Hardware\n\t3 - Rede");
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            //adicionar usuarioLogado
            AdicionaMensagem(tbxMensagem.Text);
            string respostaBot = RetornaRespostaBot(tbxMensagem.Text);
            AdicionaMensagem(respostaBot);
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
                        return "O seu problema está relacionado a algum Software ❓ \nUm programa não abre \nUm programa está travando ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Aplicativo externo não está abrindo\n2 - Dificuldade em encontrar funções básicas\n3 - Lentidão e travamentos frequentes do sistema ou aplicativos\n4 - Aparece uma mensagem de erro e você não sabe o que é\n 5 - Programa fecha sozinho ao ser aberto";
                    }
                    else if (opcaoUsuario == "2")
                    {
                        //faz o chat começar lá embaixo, quando o estado está definido como subopções de hardware
                        estadoChat = "sub_Hardware";
                        return "O seu problema está relacionado a Hardware??\nUm componente está apresentando falhas ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Problemas com teclado/mouse\n2 - Monitor sem imagem\n3 - Impressora não está imprimindo" +
                            "\n4 - Falhas no som (alto-falante/fone)\n5 - Superaquecimento do computador";
                    }
                    else if (opcaoUsuario == "3")
                    {
                        //também faz o chat começar lá embaixo nas subopções de redes
                        estadoChat = "sub_Rede";
                        return "O seu problema está relacionado à Rede??\nA sua internet está lenta ❓" +
                            "\n\nSelecione uma das opções abaixo para eu tentar te ajudar..." +
                            "\n1 - Sem conexão com a internet\n2 - Lentidão na internet\n3 - Conexão instável\n4 - Acesso negado em sites específicos\n5 - ";
                    }
                    else
                    {
                        return "Opção inválida! Insira uma das respostas acima";
                    }

                case "sub_Software":
                    if (opcaoUsuario == "1")
                    {
                        return "1 - Programa/Aplicativo não está abrindo\n• Tente reiniciar o computador e abrir o programa novamente. " +
                            "\nSe o problema persistir, verifique se há atualizações pendentes do próprio programa.";
                    }
                    else if (opcaoUsuario == "2")
                    {
                        return "2 - Lentidão e travamentos frequentes do sistema ou aplicativos\n• Reiniciar o programa ou o computador para eliminar erros temporários." +
                            "";
                    }
                    else if (opcaoUsuario == "3")
                    {
                        return "3 - Problemas com login\nVerifique se está digitando corretamente o usuário e a senha. " +
                            "\nNão esqueça de colocar o \"@\" e do ponto final em \".com\" no seu e-mail";
                    }
                    else if(opcaoUsuario == "4")
                    {
                        return "4 - Programa não responde (fica \"congelado\")" +
                            "\nAguarde alguns minutos para ver se o programa volta a responder. " +
                            "\nCaso não volte, finalize o processo pelo Gerenciador de Tarefas e reinicie o aplicativo." +
                            "\nComo acessar o Gerenciador de tarefa: Ctrl+Shift+ESC >> Vá para aba processos >> procure o nome do programa que não está respondendo >> clique nele com botão direito >> \"Finalizar tarefa\"";
                    }
                    else if(opcaoUsuario == "5")
                    {
                        return "5 - Programa fecha sozinho ao ser aberto\n" +
                            "";
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
        private void AdicionaMensagem(string mensagem)
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
                Text = $"{mensagem}",
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            mensagemNoPanel.Controls.Add(lblMensagem);
            flpChatbot.Controls.Add(mensagemNoPanel);

            flpChatbot.ScrollControlIntoView(mensagemNoPanel);
        }
    }
}
