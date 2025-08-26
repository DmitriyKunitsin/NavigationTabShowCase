using NavigationTabShowCase.ViewModels;
using System.Collections.ObjectModel;

namespace NavigationTabShowCase.DesignViewModel
{
    public static class DesignActionStrimViewModel
    {
        public static ObservableCollection<string> Actions { get; } = new ObservableCollection<string>() { "Главная", "Файл", "Меню" };
        public static ObservableCollection<ActionViewModel> ActionsViewModels { get; } = new ObservableCollection<ActionViewModel>()
        {
            new ActionViewModel() {Title = "Главная"},
            new ActionViewModel() {Title = "Файл"},
            new ActionViewModel() {Title = "Данные"},
        };
    }
}
