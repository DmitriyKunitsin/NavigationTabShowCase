using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.LogicalTree;
using Avalonia.VisualTree;
using MsBox.Avalonia;

namespace NavigationTabShowCase.Controls
{
    [TemplatePart(TpTextBlock, typeof(TextBlock))]
    [PseudoClasses(PcSelected)]
    public class NavigationActionStripItem : Button
    {
        public NavigationActionStripItem() { }
        private TextBlock? _textBlock;
        public const string TpTextBlock = "PART_TextBlock";
        public const string PcSelected = ":selectedBtn";

        public static readonly StyledProperty<string> TitleProperty =
            AvaloniaProperty.Register<NavigationActionStripItem, string>(
                name: nameof(Title),
                defaultValue: string.Empty);

        public static readonly StyledProperty<bool> IsSelectedProperty =
            AvaloniaProperty.Register<NavigationActionStripItem, bool>(
                name: nameof(IsSelected),
                defaultValue: false);
        //public static readonly StyledProperty<bool> IsParentExpandedProperty =
        //    AvaloniaProperty.Register<NavigationActionStripItem, bool>(nameof(IsParentExpanded));
        //public bool IsParentExpanded
        //{
        //    get => GetValue(IsParentExpandedProperty);
        //    set => SetValue(IsParentExpandedProperty, value);
        //}
        //protected override void OnAttachedToLogicalTree(LogicalTreeAttachmentEventArgs e)
        //{
        //    base.OnAttachedToLogicalTree(e);
        //    var rt = this.GetVisualParent();
        //    var parent = this.GetVisualParent() as NavigationActionStrip;
        //    if (parent != null)
        //    {
        //        //parent.GetObservable(NavigationActionStrip.IsExpandedProperty).Subscribe(expanded => IsParentExpanded = expanded);
        //    }
        //}
        public string Title
        {
            get => GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            _textBlock = e.NameScope.Find<TextBlock>(TpTextBlock);
            SetPseudoClasses();
        }
        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);
            if (change.Property == IsSelectedProperty)
            {
                SetPseudoClasses();
            }
        }
        private void SetPseudoClasses()
        {
            PseudoClasses.Set(PcSelected, IsSelected);
        }

        public bool IsSelected
        {
            get => GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }
        protected override void OnPointerEntered(PointerEventArgs e)
        {
            base.OnPointerEntered(e);
            if (!IsSelected)
            {
                IsSelected = true;
            }
        }
        protected override void OnPointerExited(PointerEventArgs e)
        {
            base.OnPointerExited(e);
            if (IsSelected)
            {
                IsSelected = false;
            }
        }
        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            base.OnPointerPressed(e);
            if (e.Source is TextBlock b)
            {
                var box = MessageBoxManager.GetMessageBoxStandard($"MsBox", $"{b.Text}", @enum: MsBox.Avalonia.Enums.ButtonEnum.Ok);
                var res = box.ShowAsync(); // Да да я знаю, что тут надо await
            }
        }
    }
}
