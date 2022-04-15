#language: pt-br
Funcionalidade: Login
@IdTeste @BB @After
Esquema do Cenario: Verificar Login com sucesso no BugBank

Dado que estou na pagina inicial da BugBank
Quando  inserir "<email>" e "<senha>"
Então login realizado com sucesso 

Exemplos:

| email                 | senha     |
| Teste123@teste123.com | Teste123  |


@IdTeste1 @BB @After
Esquema do Cenario: Verificar Login com sucesso no BugBank 2

Dado que estou na pagina inicial da BugBank
Quando  inserir "<email>" e "<senha>"
Então login realizado com sucesso 

Exemplos:

| email                 | senha     |
| Teste123@teste123.com | Teste123  |