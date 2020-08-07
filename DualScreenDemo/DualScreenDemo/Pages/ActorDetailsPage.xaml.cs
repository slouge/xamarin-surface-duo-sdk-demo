using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DualScreenDemo.Controls;
using DualScreenDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.DualScreen;
using Xamarin.Forms.Xaml;

namespace DualScreenDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActorDetailsPage : BasePage
    {
        public ActorDetailsPage(ActorViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnSpanModeChanged(TwoPaneViewMode mode)
        {
            base.OnSpanModeChanged(mode);

            if(IsSpanned)
            {
                SimpleIoc.Default.GetInstance<INavigationService>().GoBack();
            }
        }
    }
}