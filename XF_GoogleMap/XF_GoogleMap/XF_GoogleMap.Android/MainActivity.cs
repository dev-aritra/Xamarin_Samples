using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.GoogleMaps.Android;

namespace XF_GoogleMap.Droid
{
    [Activity(Label = "XF_GoogleMap", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            var platformConfig = new PlatformConfig
            {
                BitmapDescriptorFactory = new AccessNativeBitmapConfig()
            };

            Xamarin.FormsGoogleMaps.Init(this, savedInstanceState, platformConfig);
            LoadApplication(new App());

            
        }
    }
}