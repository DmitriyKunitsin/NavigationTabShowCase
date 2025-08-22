﻿using NavigationTabShowCase.Models;
using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public class TestItemClass
        {
            public string? Name { get; set; }
            public string? Description { get; set; }
            public int Id { get; set; }
        }
        public ObservableCollection<NavigationTabStripItem> Tabs { get; }
        = new ObservableCollection<NavigationTabStripItem>() 
        { 
            new NavigationTabStripItem { Content = "Главная"},
            new NavigationTabStripItem { Content = "Меню"},
            new NavigationTabStripItem { Content = "Данные"}
        };
        public ObservableCollection<NavigationTabStripItem> TabsMenu { get; }
        = new ObservableCollection<NavigationTabStripItem>() 
        { 
            new NavigationTabStripItem { Content = "Главная"},
            new NavigationTabStripItem { Content = "Меню"},
            new NavigationTabStripItem { Content = "Данные"}
        };
        public MainWindowViewModel()
        {
        }
    }
}
