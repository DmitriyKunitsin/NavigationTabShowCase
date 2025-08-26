using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Windows.Input;

namespace NavigationTabShowCase.Controls
{
    [TemplatePart(TpTextBlock, typeof(TextBlock))]
    public class NavigationActionStripItem : Button
    {
        public NavigationActionStripItem() { }
        private TextBlock? _textBlock;

        public const string TpTextBlock = "PART_TextBlock";

        public static readonly StyledProperty<string> TitleProperty = 
            AvaloniaProperty.Register<NavigationActionStripItem, string>(
                name: nameof(Title), 
                defaultValue: string.Empty);
        public string Title 
        { 
            get => GetValue( TitleProperty ); 
            set => SetValue(TitleProperty, value); 
        }
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            _textBlock = e.NameScope.Find<TextBlock>(TpTextBlock);
        }
    }
}
