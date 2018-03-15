using System;

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.Widget;

namespace App3.Droid
{
    using Android.Views;

    [Activity(Label = "App3", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            //without the next line "OnOptionsItemSelected" will not be called
            //this.SetSupportActionBar(this.FindViewById<Toolbar>(Resource.Id.toolbar));
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            //I would like to handle onoptionsitemselected back pressed here :(
            return base.OnOptionsItemSelected(item);
        }
    }
}

