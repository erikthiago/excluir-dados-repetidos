using Dapper;
using ExcluiDadosDuplicados.Queries;
using ExcluiDadosDuplicados.SQLConnections;
using System;
using System.Linq;

namespace ExcluiDadosDuplicados.Repositories
{
    // Classe responsável pelas operações no banco de dados
    public class BaseRepository : IBaseRepository
    {
        public DapperDBConnection _dBConnection;

        public BaseRepository(DapperDBConnection dBConnection)
        {
            _dBConnection = dBConnection;
        }

        /// <summary>
        /// Realiza a exxlusão do registro no banco de dados
        /// </summary>
        /// <param name="id">Campo identificador</param>
        /// <param name="nomeTabela">Nome da tabela que será efetuada a exclusão</param>
        /// <param name="nomeCampo">Nome do campo identificador</param>
        /// <returns>Retorna true caso tenha efetuado a exclusão</returns>
        public bool Delete(int id, string nomeTabela, string nomeCampo)
        {
            string query = "DELETE FROM " + nomeTabela + " WHERE " + nomeCampo + "= " + id;

            var affectedRows = _dBConnection.Connection.Execute(query, new { NomeCampo = nomeCampo });
            return affectedRows > 0;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Realiza a pesquisa no banco de dados 
        /// </summary>
        /// <param name="data">dado a ser pesquisado</param>
        /// <returns>Retorna os dados da tabela</returns>
        public IQueryable<IQuery> GetData(string data)
        {
            return _dBConnection
                .Connection
                .Query<Entity1>(@"SELECT [Id], [Prop1], [Prop2], [Prop3], [Prop4]
                                   FROM Table INNER JOIN Table2 ON Table1_Table2Id = Table2Id
                                         LEFT JOIN Table3 ON Table2_Table3Id = Table3Id
                                   WHERE [Prop1] = @Data AND Prop3 = 1
                                   ORDER BY [Prop3]",
                                   new { Data = data }).AsQueryable();
        }

        /// <summary>
        /// Realiza a pesquisa no banco de dados 
        /// </summary>
        /// <param name="identifier">Identificador</param>
        /// <returns>Retorna os dados</returns>
        public IQueryable<IQuery> GetDataEnvolved(int identifier)
        {
            return _dBConnection
                .Connection
                .Query<Entity2>(@"SELECT [TableId]
                                   FROM Table6 
                                   WHERE [Table3_Table4Id] = @Identifier",
                                   new { Identifier = identifier }).AsQueryable();
        }
    }
}
