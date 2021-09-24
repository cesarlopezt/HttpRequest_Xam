using HttpRequest.Models;
using HttpRequest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HttpRequest.ViewModels
{
    class MainViewModel: BaseViewModel
    {
        public Command RequestDogCommand { get; }
        public Dog RandomDog { get; set; }

        async void OnRequestDog()
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                var ApiService = new TheDogsApiService();
                var Dogs = await ApiService.GetDogsAsync();
                RandomDog = Dogs[0];
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Alert", "No Internet Connection.", "Ok");
            }
        }

        public MainViewModel()
        {
            RequestDogCommand = new Command(OnRequestDog);

        }
    }
}
