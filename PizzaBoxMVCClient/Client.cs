using PizzaBoxMVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;


namespace PizzaBoxMVCClient
{
  public class Client
  {

        // PIZZABOXSERVICE: https://localhost:44305/swagger/index.html
        //string url = https://localhost:44305/api/GetStores/GetStores
        // https://localhost:44305/swagger/index.html
        string url = "https://localhost:44305/api/GetStores/GetStores";
    

    public IEnumerable<Store> GetStores()
    {
      //  var allStores = context.Stores.Select(x => Mapper.Map(x));
      // public IEnumerable<Store> GetAllSuperHeroes()
      // {
      using var client = new HttpClient();
      client.BaseAddress = new Uri(url);
      var response = client.GetAsync("");
      response.Wait();

      var result = response.Result;// this holds the output

      if (result.IsSuccessStatusCode)
      {
                var readTask = result.Content.ReadAsAsync<Store[]>();
                readTask.Wait();
                var stores = readTask.Result;
                return stores;

      }
      else
        return null;
    }
  }
}