using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ActionViewModel> Tabs { get; } = new ObservableCollection<ActionViewModel>()
            {
                new ActionViewModel() {Description = "Главная"},
                new ActionViewModel() {Description = "Файл"},
                new ActionViewModel() {Description = "Данные"},
            };
        public static ObservableCollection<string> Actions { get; } = new ObservableCollection<string>() { "Главная", "Файл", "Меню" };
        public MainWindowViewModel()
        {
        }
    }
}
