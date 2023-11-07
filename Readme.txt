Projeto Web API - Desafio BHS
Este projeto foi criado como parte de um desafio e consiste em uma aplicação Web API que lida com operações CRUD básicas em uma entidade chamada "Produto". O projeto está configurado para usar um banco de dados SQL Server. Abaixo, você encontrará detalhes sobre como configurar e executar o projeto.

Configuração do Projeto
Visual Studio:

Abra o Visual Studio.
Clone ou baixe o projeto para sua máquina.
Abra a solução no Visual Studio.
String de Conexão do Banco de Dados:

Certifique-se de que o SQL Server esteja em execução.
Use a seguinte string de conexão para o SQL Server:
sql
Copy code
Data Source=localhost,1433; Initial Catalog=bhs_challenge; User Id=bhs_user; Password=admin
Configuração do Banco de Dados
Migrations:
Certifique-se de que o Entity Framework Core está instalado em seu projeto.
Abra um prompt de comando no diretório raiz do seu projeto.
Execute os seguintes comandos para criar e aplicar a migração inicial:
sql
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
Executando o Projeto
Inicie o Projeto:
No Visual Studio, pressione F5 para iniciar o projeto.