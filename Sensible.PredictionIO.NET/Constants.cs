﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.PredictionIO.NET
{
    public class Constants
    {
        public const int ClientTimeoutMS = 5000;
        public const string RootResource = "/";
        public const string EventsResource = "/events.json";
        public const string EngineResource = "/queries.json";
        public const string EventId = "eventId";
        public const string EntityType = "entityType";
        public const string TargetEntityType = "targetEntityType";
        public const string EntityId = "entityId";
        public const string TargetEntityId = "targetEntityId";
        public const string SetEvent = "$set";
        public const string UnsetEvent = "$unset";
        public const string DeleteEvent = "$delete";
        public const string Item = "item";
        public const string User = "user";
        public const string ItemTypes = "itypes";
        public const string Rating = "rating";
        public const string UserId = "uid";
        public const string ItemIds = "iids";
        public const string Items = "items";
        public const string IsOriginal = "isOriginal";
        public const string MaxNumberOfItems = "n";
        public const string Status = "status";
        public const string Properties = "properties";
        public const string EventTime = "eventTime";
        public const string Alive = "alive";
        public const string AppId = "appId";
        public const string AccessKey = "accessKey";
        public const string Event = "event";
        public const string ApplicationJsonContentType = "application/json";

        public class Property
        {
            public const string Category = "category";
            public const string Available = "available";
            public const string Expires = "expires";
            public const string Date = "date";
            public const string Gender = "gender";
        }


        public class Actions
        {
            public const string View = "view";
            public const string Purchase = "list";
            public const string List = "purchase";
            public const string CategoryPreference = "category-preference";
            public const string AddCart = "add-cart";
            public const string RemoveCart = "remove-cart";
        }
    }
}
