using SDK.PredictionIO.NET;
using SDK.PredictionIO.NET.Clients;
using Sensible.PredictionIO.NET.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventClient = new EventClient(ConfigurationManager.AppSettings["apiUrl"], int.Parse(ConfigurationManager.AppSettings["appId"]), ConfigurationManager.AppSettings["appKey"]);

            /*
             * Create a item - add any property
             */
            Item productA = new Item("13277", DateTime.UtcNow, DateTime.UtcNow.AddYears(1));
            productA.addPropertie(Constants.Property.Category, new List<string>() { "categoria A", "categoria B" });
            productA.addPropertie(Constants.Property.Gender, new List<string>() { "masculino" });

            Item productB = new Item("13277", DateTime.UtcNow, DateTime.UtcNow.AddYears(1));
            productB.addPropertie(Constants.Property.Category, new List<string>() { "categoria A", "categoria B" });
            productB.addPropertie(Constants.Property.Gender, new List<string>() { "masculino" });




            /*
             * Proccess Single input
             */
            Console.WriteLine( eventClient.SetItem( productA ) );




            /*
             * Proccess list
             */
            List<Item> products = new List<Item>();
            products.Add(productA);
            products.Add(productB);
            // eventClient.SetItemBatch(products);

            Console.ReadLine();
        }
    }
}
