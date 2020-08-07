using DualScreenDemo.Contants;
using DualScreenDemo.Enums;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;

namespace DualScreenDemo.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private RelayCommand<Samples> _showSampleCommand;


        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
        }

        public RelayCommand<Samples> ShowSampleCommand
        {
            get
            {
                return _showSampleCommand ?? (_showSampleCommand = new RelayCommand<Samples>(ShowSample));
            }
        }

        private void ShowSample(Samples mode)
        {
            switch(mode)
            {
                case Samples.MasterDetails:
                    _navigationService.NavigateTo(PageKeys.ActorsPage);
                    break;
            }
        }
    }
}
