🏦 Sistema de Contas Bancárias - Exercício de POO
Este projeto foi desenvolvido para colocar em prática os fundamentos da Programação Orientada a Objetos (POO) utilizando C#. O sistema simula o comportamento de diferentes tipos de contas bancárias, aplicando regras de negócio específicas para depósitos e saques.

🚀 Tecnologias Utilizadas
Linguagem: C#

Plataforma: .NET

🧠 Conceitos Aplicados
Abstração: Criação da classe base Contabanco com atributos essenciais (Conta, Nome, Saldo).

Encapsulamento: Uso de modificadores de acesso protected para proteger o saldo de manipulações externas indevidas.

Herança: Especialização das contas através das classes ContaCorrente, Contapoupanca e Containvestimento.

Polimorfismo: Sobrescrita de métodos (override) para implementar cálculos de juros e impostos distintos para cada tipo de conta.

📋 Regras de Negócio Implementadas
Conta Corrente: Operações básicas de saque e depósito.

Conta Poupança:

Aplica 0,5% de juros a cada depósito realizado.

Impede que o saldo fique negativo no saque.

Conta Investimento:

Aplica 0,9% de remuneração em cada depósito.

Aplica 0,1% de imposto sobre o valor de cada saque realizado.

Impede que o saldo fique negativo no saque (considerando valor + imposto).

🛠️ Como rodar o projeto
Clone este repositório.

Abra o arquivo .sln ou a pasta no Visual Studio ou VS Code.

Execute o projeto (F5).
