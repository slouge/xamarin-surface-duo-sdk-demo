using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.DualScreen;

namespace DualScreenDemo.ViewModels
{
    public class DualScreenViewModelBase : ViewModelBase
    {
        public bool IsSpanned => DualScreenInfo.Current.SpanMode != TwoPaneViewMode.SinglePane;

        public DualScreenViewModelBase()
        {
        }
    }
}
