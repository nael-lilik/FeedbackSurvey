using CommunityToolkit.Mvvm.ComponentModel;

namespace Feedback_Survey.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        String text;
    }
}
