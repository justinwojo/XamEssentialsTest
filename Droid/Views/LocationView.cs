using Android.App;
using Android.OS;
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
    }
}
