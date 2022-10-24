
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TopM.Pages;

namespace TopM.Models
{
    public partial class MainPageModel : ObservableObject
    {

        public MainPageModel()
        { }

        [RelayCommand]
        async Task GoToManageOrdersPage()
        {
            await Shell.Current.GoToAsync($"{nameof(ManageOrdersPage)}");
        }
    }
}
