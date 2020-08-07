using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using DualScreenDemo.Contants;
using DualScreenDemo.Pages;
using DualScreenDemo.Services;
using DualScreenDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DualScreenDemo
{
    public partial class App : Application
    {
        private static ViewModelLocator _vmLocator;
       
        public App()
        {
            InitializeComponent();

            var navigation = new NavigationService();
            navigation.RegisterPage(PageKeys.MainPage, typeof(MainPage));
            navigation.RegisterPage(PageKeys.ActorsPage, typeof(ActorListPage));
            navigation.RegisterPage(PageKeys.DetailsPage, typeof(ActorDetailsPage));

            SimpleIoc.Default.Register<INavigationService>(() => navigation);

            var firstPage = new NavigationPage(new MainPage());

            navigation.Initialize(firstPage);

            MainPage = firstPage;
        }

        public static ViewModelLocator ViewModelLocator { get { return _vmLocator ?? (_vmLocator = new ViewModelLocator()); } }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
