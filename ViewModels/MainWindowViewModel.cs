using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ActionViewModel> Tabs { get; } = new ObservableCollection<ActionViewModel>()
            {
                new ActionViewModel() {Title = "Главная"},
                new ActionViewModel() {Title = "Файл"},
                new ActionViewModel() {Title = "Данные"},
            };

        public MainWindowViewModel()
        {
        }
    }
}
