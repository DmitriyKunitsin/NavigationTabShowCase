using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationTabShowCase.Models
{
    /// <summary>
    /// Класс представляющий действия с выпадающим списком настроек, содержит в себе набор айтемов
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
        /// <summary>
        /// Набор айтемов, которые содержит в себе выпадающий список
        /// </summary>
        public ObservableCollection<NavigationActionStripItem> Actions { get; private set; } = new ObservableCollection<NavigationActionStripItem>();
    }
}
