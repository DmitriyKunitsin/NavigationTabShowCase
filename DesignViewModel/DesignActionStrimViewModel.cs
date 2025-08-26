using NavigationTabShowCase.ViewModels;
using System.Collections.Generic;

namespace NavigationTabShowCase.DesignViewModel
{
    public class DesignActionStrimViewModel : ViewModelBase
    {
        public List<string> Actions { get;  } = new List<string>() { "Главная", "Файл", "Меню" };
    }
}
