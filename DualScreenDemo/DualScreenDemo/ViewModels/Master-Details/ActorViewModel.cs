using GalaSoft.MvvmLight.Views;
using System;

namespace DualScreenDemo.ViewModels
{
    public class ActorViewModel : DualScreenViewModelBase
    {
        private INavigationService _navigationService;

        public ActorViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException("navigationService");
        }

        public string Name { get; set; }
        public string Roles { get; set; }
        public Uri Picture { get; set; }
        public Uri Link { get; set; }
        public string Nationality { get; set; }
        public string BirthLocation { get; set; }
        public DateTime BirthDate { get; set; }
        public string AgeString
        {
            get
            {
                // Juste pour l'exemple...
                return $"{BirthDate:d} - {DateTime.Now.Year - BirthDate.Year} ans";
            }
        }

        internal override void OnSpanModeChanged()
        {
            base.OnSpanModeChanged();

            if (IsSpanned)
            {
                _navigationService.GoBack();
            }
        }
    }
}
