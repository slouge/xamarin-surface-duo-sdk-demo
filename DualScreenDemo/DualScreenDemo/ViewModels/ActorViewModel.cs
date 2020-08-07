using GalaSoft.MvvmLight;
using System;

namespace DualScreenDemo.ViewModels
{
    public class ActorViewModel : DualScreenViewModelBase
    {
        public ActorViewModel() { }

        public string Name { get; set; }
        public string Roles { get; set; }
        public Uri Picture { get; set; }
        public Uri Link { get; set; }
        public string Nationality { get; set; }
        public DateTime BirthDate { get; set; }
        public string AgeString
        {
            get
            {
                // Juste pour l'exemple...
                return $"{BirthDate:d} - {DateTime.Now.Year - BirthDate.Year} ans";
            }
        }
        public string BirthLocation { get; set; }
    }
}
