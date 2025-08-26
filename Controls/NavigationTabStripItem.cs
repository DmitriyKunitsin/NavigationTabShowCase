using Avalonia;
using Avalonia.Controls;

namespace NavigationTabShowCase.Controls
{
    /// <summary>
    /// Представляет логику представления, отедельной вкладкой.
    /// </summary>
    public class NavigationTabStripItem : ContentControl
    {
        // Реализация элемента таб-стрипа
        public static readonly StyledProperty<bool> IsSelectedProperty = AvaloniaProperty.Register<NavigationActionStripItem, bool>(nameof(IsSelected));
        /// <summary>
        /// 
        /// </summary>
        public bool IsSelected 
        { 
            get => GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }
    }
}
