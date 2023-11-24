### 🚧Em Desenvolvimento🚧

- Faltam ser desenvolvidos:
	- Empresa
		- Remover funcionário da empresa
	- Empresa / Estacionamento
		- Registrar entrada de veículo
		- Registrar saída de veículo
	- Mais para frente, se possivel, desenvolvedor front-end

# 📌 Desafio para vaga de Desenvolvimento Back-end .NET
Esse desafio é uma adaptação de um [teste da empresa FCamara](https://github.com/fcamarasantos/backend-test-dotnet), para a vaga de back-end.

Criar uma API REST para gerenciar um estacionamento de carros e motos.

## 🛠️ Funcionalidades
### 🅿️ **Estabelecimento: CRUD;**

1. Criar um cadastro da empresa com os seguintes campos:

- Nome;
- CNPJ;
- Endereço;
- Telefone;
- Estacionamento
	- Quantidade de vagas para motos;
	- Quantidade de vagas para carros.

*__Todos os campos são de preenchimento obrigatório.__*

### 🚗 __Veículos: CRUD;__

2. Criar um cadastro de veículos com os seguintes campos:

- Marca;
- Modelo;
- Cor;
- Placa;
- Tipo.

*__Todos os campos são de preenchimento obrigatório.__*

*__Controle de entrada e saída de veículos.__*

## 🔎 Apresentação Gráfica da Estrutura do Projeto
<div align="center">
	<img src="./Challenge-Graphic.png" style="width: 600px;border: 1px solid;"></img><br>
</div>

## 💻 Requisitos
- A aplicação deverá ser desenvolvida usando .NET a partir da versão 5+;
- Modelagem de dados pode ser no banco de dados de sua preferência, podendo ser um banco relacional ou não relacional (mongodb, SQL Server, PostgreSQL, MySQL, etc);
- Persistência de dados no banco deverá ser feita utilizando o Entity Framework Core;
- O retorno da API deverá ser em formato JSON;
- Utilizar as requisições GET, POST, PUT ou DELETE, conforme a melhor prática;
- Criar o README do projeto descrevendo as tecnologias utilizadas, chamadas dos serviços e configurações necessário para executar a aplicação.

## ⭐ Pontos Extras
- Desenvolvimento baseado em TDD;
- Práticas de modelagem de projeto;
- Criar e configurar o Swagger da API de acordo com as melhores práticas;
- Criar uma API para extração de relatórios da aplicação com as seguintes informações:
- Sumário da quantidade de entrada e saída;
- Sumário da quantidade de entrada e saída de veículos por hora;
- Criar uma solução de autenticação;
- Publicação da aplicação em algum servidor.

## 🎯 Endpoints