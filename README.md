# edutech-platform-xunit
# EduTechPlatform

## Visão geral

A EduTechPlatform é uma aplicação desenvolvida em C# com .NET 10, voltada à implementação e validação de regras de negócio acadêmicas e financeiras.

O projeto utiliza testes unitários com xUnit para verificar o funcionamento dos serviços e garantir a qualidade do software.

## Tecnologias utilizadas

- C#
- .NET 10 SDK
- xUnit
- Git e GitHub

## Requisitos do ambiente

Para executar o projeto, é necessário ter instalado:

- .NET 10 SDK
- Git (opcional para clonar o repositório pelo terminal)

## Estrutura do projeto

- `EduTechPlatform.App`: aplicação principal, contendo as classes de serviço.
- `EduTechPlatform.Tests`: projeto responsável pelos testes unitários.

## Serviços da aplicação

### NotaDesempenhoService

Responsável pelo cálculo da média ponderada das notas e pela classificação da situação acadêmica do aluno.

- Calcula a média utilizando os pesos das duas avaliações e do projeto.
- Classifica o aluno como `APROVADO`, `RECUPERACAO` ou `REPROVADO`.

### FrequenciaService

Responsável pelo controle da frequência acadêmica.

- Calcula o percentual de presença do aluno.
- Verifica se o aluno possui pelo menos 75% de presença para aprovação por frequência.

### MatriculaFinanceiraService

Responsável pelas regras financeiras e pela elegibilidade para rematrícula.

- Calcula o valor da mensalidade considerando bolsa de estudos e pontualidade.
- Verifica a possibilidade de rematrícula de acordo com as pendências financeiras e a situação acadêmica.

## Como executar o projeto

Abra um terminal na pasta que contém o arquivo `EduTechPlatform.sln`.

### 1. Restaurar as dependências

```bash
dotnet restore
```

### 2. Compilar a solução

```bash
dotnet build
```

### 3. Executar os testes

```bash
dotnet test
```

O comando `dotnet test` executa os testes automatizados do projeto `EduTechPlatform.Tests`.

## Testes unitários

O projeto utiliza xUnit para validar as regras de negócio por meio de testes parametrizados.

- `[Theory]`: permite executar um mesmo teste com diferentes conjuntos de dados.
- `[InlineData]`: fornece os valores utilizados em cada cenário de teste.

As suítes de testes verificam os cálculos de média, frequência, mensalidade e as condições para rematrícula, incluindo cenários positivos e negativos.

## Integrantes do projeto

- CAUÃ PARREIRAS VIEIRA — RA: 32516918
- MARIA LUÍSA DO CARMO CARDOSO — RA: 325116932
- YASMIN APARECIDA SOUZA DE PAULA — RA: 32612974

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para obter mais informações.
