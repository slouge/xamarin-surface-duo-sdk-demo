using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DualScreenDemo.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ActorManagerViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        public ActorManagerViewModel ActorManagerViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ActorManagerViewModel>();
            }
        }
    }
}
