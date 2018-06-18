using ExcluiDadosDuplicados.JsonClasses;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ExcluiDadosDuplicados.SQLConnections
{
    // Classe responsável por conectar no banco e gerenciar as conexões
    public class DapperDBConnection : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public DapperDBConnection()
        {
            ReadJsonSettings readJsonSettings = new ReadJsonSettings();
            Connection = new SqlConnection(readJsonSettings.ConnectionString());
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
