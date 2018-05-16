using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorldConsoleApp
{

  class Program
  {
    static HttpClient client = new HttpClient();

    static void Main()
    {
      RunAsync().Wait();
    }

    static void ShowResponse(String response)
    {
      Console.WriteLine($"WebAPIResponse: " + response);
    }

    static async Task<string> GetResponseAsync(string path)
    {
      var responseMessage = string.Empty;
      HttpResponseMessage response = await client.GetAsync(path);
      if (response.IsSuccessStatusCode)
      {
        responseMessage = await response.Content.ReadAsStringAsync();
      }
      return responseMessage;
    }



    static async Task RunAsync()
    {
      client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiUrl"]);

      try
      {
        var response = await GetResponseAsync(client.BaseAddress.AbsoluteUri);
        ShowResponse(response);

      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      Console.ReadLine();
    }

  }
}
