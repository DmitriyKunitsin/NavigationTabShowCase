using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Interactivity;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Windows.Input;

namespace NavigationTabShowCase.Models
{
    /// <summary>
    
    /// </summary>
    public class NavigationActionStripItem : Button
    {
        public static readonly StyledProperty<string> TitleProperty = 
            AvaloniaProperty.Register<NavigationActionStripItem, string>(
                name: nameof(Title), 
                defaultValue: string.Empty);
        public string Title 
        { 
            get => GetValue( TitleProperty ); 
            set => SetValue(TitleProperty, value); 
        }
    }
}
