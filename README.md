# Advice Console App

Aplicação de console em C# que consulta a [Advice Slip API](https://api.adviceslip.com/) e exibe um conselho aleatório no terminal.

## Funcionalidades

- Faz uma requisição HTTP GET para `https://api.adviceslip.com/advice`
- Desserializa a resposta JSON diretamente em objetos tipados (`AdviceResponse` / `AdviceSlip`)
- Exibe o conselho retornado, incluindo seu ID
- Trata falhas de conexão/requisição (`HttpRequestException`) e respostas inválidas ou vazias

## Estrutura do código

```
├── Program.cs
```

### Principais componentes

| Componente | Descrição |
|---|---|
| `adviceUrl` | Endpoint da API de conselhos |
| `HttpClient` | Cliente HTTP usado para a requisição |
| `AdviceResponse` | Modelo que representa o objeto raiz do JSON retornado |
| `AdviceSlip` | Modelo que representa o conselho em si (`Id` e `Advice`) |

## Como executar

1. Clone ou copie o código para um projeto de console .NET:
   ```bash
   dotnet new console -n AdviceApp
   cd AdviceApp
   ```
2. Substitua o conteúdo de `Program.cs` pelo código deste repositório.
3. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Exemplo de saída

Em caso de erro de conexão:

```
Não foi possível consultar a API: <mensagem de erro>
```

Em caso de resposta inválida:

```
A API não retornou um conselho válido.
```
