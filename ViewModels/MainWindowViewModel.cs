using NavigationTabShowCase.Models;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<NavigationTabStripItem> Tabs { get; }
        public ObservableCollection<NavigationActionStrip> TabsMenu { get; }
        public ObservableCollection<NavigationActionStrip> TabsActionStrip { get; }

        public MainWindowViewModel()
        {

        }
    }
}
