# 🎮 Jogo de Adivinhação 2025

## 📌 Introdução
**O Jogo de Adivinhação** é uma aplicação de linha de comando em **C#** que simula um jogo de adivinhação a partir de um número secreto gerado aleatoriamente. O jogo possui diferentes níveis de dificuldade e um sistema de tentativas. O projeto serve para a utilização de conceitos fundamentais da linguagem, como **loops, estrutura condicional e manipulação de entrada do usuário.**

## 🚀 Funcionalidades

### ✅ Níveis de Dificuldade:

- 1️⃣ Fácil - 10 tentativas
- 2️⃣ Normal - 5 tentativas
- 3️⃣ Difícil - 3 tentativas

### ✅ Geração Aleatória de Números:

- O jogo gera um número secreto entre 1 e 20 para ser adivinhado pelo jogador.

### ✅ Dicas Durante o Jogo:

- O programa informa se o número digitado é maior ou menor que o número secreto.

### ✅ Validação de Entrada:

- Garante que apenas valores numéricos válidos sejam aceitos.

## 💻 Exemplo de Execução:
![](https://i.imgur.com/bhWAl0W.gif)

## 🛠 Como utilizar:

### 🚀 Passo a Passo

1. Clone o repositório ou baixe o código-fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do projeto.
3. Utilize o comando abaixo para restaurar as dependências do projeto:
```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project JogoDeAdivinhacaoConsoleApp1
```
6. Para executar o arquivo compilado, navegue até a pasta `./JogoDeAdivinhacao.ConsoleApp1/bin/Release/net8.0/` e execute o arquivo:
```
JogoDeAdivinhacaoConsoleApp1.exe
```

## ✅ Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

