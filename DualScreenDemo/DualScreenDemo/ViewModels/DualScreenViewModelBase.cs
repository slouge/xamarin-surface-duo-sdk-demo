using GalaSoft.MvvmLight;
using Xamarin.Forms.DualScreen;

namespace DualScreenDemo.ViewModels
{
    public class DualScreenViewModelBase : ViewModelBase
    {
        private TwoPaneViewMode _viewMode;
        private bool _isSpanned;

        public DualScreenViewModelBase()
        {
        }

        public TwoPaneViewMode ViewMode
        {
            get
            {
                return _viewMode;
            }
            set
            {
                if(Set(ref _viewMode, value))
                {
                    IsSpanned = value != TwoPaneViewMode.SinglePane;
                }
            }
        }

        public bool IsSpanned
        {
            get
            {
                return _isSpanned;
            }

            set
            {
                if(Set(ref _isSpanned, value))
                {
                    OnSpanModeChanged();
                }
            }
        }

        internal virtual void OnAppearing()
        {
        }

        internal virtual void OnDisappearing()
        {
        }

        internal virtual void OnSpanModeChanged()
        {            
        }
    }
}
