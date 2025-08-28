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
        public string Description { get; set; } = "Description";

        public ICommand ActionCommand { get; } = new RelayCommand(() => { });

        public object? Icon => null;
    }
}
