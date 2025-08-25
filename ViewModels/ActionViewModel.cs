using CommunityToolkit.Mvvm.Input;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System.Windows.Input;

namespace NavigationTabShowCase.ViewModels
{
    public class ActionViewModel : ViewModelBase, IRibbonAction
    {
        public ActionViewModel()
        {
        }
        public string Title { get; set; } = "Description";

        public ICommand Command { get; } = new RelayCommand(() => { });

        public object? Icon => null;
    }
}
