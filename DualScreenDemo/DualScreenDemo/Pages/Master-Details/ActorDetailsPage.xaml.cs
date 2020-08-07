using DualScreenDemo.Controls;
using DualScreenDemo.ViewModels;
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
    }
}