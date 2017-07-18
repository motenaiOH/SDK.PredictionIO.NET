using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SDK.PredictionIO.NET.Domain;
using Sensible.PredictionIO.NET.Domain;

namespace SDK.PredictionIO.NET.Clients
{
    public class EventClient : BaseClient
    {
        public int AppId { get; private set; }

        public EventClient(string eventUrl, int appId, string accessKey)
            : base(eventUrl, accessKey)
        {
            ApiUrl = eventUrl;
            AppId = appId;
        }

        public bool CheckServerStatus()
        {
            var response = Execute(Constants.RootResource, Method.GET, null);
            var value = response[Constants.Status].Value<string>();
            return value == Constants.Alive;
        }

        public void SetItemBatch( List<Item> itens)
        {

            // TODO formatar enviar em lote ao invez de item por item

            if(this.CheckServerStatus())
            {
                foreach(Item item in itens)
                {
                    this.SetItem(item);
                }
            }
        }

        public string SetItem(Item item)
        {
            String result = null;
            if (this.CheckServerStatus())
            {
                Event request = item.ParseToEvent(this.AppId);
                var body = request.ToString(Formatting.None);
                var response = Execute(Constants.EventsResource, Method.POST, body);

                Console.WriteLine(body);
                Console.WriteLine(response);

                result =  response[Constants.EventId].Value<string>();
            }

            return result;
        }
    }
}
