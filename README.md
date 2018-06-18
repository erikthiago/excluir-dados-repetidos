# excluir-dados-repetidos
App WinForms utilizando dapper e exclusão em cascata.

  Aplicativo Windows Forms que utiliza dapper para acesso à dados no sql server.
  Não é utilizada uma arquitetura robusta. Apenas uma trivial, pois o intituito do projeto é apenas realizar a exclusão de dados 
em cascata.
  Estrutura:<br/>
  -csproj<br/>
   --JsonClasses<br/>
    ---ReadJsonSettings.cs = Classe responsável por encontrar o arquivo que guarda a configuração de conexão com o banco de dados<br/>
   --Queries<br/>
    ---Entity1 = Classe que representa a entidade1<br/>
    ---Entity2 = Classe que representa a entidade2<br/>
   --Repositories<br/>
    ---BaseRepository = Classe responsável pelas operações no banco de dados<br/>
    ---IBaseRepository = Interface responsável por determinar o mínimo necessário para o repositório<br/>
    ---IQuery = Interface para ser implementada nas classes de queries para reuso de código<br/>
   --SQLConnections<br/>
    ---DapperDBCOnnection = Classe responsável por conectar no banco e gerenciar as conexões<br/>
   --appsettings.json = arquivo que contém a connectionstring para o banco de dados<br/>
   --Form1 = Formulário (View)<br/>
   --Program.cs = Classe de configuração da aplicação<br/>
   
  #Frameworks utilizados:<br/>
  - Dapper para acesso a dados.<br/>
  - Microsoft.Extensions.Configurations(.Json) para ler o arquivo json e encontrar a string de conexão com o banco de dados.<br/>
  - Unity para configurar e resolver as dependências.<br/>
