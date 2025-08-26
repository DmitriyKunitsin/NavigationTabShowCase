using System.Collections.ObjectModel;

namespace NavigationTabShowCase.DesignViewModel
{
    public static class DesignActionStrimViewModel 
    {
        public static ObservableCollection<string> Actions { get;  } = new ObservableCollection<string>() { "Главная", "Файл", "Меню" };
    }
}
