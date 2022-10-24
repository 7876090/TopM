
using CommunityToolkit.Mvvm.ComponentModel;

namespace TopM.ViewModels
{
    public partial class ManageOrdersViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private int count1;

        [ObservableProperty]
        private int count10;

        public bool IsNotBusy => !IsBusy;

        public ManageOrdersViewModel()
        {            
        
        }

        

    }
}
