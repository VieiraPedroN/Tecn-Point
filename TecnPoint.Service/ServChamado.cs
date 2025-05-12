using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;
using TecnPoint.Modelo.DTO;
using TecnPoint.Service.Validação;

namespace TecnPoint.Service
{
    public class ServChamado
    {
        private ValidacaoCadastroChamado _validacaoCadastroChamado;
        DadosChamados dadosChamados;

        public ServChamado()
        {
            _validacaoCadastroChamado = new ValidacaoCadastroChamado();
            dadosChamados = new DadosChamados();
        }

        public bool AbrirChamado(string titulo, string descricao,
                                 string prioridade, int idCliente,
                                 int Modulo, int Jornada)
        {
            ModeloChamado chamadoParam = new ModeloChamado()
            {
                Titulo = titulo,
                Descricao = descricao,
                Status = "Aberto",
                Prioridade = prioridade,
                IdCliente = idCliente,
                IdFuncionario = 1,
                IdModulo = Modulo,
                IdJornada = Jornada
            };
            dadosChamados.AbreChamado(chamadoParam);
            return true;
        }

        public bool ValidarTitulo(string titulo)
        {
            return _validacaoCadastroChamado.txtbTitulo(titulo);
        }
        public bool ValidarDescricao(string descricao)
        {
            return _validacaoCadastroChamado.txtbDescricao(descricao);
        }
        public bool ValidarModulo(ComboBox comboBox)
        {
            return _validacaoCadastroChamado.cbxModulo(comboBox);
        }
        public bool ValidarJornada(ComboBox comboBox)
        {
            return _validacaoCadastroChamado.cbxJornada(comboBox);
        }

        public List<ExibicaoChamado> BuscarChamados(int idusuario, string tipousuario)
        {
            return dadosChamados.ExibeChamadosUsuario(idusuario, tipousuario);
        }

    }
}
