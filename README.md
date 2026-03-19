# 🚀 Projeto: CI + Qualidade de Código com .NET e SonarCloud

## 📌 Objetivo

Este projeto tem como objetivo demonstrar, de forma prática, a implementação de um fluxo de **Integração Contínua (CI)** com foco em **qualidade de código**, utilizando:

- .NET 10
- Testes automatizados (xUnit)
- Cobertura de código (Coverlet)
- Análise estática com SonarCloud
- GitHub Actions

---

## 🧠 Contexto

Nem sempre um código que passa nos testes é um código saudável.

Este projeto foi criado para demonstrar como ferramentas de análise estática podem ajudar a identificar:

- Code Smells (más práticas)
- Bugs potenciais
- Problemas de manutenção (complexidade)
- Baixa cobertura de testes

---

## ⚙️ Tecnologias utilizadas

- C# / .NET
- xUnit
- Coverlet (coverage)
- SonarCloud
- GitHub Actions

---

## 🔄 Pipeline CI/CD

A pipeline automatiza as seguintes etapas:

1. Build do projeto
2. Execução dos testes
3. Coleta de cobertura de código
4. Análise de qualidade no SonarCloud

### 📄 Exemplo da pipeline

```yaml
- name: Build
  run: dotnet build

- name: Test
  run: dotnet test

- name: Test with coverage
  run: dotnet test --no-build /p:CollectCoverage=true /p:CoverletOutput=./TestResults/coverage /p:CoverletOutputFormat=opencover

- name: Sonar Analysis
  run: dotnet sonarscanner begin ... && dotnet build && dotnet sonarscanner end
