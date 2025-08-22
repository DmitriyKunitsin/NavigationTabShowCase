using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace NavigationTabShowCase.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NavigationActionStripItem : ContentControl
    {
        // Реализация элемента action-стрипа
        /// <summary>
        /// Регистрация события клика
        /// </summary>
        public static readonly RoutedEvent<RoutedEventArgs> ClickEvent = RoutedEvent.Register<NavigationActionStripItem, RoutedEventArgs>(nameof(Click), RoutingStrategies.Bubble);
        /// <summary>
        /// Обертка для доступа к событию
        /// </summary>
        public event EventHandler<RoutedEventArgs> Click
        {
            add => AddHandler(ClickEvent, value);
            remove => RemoveHandler(ClickEvent, value);
        }
        /// <summary>
        /// Метод для вызова события (можно вызвать при нажатии)
        /// </summary>
        protected virtual void OnClick()
        {
            var args =  new RoutedEventArgs(ClickEvent);
            RaiseEvent(args);
        }
    }
}
