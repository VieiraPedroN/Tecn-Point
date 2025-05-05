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
                            "\n1 - Aplicativo externo não está abrindo\n2 - Lentidão e travamentos frequentes do sistema ou aplicativos\n3 - Aparece uma mensagem de erro e você não sabe o que é\n4 - Um programa externo pede uma senha ou código que você não tem\n 5 - Como cadastrar um novo usuário";
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
                        return "1 - Aplicativo externo não está abrindo\n• Tente reiniciar o computador e abrir o programa novamente. " +
                            "\nSe o problema continuar, pode ser necessário atualizar o computador ou consultar \no suporte.";
                    }
                    else if (opcaoUsuario == "2")
                    {
                        return "2 - Lentidão e travamentos frequentes do sistema ou aplicativos\n" +
                            "• Reiniciar o programa ou o computador para eliminar erros temporários.";
                    }
                    else if (opcaoUsuario == "3")
                    {
                        return "3 - Aparece uma mensagem de erro e você não sabe o que é\n" +
                            "• Reiniciar o aplicativo e, se necessário, o computador." +
                            "• Desinstalar e reinstalar o aplicativo para corrigir arquivos corrompidos" +
                            "• Se o erro continuar, informe a mensagem para o suporte técnico.";
                    }
                    else if(opcaoUsuario == "4")
                    {
                        return "4 - O programa pede uma senha ou código que você não tem" +
                            "\n• Verifique com o responsável pelo sistema ou setor de TI se você tem acesso autorizado." +
                            "\n• Se for um programa novo, peça que enviem a senha ou licença correta.";
                    }
                        else if(opcaoUsuario == "5")
                    {
                        return "5 - Como cadastrar um novo usuário ❓\n" +
                            "• Para cadastrar um novo usuário, por favor encaminhar um chamado para o suporte com os seguintes dados: nome, e-mail, senha padrão, tipo do usuário.";
                    }
                    else
                    {
                        return "Opção inválida! Insira uma das respostas acima";
                    }
                case "sub_Hardware":
                    if(opcaoUsuario == "1")
                    {
                        return "1 - Teclado ou mouse não funcionam\n• Desconecte e conecte novamente. Tente trocar de porta USB. Se for sem fio, verifique a bateria.";
                    } else if(opcaoUsuario == "2")
                    {
                        return "2 - Monitor sem imagem\n• Verifique se o cabo de vídeo está bem conectado e se o monitor está ligado. Tente reiniciar o computador.";
                    }else if(opcaoUsuario == "3")
                    {
                        return "3 - Impressora não está imprimindo\n• Verifique se a impressora está conectada corretamente e ligada. Confira também se há papel e tinta/cartucho.";
                    }else if(opcaoUsuario == "4")
                    {
                        return "4 - Falhas no som (alto-falante/fone)\n• Veja se o volume está ativado e se o dispositivo correto está selecionado\n (clique no ícone de som no canto inferior direito >> seta para cima >> selecione o dispositvo). Teste com outro fone ou alto-falante.";
                    }else if(opcaoUsuario == "5")
                    {
                        return "5 - Superaquecimento do computador\n• Verifique se a ventoinha que se localiza na parte de trás do gabinete (caixa do computador) está funcionando. Caso não esteja funcionando (girando), abra um chamado para o suporte.";
                    }else
                    {
                        return "Opção inválida! Insira uma das respostas acima";
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
                MaximumSize = new Size(flpChatbot.Width - 30, 0),
            };

            Label lblMensagem = new Label()
            {
                Text = $"{mensagem}",
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
            };

            mensagemNoPanel.Controls.Add(lblMensagem);
            flpChatbot.Controls.Add(mensagemNoPanel);

            flpChatbot.ScrollControlIntoView(mensagemNoPanel);
        }
    }
}
