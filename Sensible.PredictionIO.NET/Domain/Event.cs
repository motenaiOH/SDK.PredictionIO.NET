using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SDK.PredictionIO.NET.Domain
{
    public class Event : JObject
    {
        public int AppId;
        public string Action;
        public string EntityId;
        public string EntityType;
        public string TargetEntityId;
        public string TargetEntityType;
        public Dictionary<string, object> Properties;

        public Event(int appId, string @event, string entityId, string entityType, string targetEntityId, string targetEntityType, IDictionary<string, IList<string>> properties, DateTime available, DateTime expires)
        {
            this[Constants.AppId] = appId;
            this[Constants.Event] = @event;
            this[Constants.EntityType] = entityType;
            this[Constants.EntityId] = entityId;
            if (!string.IsNullOrWhiteSpace(targetEntityId))
            {
                this[Constants.TargetEntityId] = targetEntityId;
            }
            if (!string.IsNullOrWhiteSpace(targetEntityType))
            {
                this[Constants.TargetEntityType] = targetEntityType;
            }
            if (properties != null)
            {
                var jProperties = new JObject();
                foreach (var property in properties)
                {
                    jProperties[property.Key] = JToken.FromObject(property.Value);
                }
                jProperties[Constants.Property.Expires] = new DateTimeAdapter().Serialize(expires);
                jProperties[Constants.Property.Date] = new DateTimeAdapter().Serialize(DateTime.UtcNow);
                jProperties[Constants.Property.Available] = new DateTimeAdapter().Serialize(available);

                this[Constants.Properties] = jProperties;
            }
            this[Constants.EventTime] = new DateTimeAdapter().Serialize(DateTime.UtcNow);
        }
        /*
        public Event(int appId, string @event, string entityId, string entityType, string targetEntityId, string targetEntityType, Dictionary<string, IList<string>> properties)
        {
            this[Constants.AppId] = appId;
            this[Constants.Event] = @event;
            this[Constants.EntityType] = entityType;
            this[Constants.EntityId] = entityId;
            if (!string.IsNullOrWhiteSpace(targetEntityId))
            {
                this[Constants.TargetEntityId] = targetEntityId;
            }
            if (!string.IsNullOrWhiteSpace(targetEntityType))
            {
                this[Constants.TargetEntityType] = targetEntityType;
            }
            if (properties != null)
            {
                var jProperties = new JObject();
                foreach (var property in properties)
                {
                    jProperties[property.Key] = JToken.FromObject(property.Value);
                }
                this[Constants.Properties] = jProperties;
            }
            this[Constants.EventTime] = new DateTimeAdapter().Serialize(DateTime.UtcNow);
        }
        */

    }
}
