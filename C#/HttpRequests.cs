using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;

namespace ConsoleAPP
{
    static class HttpRequests
    {
        private static string _baseUrl = "https://jsonmock.hackerrank.com/api/football_matches?year=2011";
        private static HttpClient _httpClient;
        private static int qtdEmpates;
        public static void MainHttpRequest()
        {
            //TODO
            // Pegar a primeira página e retornar a informação de total de páginas 
            // Com essa informação realizar o loop e buscar por página sempre retornando a quantidade de jogos que foram empate
            int page = 1;
            int totalPage = 1;
            _httpClient = new HttpClient();

            do
            {
                var tarefa = _httpClient.GetAsync(_baseUrl + $"&page={page}")
                      .ContinueWith((taskWithResponse) =>
                      {
                      //tratando resultado
                          var response = taskWithResponse.Result;
                          var jsonString = response.Content.ReadAsStringAsync();
                          jsonString.Wait();
                          dynamic jsonDynamic = JsonConvert.DeserializeObject(jsonString.Result);                          
                          totalPage = (int)jsonDynamic.total_pages.Value;
                                                    
                          if (jsonDynamic.data.Count > 0)
                          {

                              foreach (var item in jsonDynamic.data)
                              {
                                  if (item.team1goals.Value == item.team2goals.Value)
                                      qtdEmpates += 1;
                              }
                              page++;
                          }

                      });
                tarefa.Wait();

            } while (page <= totalPage);

            Console.WriteLine(qtdEmpates);       



        }
    }
}
