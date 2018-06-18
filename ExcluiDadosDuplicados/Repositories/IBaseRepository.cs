using System;
using System.Linq;

namespace ExcluiDadosDuplicados.Repositories
{
    // Interface responsável por determinar o mínimo necessário para o repositório
    public interface IBaseRepository : IDisposable
    {
        /// <summary>
        /// Realizar a exclusão do dado
        /// </summary>
        /// <param name="Id">Id do Dado necessário</param>
        /// <param name="NomeTabela">Nome da tabela que vai ser usada para excluir o dado</param>.
        /// <param name="nomeCampo">Nome do campo a ser utilizado</param>
        /// <returns>true para a exclusão bem sucedida</returns>
        bool Delete(int id, string nomeTabela, string nomeCampo);
        /// <summary>
        /// Realiza a pesqiuisa dos envolvidos dos dados
        /// </summary>
        /// <returns>Retorna os dadoso</returns>
        IQueryable<IQuery> GetData(string protocol);
        /// <summary>
        /// Retorna os dados relacionados
        /// </summary>
        /// <returns>Retorna os dados relacionados</returns>
        IQueryable<IQuery> GetDataEnvolved(int identifier);
    }
}
