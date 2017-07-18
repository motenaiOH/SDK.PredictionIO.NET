using RestSharp.Deserializers;

namespace SDK.PredictionIO.NET.Clients
{
    public class ItemRecommendation
    {
        public string ItemId { get; set; }
        public float Score { get; set; }


        public override string ToString()
        {
            return string.Format("Item {0}, score {1}", ItemId, Score);
        }
    }
}
