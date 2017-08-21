using SDK.PredictionIO.NET;
using SDK.PredictionIO.NET.Clients;
using Sensible.PredictionIO.NET.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.IO;
using System.Text;

namespace SimpleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var eventClient = new EventClient(
                                        ConfigurationManager.AppSettings["bcwanalytics_apiUrl"], 
                                        int.Parse(ConfigurationManager.AppSettings["bcwanalytics_appId"]), 
                                        ConfigurationManager.AppSettings["bcwanalytics_appKey"]
                                    );

            /*
             * Create a item - add any property
             */
            DateTime Available = DateTime.UtcNow; // O produto esta disponivel a partir desta data - Antes não entra na recomendacao
            DateTime Expires = DateTime.UtcNow.AddYears(1); // O produto esta disponivel até esta data - Após não entra na recomendacao

            Item productA = new Item("sku_ABCDEFG", Available, Expires);
            productA.addPropertie(Constants.Property.Category, new List<string>() { "categoria A", "categoria B" });
            productA.addPropertie(Constants.Property.Gender, new List<string>() { "masculino" });
            productA.addPropertie(Constants.Property.Color, new List<string>() { "Rosa", "roxo" });
            productA.addPropertie(Constants.Property.Provider, new List<string>() { "Grao de Gente" });
            productA.addPropertie(Constants.Property.Brand, new List<string>() { "Grao de Gente" });
            productA.addPropertie(Constants.Property.Price, new List<string>() { "150,00" });
            productA.addPropertie(Constants.Property.Stock, new List<string>() { "1000" }); // 0 = Produto esgotado. Não entra na recomendacao
            productA.addPropertie(Constants.Property.Active, new List<string>() { "true" }); // true = aparece na recomendacao || false = não entra na recomendacao
            productA.addPropertie(Constants.Property.Name, new List<string>() { "Nome do produto" });
            productA.addPropertie(Constants.Property.Keywords, new List<string>() { "keyword A" , "keyword B" });


            Item productB = new Item("sku_HIJKLMN", DateTime.UtcNow, DateTime.UtcNow.AddYears(1));
            productB.addPropertie(Constants.Property.Category, new List<string>() { "categoria A", "categoria B" });
            productB.addPropertie(Constants.Property.Gender, new List<string>() { "masculino" });


            /*
             * Proccess Single input
             */
            Console.WriteLine( eventClient.UpdateItem( productA, Constants.SetEvent ) );




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
