﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationTabShowCase.ViewModels.Intarfaces
{
    public interface IRibbonAction
    {
        public string Title { get; }
        public ICommand Command { get; }
    }
}
