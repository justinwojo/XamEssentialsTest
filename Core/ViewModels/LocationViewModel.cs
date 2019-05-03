using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Core.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
    public class LocationViewModel : MvxViewModel
    {
        private readonly LocationService locationService;
        private readonly IMvxNavigationService _navigationService;

        public LocationViewModel(IMvxNavigationService navService)
        {
            locationService = new LocationService();
            _navigationService = navService;
        }

        public string LocationButtonText => "Get Location";
        public string NavButtonText => "Nav To ViewModel Type";
        public string NavButtonLinkText => "Nav With Uri";

        private string _locationText;
        public string LocationText 
        {
            get
            {
                return _locationText;
            }
            set
            {
                _locationText = value;
                RaisePropertyChanged(() => LocationText);
            }
        }

        public IMvxAsyncCommand LocationClick => new MvxAsyncCommand(async () => await GetLocation());
        public IMvxAsyncCommand NavLinkClick => new MvxAsyncCommand(async () => await _navigationService.Navigate("mvvmcross-test://deeplink/?testid=123"));
        public IMvxAsyncCommand NavClick => new MvxAsyncCommand(async () => await _navigationService.Navigate<DeepLinkViewModel>());

        private async Task GetLocation()
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            var location = await locationService.GetLocationAsync();
            timer.Stop();
            if(location != null)
            {
                LocationText = string.Format("Lat: {0}{1}Lon: {2}{1}Time: {3}", location.Latitude.ToString(), Environment.NewLine, location.Longitude.ToString(), timer.Elapsed.Seconds);
            }
        }
    }
}
