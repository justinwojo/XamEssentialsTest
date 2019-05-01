using System;
using System.Threading.Tasks;
using Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
    public class LocationViewModel : MvxViewModel
    {
        private readonly LocationService locationService;

        public LocationViewModel()
        {
            locationService = new LocationService();
        }

        public string LocationButtonText => "Get Location";

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

        private async Task GetLocation()
        {
            var location = await locationService.GetLocationAsync();
            if(location != null)
            {
                LocationText = string.Format("Lat: {0} {1}Lon: {2}", location.Latitude.ToString(), Environment.NewLine, location.Longitude.ToString());
            }
        }
    }
}
