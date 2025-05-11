using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;
using TecnPoint.Modelo.DadosUsuario;
using TecnPoint.Service.Validação;

namespace TecnPoint.Service
{
    public class CadastroChamado
    {
        private ValidacaoCadastroChamado _validacaoCadastroChamado;
        ClassRepositorioAberturaChamado classRepositorioAberturaChamado;
        
        public CadastroChamado()
        {
            _validacaoCadastroChamado = new ValidacaoCadastroChamado();
            classRepositorioAberturaChamado = new ClassRepositorioAberturaChamado();
        }

        public bool AbrirChamado(string titulo, string descricao,
                                 string prioridade, int idCliente,
                                 int Modulo, int Jornada)
        {
            DadosChamado chamadoParam = new DadosChamado()
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
            classRepositorioAberturaChamado.AbreChamado(chamadoParam);
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
    }
}
