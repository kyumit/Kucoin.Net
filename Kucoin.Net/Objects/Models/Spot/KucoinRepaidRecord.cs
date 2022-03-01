using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kucoin.Net.Objects.Spot
{
    /*
     * "tradeId": "1231141",
            "currency": "USDT",
            "dailyIntRate": "0.0021",
            "interest": "0.22121",
            "principal": "1.22121",
            "repaidSize": "0",
            "repayTime": "1544657947759",
            "term": 7
     * */
    public class KucoinRepaidRecord
    {
        [JsonProperty("tradeId")]
        public string? TradeId { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("dailyIntRate")]
        public decimal? DailyIntRate { get; set; }

        [JsonProperty("interest")]
        public decimal? Interest { get; set; }

        [JsonProperty("principal")]
        public decimal? Principal { get; set; }

        [JsonProperty("repaidSize")]
        public decimal? RepaidSize { get; set; }

        [JsonConverter(typeof(DateTimeConverter)), JsonProperty("repayTime")]
        public DateTime? RepayTime { get; set; }

        [JsonProperty("term")]
        public int? Term { get; set; }
    }
}
