using SDK.PredictionIO.NET;
using SDK.PredictionIO.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensible.PredictionIO.NET.Domain
{
    public class Item
    {
        string itemId;
        DateTime create;
        DateTime available;
        DateTime expires;

        IDictionary<string, IList<string>> properties;

        public Item(string itemId, DateTime available, DateTime expires)
        {
            this.itemId = itemId;
            this.available = available;
            this.expires = expires;
            this.properties =  new Dictionary<string, IList<string>>();
        }

        public void addPropertie(string propertie, IList<string> value)
        {
            this.properties.Add(propertie, value);
        }

        public Event ParseToEvent(int appId, string @event)
        {
            return new Event(appId, @event, this.itemId, Constants.Item, null, null, this.properties, this.available, this.expires);
        }
    }
}
