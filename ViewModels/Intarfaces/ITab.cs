using IconPacks.Avalonia.Unicons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationTabShowCase.ViewModels.Intarfaces
{
    public interface ITab
    {
        public string Title { get; }
        public IReadOnlyList<IRibbonAction> Actions { get; set; }
    }
}
