using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DualScreenDemo.ViewModels
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Register all the used ViewModels, Services et. al. witht the IoC Container
        /// </summary>
        public ViewModelLocator()
        {
            // ViewModels
            SimpleIoc.Default.Register<ActorManagerViewModel>();
        }

        public ActorManagerViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ActorManagerViewModel>();
            }
        }
    }
}
