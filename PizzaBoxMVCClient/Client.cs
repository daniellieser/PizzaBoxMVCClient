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
        string url = "https://localhost:44305/api/";
    

    public IEnumerable<Store> GetStores()
    {
      //  var allStores = context.Stores.Select(x => Mapper.Map(x));
      // public IEnumerable<Store> GetAllSuperHeroes()
      // {
      using var client = new HttpClient();
      client.BaseAddress = new Uri(url);
      var response = client.GetAsync("GetStores/GetStores");
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
        
        public IEnumerable<Order> GetHistory(int id) 
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+ "User/" + id);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Order[]>();
                readTask.Wait();
                var history = readTask.Result;
                return history;

            }
            else
                return null;
        }
        public IEnumerable<Store> GetOrders()
        {
            //  var allStores = context.Stores.Select(x => Mapper.Map(x));
            // public IEnumerable<Store> GetAllSuperHeroes()
            // {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var response = client.GetAsync("Order/GetAllOrders");
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

        public bool Save(Models.Order order)
        {
            
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            var json = JsonConvert.SerializeObject(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("Order", data);
            
            response.Wait();

            var result = response.Result;// this holds the output

            Console.WriteLine("Reason phrase is" + response.Result.ReasonPhrase);
            Console.WriteLine("responsecode=" + response.Result.StatusCode);




            return result.IsSuccessStatusCode; 
        }


    }
}