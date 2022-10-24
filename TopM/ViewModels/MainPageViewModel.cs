
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TopM.Views;

namespace TopM.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {

        public MainPageViewModel()
        { }

        [RelayCommand]
        async Task GoToManageOrdersPage()
        {
            await Shell.Current.GoToAsync($"{nameof(ManageOrdersView)}");
        }
    }
}
