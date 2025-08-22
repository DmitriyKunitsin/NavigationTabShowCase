using Avalonia.Controls;
using Avalonia.Interactivity;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Windows.Input;

namespace NavigationTabShowCase.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NavigationActionStripItem : ContentControl, IRibbonAction
    {
        // Реализация элемента action-стрипа
        /// <summary>
        /// Регистрация события клика
        /// </summary>
        public static readonly RoutedEvent<RoutedEventArgs> ClickEvent = RoutedEvent.Register<NavigationActionStripItem, RoutedEventArgs>(nameof(Click), RoutingStrategies.Bubble);

        public string Title => "Decription";

        public ICommand Command => throw new NotImplementedException();

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
