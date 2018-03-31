using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Fortnite_Stats.Classes
{
    class GameMode
    {

        [JsonProperty("kills")]
        public int kills { get; set; }
        [JsonProperty("matchesPlayed")]
        public int matchesPlayed { get; set; }
        [JsonProperty("lastMatch")]
        public String lastMatch { get; set; }
        [JsonProperty("minutesPlayed")]
        public int minutesPlayed { get; set; }
        [JsonProperty("wins")]
        public int wins { get; set; }
        [JsonProperty("top10")]
        public int top10 { get; set; }
        [JsonProperty("top25")]
        public int top25 { get; set; }

        //duo

        [JsonProperty("top5")]
        public int top5 { get; set; }
        [JsonProperty("top12")]
        public int top12 { get; set; }

        //squad

        [JsonProperty("top3")]
        public int top3 { get; set; }
        [JsonProperty("top6")]
        public int top6 { get; set; }

        [JsonProperty("deaths")]
        public int deaths { get; set; }
        [JsonProperty("kpd")]
        public double kpd { get; set; }
        [JsonProperty("kpm")]
        public double kpm { get; set; }
        [JsonProperty("tpm")]
        public double tpm { get; set; }
        [JsonProperty("score")]
        public int score { get; set; }
        [JsonProperty("winRate")]
        public double winRate { get; set; }

    }
}