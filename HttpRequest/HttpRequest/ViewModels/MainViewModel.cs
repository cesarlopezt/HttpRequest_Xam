using HttpRequest.Models;
using HttpRequest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HttpRequest.ViewModels
{
    class MainViewModel: BaseViewModel
    {
        public Command RequestDogCommand { get; }
        public Dog RandomDog { get; set; }
        private ITheDogsApi _theDogsApi;

        async void OnRequestDog()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                var dogs = await _theDogsApi.GetRandomDog();
                RandomDog = dogs[0];
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No Internet Connection.", "Ok");
            }
        }

        public MainViewModel(ITheDogsApi theDogsApi)
        {
            _theDogsApi = theDogsApi;
            RequestDogCommand = new Command(OnRequestDog);

        }
    }
}
