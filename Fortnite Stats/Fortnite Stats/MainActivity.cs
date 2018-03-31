using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Fortnite_Stats.Classes;

namespace Fortnite_Stats
{
    [Activity(Label = "Fortnite_Stats", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //font nei controlli

            Typeface font = Typeface.CreateFromAsset(Assets, "Burbank.ttf");

            //applico il font ai controller (Bottone e TextView

            Button btnStart = FindViewById<Button>(Resource.Id.btnStart);
            EditText txt = FindViewById<EditText>(Resource.Id.txtUsername);
            txt.SetTypeface(font, TypefaceStyle.Bold);
            btnStart.SetTypeface(font, TypefaceStyle.Bold);

            //associo il metodo all'evento click del btnStart

            btnStart.Click += delegate
            {
                btnStartClick();
            };

            //radius del bottone TODO            

            //LinearLayout linear = FindViewById<LinearLayout>(Resource.Id.background);
            //linear.SetBackgroundDrawable(Resource.Drawable.bocchi);
            //linear.SetBackgroundColor(Android.Graphics.Color.Blue);
        }

        public void btnStartClick()
        {
            //Toast.MakeText(this, text: "Ciao", duration: ToastLength.Long).Show();

            String nome = FindViewById<EditText>(Resource.Id.txtUsername).Text;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://geekcodeit.altervista.org/apifort.php?nome="+nome);
            //timeout di 5s
            request.Timeout = 1;

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch(WebException timeout)
            {
                //TODO
                Toast.MakeText(context: this, text: timeout.Message, duration: ToastLength.Long).Show();
                return;
            }

            //funziona
            //Toast.MakeText(context: this, text: "Ho scaricato i dati", duration: ToastLength.Long).Show();

            StreamReader stream = new StreamReader(response.GetResponseStream());

            String api = stream.ReadLine();

            StatisticsJson data = JsonConvert.DeserializeObject<StatisticsJson>(api);


        }
    }
}
