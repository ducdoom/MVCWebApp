using System.Text.Json.Serialization;

namespace ManyaffClient.Responses
{
    public class DashboardReponse : ResponseBase
    {
        [JsonPropertyName("data")]
        public Data2 Data { get; set; } = new();
    }

    public class Data2
    {
        [JsonPropertyName("data_card")]
        public List<DataCard> DataCard { get; set; } = new();
    }

    public class DataCard
    {
        [JsonPropertyName("label")]
        public string Label = string.Empty;

        [JsonPropertyName("value")]
        public int Value = 0;
    }
}
