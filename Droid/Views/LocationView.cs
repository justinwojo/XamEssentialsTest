using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using XamEssentialsTest.Core.ViewModels;

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
