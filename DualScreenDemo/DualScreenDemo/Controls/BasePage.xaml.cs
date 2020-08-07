using DualScreenDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.DualScreen;
using Xamarin.Forms.Xaml;

namespace DualScreenDemo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage
    {
        protected bool IsSpanned => DualScreenInfo.Current.SpanMode != TwoPaneViewMode.SinglePane;

        public BasePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DualScreenInfo.Current.PropertyChanged += OnFormsWindowPropertyChanged;

            if (BindingContext is DualScreenViewModelBase vm)
            {
                vm.ViewMode = DualScreenInfo.Current.SpanMode;
                vm.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DualScreenInfo.Current.PropertyChanged -= OnFormsWindowPropertyChanged;

            if (BindingContext is DualScreenViewModelBase vm)
            {
                vm.OnDisappearing();
            }
        }

        private void OnFormsWindowPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(DualScreenInfo.Current.SpanMode) || e.PropertyName == nameof(DualScreenInfo.Current.IsLandscape))
            {
                if (BindingContext is DualScreenViewModelBase vm)
                {
                    vm.ViewMode = DualScreenInfo.Current.SpanMode;
                }
            }
        }
    }
}