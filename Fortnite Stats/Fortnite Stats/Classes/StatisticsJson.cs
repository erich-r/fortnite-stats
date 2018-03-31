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
    class StatisticsJson
    {

        [JsonProperty("nome")]
        String nome { get; set; }

        [JsonProperty("pc")]
        public Platform pc { get; set; }

        [JsonProperty("ps4")]
        public Platform ps4 { get; set; }

        [JsonProperty("x1")]
        public Platform x1 { get; set; }



    }
}
