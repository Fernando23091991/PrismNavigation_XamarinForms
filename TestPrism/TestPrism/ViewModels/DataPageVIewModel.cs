using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Forms;
using Prism.Events;

namespace TestPrism.ViewModels
{
    public class DataPageViewModel : BaseViewModel
    {

        public DataPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService, eventAggregator)
        {
            _navigationService = navigationService;
            Title = "Data Page";
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }



    }
}
