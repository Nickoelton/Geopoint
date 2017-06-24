using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DemoGeoPoint.Droid
{
    [Activity(Label = "DemoGeoPoint", Theme="@style/Theme.Splash", MainLauncher =true, NoHistory =true)]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Intent i = new Intent(this, typeof(MainActivity));
            StartActivity(i);

            // Create your application here
        }
    }
}