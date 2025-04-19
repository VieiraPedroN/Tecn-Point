using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnPoint.Dados;
using TecnPoint.Modelo;
using TecnPoint.Modelo.DadosUsuario;

namespace TecnPoint.Service
{
    public class CadastroChamado
    {
        ClassRepositorioAberturaChamado classRepositorioAberturaChamado;
        
        public CadastroChamado()
        {
            classRepositorioAberturaChamado = new ClassRepositorioAberturaChamado();
        }

        public bool AbrirChamado(string titulo, string descricao,
                                 string prioridade, int idCliente,
                                 int Modulo, int Jornada)
        {
            ClassDadosChamado chamadoParam = new ClassDadosChamado()
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
    }
}
