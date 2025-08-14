using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationTabShowCase.Models
{
    /// <summary>
    /// Представляет элемент управления, который представляет отдельные действия.
    /// </summary>
    public class NavigationActionStrip : ItemsControl
    {
        /// <summary>
        /// Свойство, указывающее, развернута ли панель навигации.
        /// </summary>
        public static readonly StyledProperty<bool> IsExpandedProperty = AvaloniaProperty.Register<NavigationActionStrip, bool>(nameof(IsExpanded), false);
        /// <summary>
        /// Получает или устанавливает значение, указывающее, развернута ли панель навигации.
        /// </summary>
        public bool IsExpanded 
        { 
            get => GetValue(IsExpandedProperty);
            set 
            {
                SetValue(IsExpandedProperty, value);
            }
        }
    }
}
