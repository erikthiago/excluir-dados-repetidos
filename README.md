# excluir-dados-repetidos
App WinForms utilizando dapper e exclusão em cascata.

  Aplicativo Windows Forms que utiliza dapper para acesso à dados no sql server.
  Não é utilizada uma arquitetura robusta. Apenas uma trivial, pois o intituito do projeto é apenas realizar a exclusão de dados 
em cascata.

## Artigo de referência
 * [Medium](https://medium.com/@erikthiago/delete-cascade-com-dapper-e-winforms-9217f33fa43c) - Artigo que explica em detalhes o código do projeto
   
  ## Frameworks utilizados:<br/>
  - Dapper para acesso a dados.<br/>
  - Microsoft.Extensions.Configuration(.Json) para ler o arquivo json e encontrar a string de conexão com o banco de dados.<br/>
  - Unity para configurar e resolver as dependências.<br/>

## Referências
* [Dapper](http://dapper-tutorial.net/dapper) - Documentação do Dapper
* [Tutorial](http://developerpublish.com/dapper-net-guide-delete-record/) - Como fazer deletes no banco usando Dapper
* [Tutorial 2](http://netcoders.com.br/acesso-a-dados-com-dapper-net/) - Como fazer selects no banco usando Dapper
