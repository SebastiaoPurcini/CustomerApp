# Projeto CustomerApp
An app to test and improve my knowledge

** COMO INICIAR **

Para o projeto, foi utilizado o SQL Server local DB. Deverá assim possuir uma base de dados para execução.
A string de conexão, para alterações e encontra em appsettings.json(DBConnection)
Em startup.cs, foi deixada a configuração comentada para uso do MySql caso necessário(Deverá ser instalado o EF for MySql).

- Rodar no Manager Console:

update-database -verbose -context AppDbContext

Obs: Também poderá ser criada a tabela através do script "1 - Create_Table_Customer.sql", na pasta "db"

A pasta "db" também contêm o script "2 - Insert_Table_Customer.sql", para inciar o projeto com registros para teste.

A rotina desenvolvida pode ser acessada através do menu **Clientes**