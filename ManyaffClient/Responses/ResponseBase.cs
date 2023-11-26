using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyaffClient.Responses
{
    public class ResponseBase
    {
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string Msg { get; set; } = string.Empty;

        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = false;
    }
}
