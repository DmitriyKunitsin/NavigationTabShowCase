using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using NavigationTabShowCase.ViewModels.Intarfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationTabShowCase.Controls
{
    /// <summary>
    /// Класс представляющий действия с выпадающим списком настроек, содержит в себе набор айтемов
    /// Сделать псевдо класс Expanded
    /// </summary>
    [TemplatePart(TpExpandedButton, typeof(Button))]
    [PseudoClasses(PcExpanded)]
    public class NavigationActionStrip : ItemsControl
    {
        public NavigationActionStrip() { }
        public const string TpExpandedButton = "PART_ExpandButton";
        public const string PcExpanded = ":expanded";
        private Button? _button;
        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);
            if (change.Property == IsExpandedProperty)
            {
                PseudoClasses.Set(PcExpanded, IsExpanded);
            }
        }
        /// <summary>
        /// Авалониевский метод
        /// </summary>
        /// <param name="e"></param>
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            if (_button != null)
            {
                _button.Click -= OnPickButtonClick;
            }

            _button = e.NameScope.Find<Button>(TpExpandedButton);
            // Если нашёл кнопку с именем TpExpandedButton
            if (_button != null)
            {
                _button.Click += OnPickButtonClick;
            }
        }

        private void OnPickButtonClick(object? sender, RoutedEventArgs e)
        {
            IsExpanded = !IsExpanded;
        }

        /// <summary>
        /// Свойство, указывающее, развернута ли панель навигации.
        /// </summary>
        public static readonly StyledProperty<bool> IsExpandedProperty = 
            AvaloniaProperty.Register<NavigationActionStrip, bool>(
                name: nameof(IsExpanded), 
                defaultValue: false);
        /// <summary>
        /// Получает или устанавливает значение, указывающее, развернута ли панель навигации.
        /// </summary>
        public bool IsExpanded 
        { 
            get => GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
            
        }
        
    }
}
