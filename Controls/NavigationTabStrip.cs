using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.ObjectModel;

namespace NavigationTabShowCase.Controls
{

    /// <summary>
    /// Представляет элемент управления, который представляет собой вкладку.
    /// </summary>
    public class NavigationTabStrip : SelectingItemsControl
    {
        // Специфичные свойства \ методы для таб-контрола
        public static readonly StyledProperty<string> NameTabProperty = AvaloniaProperty.Register<NavigationActionStripItem, string>(nameof(NameTab));
        /// <summary>
        /// 
        /// </summary>
        public string NameTab
        {
            get => GetValue(NameTabProperty);
            set => SetValue(NameTabProperty, value);
        }
    }
}
