# excluir-dados-repetidos
App WinForms utilizando dapper e exclusão em cascata.

  Aplicativo Windows Forms que utiliza dapper para acesso à dados no sql server.
  Não é utilizada uma arquitetura robusta. Apenas uma trivial, pois o intituito do projeto é apenas realizar a exclusão de dados 
em cascata.
  Estrutura:
  --csproj
   --JsonClasses
    --ReadJsonSettings.cs = Classe responsável por encontrar o arquivo que guarda a configuração de conexão com o banco de dados
   --Queries
    --Entity1 = Classe que representa a entidade1
    --Entity2 = Classe que representa a entidade2
   --Repositories
    --BaseRepository = Classe responsável pelas operações no banco de dados
    --IBaseRepository = Interface responsável por determinar o mínimo necessário para o repositório
    --IQuery = Interface para ser implementada nas classes de queries para reuso de código
   --DQLConnections
    --DapperDBCOnnection = Classe responsável por conectar no banco e gerenciar as conexões
   --appsettings.json = arquivo que contém a connectionstring para o banco de dados
   --Form1 = Formulário (View)
   --Program.cs = Classe de configuração da aplicação
   
  #Frameworks utilizados:
  - Dapper para acesso a dados
  - Microsoft.Extensions.Configurations(.Json) para ler o arquivo json e encontrar a string de conexão com o banco de dados.
  - Unity para configurar e resolver as dependências
