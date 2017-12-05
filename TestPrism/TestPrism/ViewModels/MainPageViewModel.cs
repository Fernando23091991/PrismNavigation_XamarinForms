using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Prism.Events;

namespace TestPrism.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
       
        public MainPageViewModel(INavigationService navigationService,IEventAggregator eventAggregator) : base(navigationService,eventAggregator)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}

