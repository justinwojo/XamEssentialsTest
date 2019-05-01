using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Core.Services
{
    public class LocationService
    {
        public async Task<Location> GetLocationAsync()
        {
            try
            {
                //This request with a timespan works, but only returns location after exactly 5 seconds
                //var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(5));

                //This request does not work, infinitely hangs
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);

                var location = await Geolocation.GetLocationAsync(request);
                if(location != null)
                {
                    return location;
                }
            }
            catch (FeatureNotSupportedException)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException)
            {
                // Handle permission exception
            }
            catch (Exception)
            {
                // Unable to get location
            }

            return null;
        }
    }
}
