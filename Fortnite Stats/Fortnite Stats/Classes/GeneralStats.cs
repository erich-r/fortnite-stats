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
    class GeneralStats
    {

        [JsonProperty("kills")]

        public int kills { set; get; }

        [JsonProperty("matchesPlayed")]

        public int matchesPlayed { set; get; }

        [JsonProperty("minutesPlayed")]

        public int minutesPlayed { set; get; }

        [JsonProperty("wins")]

        public int wins { set; get; }

        [JsonProperty("score")]

        public int score { set; get; }

        [JsonProperty("kpm")]

        public double kpm { set; get; }

        [JsonProperty("tpm")]

        public double tpm { set; get; }

        [JsonProperty("deaths")]

        public int deaths { set; get; }

        [JsonProperty("kpd")]

        public double kpd { set; get; }

        [JsonProperty("lastMatch")]

        public String lastMatch { set; get; }

        [JsonProperty("spm")]

        public double spm { set; get; }

        [JsonProperty("winRate")]

        public double winRate { set; get; }

    }
}