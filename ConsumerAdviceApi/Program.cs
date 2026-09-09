using System.Net.Http.Json;

const string adviceUrl = "https://api.adviceslip.com/advice";

using var httpClient = new HttpClient();

try
{
  var response = await httpClient.GetFromJsonAsync<AdviceResponse>(adviceUrl);

  if (response?.Slip is null)
  {
    Console.WriteLine("A API não retornou um conselho válido.");
    return;
  }

  Console.WriteLine($"Conselho #{response.Slip.Id}: {response.Slip.Advice}");
}
catch (HttpRequestException exception)
{
  Console.WriteLine($"Não foi possível consultar a API: {exception.Message}");
}

public sealed class AdviceResponse
{
  public AdviceSlip? Slip { get; set; }
}

public sealed class AdviceSlip
{
  public int Id { get; set; }
  public string Advice { get; set; } = string.Empty;
}
