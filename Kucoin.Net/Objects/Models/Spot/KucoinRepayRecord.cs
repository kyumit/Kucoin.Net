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
            "accruedInterest": "0.22121",
            "dailyIntRate": "0.0021",
            "liability": "1.32121",
            "maturityTime": "1544657947759",
            "principal": "1.22121",
            "repaidSize": "0",
            "term": 7,
            "createdAt": "1544657947759"
     * */
    public class KucoinRepayRecord
    {
        [JsonProperty("tradeId")]
        public string? TradeId { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("accruedInterest")]
        public decimal? AccruedInterest { get; set; }

        [JsonProperty("dailyIntRate")]
        public decimal? DailyIntRate { get; set; }

        [JsonProperty("liability")]
        public decimal? Liability { get; set; }

        [JsonConverter(typeof(DateTimeConverter)), JsonProperty("maturityTime")]
        public DateTime? MaturityTime { get; set; }

        [JsonProperty("principal")]
        public decimal? Principal { get; set; }

        [JsonProperty("repaidSize")]
        public decimal? RepaidSize { get; set; }

        [JsonProperty("term")]
        public int? Term { get; set; }

        [JsonConverter(typeof(DateTimeConverter)), JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }
    }
}
