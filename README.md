# NavigationTabShowCase Architecture

## Иерархия классов

Control (Avalonia)
├── ItemsControl (Avalonia)
│   ├── NavigationActionStrip (custom control)
│   └── SelectingItemsControl (Avalonia)
│       └── NavigationTabStrip (custom control)
│
└── ContentControl (Avalonia)
    ├── NavigationActionStripItem (custom element)
    └── NavigationTabStripItem (custom element)




## Структура и использование

### NavigationTabStrip

**Наследуется от:** `SelectingItemsControl`

**Назначение:** Переключение между вкладками (аналогично `TabControl`)

**Содержит:** Коллекцию элементов `NavigationTabStripItem`

**Пример использования:**
```xml
<local:NavigationTabStrip>
    <local:NavigationTabStripItem Content="Вкладка 1"/>
    <local:NavigationTabStripItem Content="Вкладка 2"/>
</local:NavigationTabStrip>
```

### NavigationActionStrip

Наследуется от: `ItemsControl`

Назначение: Выпадающее меню действий (аналогично `ContextMenu`)

Содержит: Коллекцию элементов `NavigationActionStripItem`

Пример использования:
```xml
<local:NavigationActionStrip>
    <local:NavigationActionStripItem Content="Action 1"/>
    <local:NavigationActionStripItem Content="Action 2"/>
</local:NavigationActionStrip>
```

| Характеристика       | NavigationTabStrip            | NavigationActionStrip         |
|----------------------|-------------------------------|-------------------------------|
| Базовый класс        | `SelectingItemsControl`       | `ItemsControl`                |
| Назначение           | Переключение вкладок          | Выпадающие действия/меню      |
| Выбор элемента       | Поддерживается (IsSelected)   | Нет выбора (только клик)      |
| Тип элементов        | `NavigationTabStripItem`      | `NavigationActionStripItem`   |
| Поведение            | Один активный элемент         | Множественные независимые действия |
