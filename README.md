Tabela de conteúdos
=================
<!--ts-->
   * [Sobre o projeto](#-sobre-o-projeto)
   * [Como executar o projeto](#-como-executar-o-projeto)
     * [Pré-requisitos](#pré-requisitos)
     * [Passo a Passo](#Passo-a-Passor)
<!--te-->

## 💻 Sobre o projeto

 Automação Web com .Net - Estes projeto tem como intuito de contribuir com a comunidade de Qualidade e mostrar meu conhecimento adquirido em automação de testes de FronEnd utilizando a Liguanguem .Net + Specflow + LivingDoc.


A Pagina web utilizada nesse projeto de automação foi desenvolvido por: **Jhonatas Matos** o Site é [BugBank](https://bugbank.netlify.app/).

---

## 🚀 Como executar o projeto

Este projeto é divido em três partes:
1. Clonar o Projeto
2. Instalar Dependencias do LivingDoc


💡Ter versão do SDK instalada na maquina

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[.Net SDK](https://dotnet.microsoft.com/en-us/download), 
Além disto é bom ter um editor para trabalhar com o código como [VSCode](https://code.visualstudio.com/)

#### 🎲 Passo a Passo

```bash
# Clone este repositório
$ git clone git@github.com:fagner-silva/dotnet-specflow.git 
# Acesse a pasta do projeto no terminal/cmd
$ cd dotnet-specflow
# Vá para a pasta server
$ cd FrontEnd
# Instale o LivingDoc
$ dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
# Executar todos os testes
$ Dotnet test 
# Execute teste por tag
$ Dotnet test  --filter Category=Tag
# Executar mais de teste por tag
$ Dotnet test  --filter Category=Tag % Tag
# Para gerar o Relatorio você pode executar o comando 
$ livingdoc test-assembly NomeProjeto.dll -t TestExecution*.json  --output C:/LocalParaSalvarRelatorio
```
💡 Caso você execute um cenário por vez ele irá gerar um TestExecution por teste, o comando TestExecutation*.json esta fazendo o merge automatico caso queira gerar um relatorio com o teste só retirar *
