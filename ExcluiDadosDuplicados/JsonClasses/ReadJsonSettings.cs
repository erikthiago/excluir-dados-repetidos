using Microsoft.Extensions.Configuration;
using System.IO;

namespace ExcluiDadosDuplicados.JsonClasses
{
    // Classe responsável por encontrar o arquivo que guarda a configuração de conexão com o banco de dados
    public class ReadJsonSettings
    {
        public string ConnectionString()
        {
            return GetConnectionString();
        }

        private string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return (config.GetConnectionString("connectionString"));
        }
    }
}
