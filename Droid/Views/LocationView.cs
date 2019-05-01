using Android.App;
using Android.OS;
using Android.Runtime;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace XamEssentialsTest.Droid.Views
{
    [Activity(Label = "Xam Ess Test", MainLauncher = true)]
    public class LocationView : MvxActivity<LocationViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            SetContentView(Resource.Layout.Location);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
