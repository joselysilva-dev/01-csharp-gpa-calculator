<div align="center">

# 🎓 GPA Calculator em C#

### Calculadora de média ponderada desenvolvida como aplicação de console

Projeto criado para praticar fundamentos de C#, .NET 8, lógica de programação,  
operações matemáticas e formatação de resultados no terminal.

![C%23](https://img.shields.io/badge/C%23-2A1835?style=for-the-badge&logo=csharp&logoColor=F4B8E4)
![.NET](https://img.shields.io/badge/.NET_8-2A1835?style=for-the-badge&logo=dotnet&logoColor=C7A0FF)
![Console](https://img.shields.io/badge/Console_App-2A1835?style=for-the-badge&logo=windows-terminal&logoColor=F4B8E4)

</div>

---

## 📌 Sobre o projeto

O **GPA Calculator** calcula a média ponderada de um estudante com base nas notas e na quantidade de créditos das disciplinas.

A aplicação foi desenvolvida em C# como exercício de fundamentos de programação e execução no console.

Os dados utilizados no cálculo estão definidos diretamente no código para demonstrar, de maneira simples, como variáveis, operadores e conversões podem ser combinados na construção de um programa.

> **Status:** projeto de fundamentos concluído.

---

## 🎯 Objetivo

O projeto foi desenvolvido para praticar:

- declaração de variáveis;
- tipos de dados;
- operadores matemáticos;
- cálculo de média ponderada;
- conversão de tipos;
- interpolação de strings;
- formatação numérica;
- organização da saída no console;
- execução de aplicações com .NET;
- controle de versão com Git e GitHub.

---

## 🧮 Como o cálculo funciona

O GPA é calculado por meio de uma média ponderada.

Cada nota é multiplicada pela quantidade de créditos da respectiva disciplina:

```text
Pontos da disciplina = Nota × Créditos
```

Depois, todos os pontos são somados e divididos pela quantidade total de créditos:

```text
GPA = Soma dos pontos ÷ Soma dos créditos
```

No código, o cálculo principal é realizado assim:

```csharp
int totalPoints =
    (grade1 * credit1) +
    (grade2 * credit2) +
    (grade3 * credit3) +
    (grade4 * credit4) +
    (grade5 * credit5);

int totalCredits =
    credit1 +
    credit2 +
    credit3 +
    credit4 +
    credit5;

decimal finalGpa = (decimal)totalPoints / totalCredits;
```

A conversão para `decimal` evita que o resultado seja limitado a um número inteiro.

---

## 📚 Dados utilizados

A aplicação utiliza cinco disciplinas:

| Disciplina | Nota | Créditos |
|---|---:|---:|
| English 101 | 4 | 3 |
| Algebra 101 | 3 | 3 |
| Biology 101 | 3 | 4 |
| Computer Science I | 3 | 4 |
| Psychology 101 | 4 | 3 |

Esses dados estão definidos diretamente no arquivo `program.cs`.

---

## ✨ Funcionalidades

- Armazenamento do nome do estudante
- Definição das disciplinas
- Definição das notas
- Definição dos créditos
- Multiplicação das notas pelos créditos
- Soma dos pontos obtidos
- Soma total dos créditos
- Cálculo automático da média ponderada
- Formatação do GPA com duas casas decimais
- Exibição organizada no console

---

## 💻 Exemplo de saída

```text
====================================
         GPA CALCULATOR
====================================

Student: Josely Silva

Course                  Grade   Credits
------------------------------------
English 101             4       3
Algebra 101             3       3
Biology 101             3       4
Computer Science I      3       4
Psychology 101          4       3
------------------------------------
Final GPA: 3.35
```

---

## 🛠️ Tecnologias e ferramentas

- C#
- .NET 8
- Aplicação de console
- Visual Studio Code
- Git
- GitHub

---

## 📁 Estrutura do projeto

```text
01-csharp-gpa-calculator/
├── .gitignore
├── 01-csharp-gpa-calculator.csproj
├── program.cs
└── README.md
```

### `program.cs`

Contém as variáveis, os dados das disciplinas, a fórmula do GPA e a apresentação dos resultados.

### `01-csharp-gpa-calculator.csproj`

Define a aplicação como executável e configura o projeto para utilizar o .NET 8.

---

## ▶️ Executando localmente

### Pré-requisitos

Instale:

- .NET 8 SDK
- Git

### Clone o repositório

```bash
git clone https://github.com/joselysilva-dev/01-csharp-gpa-calculator.git
```

### Entre na pasta

```bash
cd 01-csharp-gpa-calculator
```

### Execute a aplicação

```bash
dotnet run
```

O resultado será apresentado diretamente no terminal.

---

## 📚 Conceitos praticados

Durante o desenvolvimento foram utilizados:

### Variáveis

```csharp
string studentName = "Josely Silva";
int grade1 = 4;
int credit1 = 3;
```

### Operadores matemáticos

```csharp
grade1 * credit1
```

### Conversão de tipos

```csharp
(decimal)totalPoints
```

### Interpolação de strings

```csharp
Console.WriteLine($"Student: {studentName}");
```

### Formatação numérica

```csharp
Console.WriteLine($"Final GPA: {finalGpa:F2}");
```

O formato `F2` apresenta o resultado com duas casas decimais.

---

## 🚧 Limites do projeto

Esta é uma aplicação introdutória e, atualmente:

- utiliza dados definidos diretamente no código;
- não solicita informações pelo terminal;
- não permite adicionar novas disciplinas durante a execução;
- não armazena dados;
- não utiliza banco de dados;
- não possui interface gráfica;
- não possui testes automatizados.

Essas limitações são compatíveis com o objetivo de praticar os fundamentos da linguagem.

---

## 🔮 Possíveis evoluções

- Solicitar o nome do estudante pelo terminal
- Permitir o cadastro de disciplinas
- Permitir a digitação das notas
- Permitir a digitação dos créditos
- Validar os valores informados
- Utilizar listas para armazenar disciplinas
- Criar classes para representar estudantes e matérias
- Permitir o cálculo para diferentes estudantes
- Adicionar testes automatizados
- Criar uma API para o cálculo do GPA

---

## 👩‍💻 Autora

**Josely Silva Lima**

Estudante do 2º semestre de Engenharia de Software  
Desenvolvedora Backend e Full Stack em formação  
Fundadora da Luara Digital

[![GitHub](https://img.shields.io/badge/GitHub-2A1835?style=for-the-badge&logo=github&logoColor=F4B8E4)](https://github.com/joselysilva-dev)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-7C5CFC?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/joselysilvadev)
[![E-mail](https://img.shields.io/badge/E--mail-D65DB1?style=for-the-badge&logo=gmail&logoColor=white)](mailto:joselysilvadev@gmail.com)

---

<div align="center">

Projeto desenvolvido para registrar minha evolução nos fundamentos de C# e .NET.

</div>
