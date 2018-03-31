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
    class Platform
    {

        [JsonProperty("solo")]
        public GameMode solo { set; get; }

        [JsonProperty("duo")]
        public GameMode duo { set; get; }

        [JsonProperty("squad")]
        public GameMode squad { set; get; }

        [JsonProperty("all")]
        public GeneralStats all { set; get; }

    }
}