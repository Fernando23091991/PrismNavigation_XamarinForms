using System;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestPrism.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        private string _title;

        protected INavigationService _navigationService;

        protected IEventAggregator _eventAggregator;

        public BaseViewModel(INavigationService navigationService,IEventAggregator eventAggregator)
        {
            this._navigationService = navigationService;
            this._eventAggregator = eventAggregator;
            GoToPage = new Command<string>(InvokeGoToPage);
            GoBack = new Command(InvokeGoBack);
        }

        public Command<string> GoToPage { get; }

        public Command GoBack { get; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public async void InvokeGoToPage(string name)
        {
            try
            {
                await _navigationService.NavigateAsync(name);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Error in method InvokeGoToDataPage: {0}", ex.Message));

            }
        }

        public void InvokeGoBack()
        {
            try
            {
                _navigationService.GoBackAsync();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Error in method InvokeGoBack: {0}",ex.Message));
            }
        }
    }   
}
