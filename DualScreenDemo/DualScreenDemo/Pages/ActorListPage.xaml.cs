using DualScreenDemo.Controls;
using DualScreenDemo.ViewModels;

namespace DualScreenDemo.Pages
{
    public partial class ActorListPage : BasePage
    {
        ActorManagerViewModel _viewModel;

        public ActorListPage(ActorManagerViewModel viewModel)
        {
            BindingContext = _viewModel = viewModel;
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (_viewModel != null)
                _viewModel.SelectedItem = null;
        }
    }
}
