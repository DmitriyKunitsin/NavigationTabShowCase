﻿using NavigationTabShowCase.Models;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ActionViewModel> Tabs { get; }

        public MainWindowViewModel()
        {
            Tabs = new ObservableCollection<ActionViewModel>() 
            { 
                new ActionViewModel() {Title = "TTTTT"},
                new ActionViewModel() {Title = "FFFFF"},
                new ActionViewModel() {Title = "SSSSS"},
            } ;
        }
    }
}
