using System.Collections.ObjectModel;

namespace NavigationTabShowCase.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public class TestItemClass
        {
            public string? Name { get; set; }
            public string? Description { get; set; }
            public int Id { get; set; }
        }
        public string Greeting { get; } = "Welcome to Avalonia!";
        public ObservableCollection<TestItemClass> CollectionOneForTest { get; set; }
        public MainWindowViewModel()
        {
            CollectionOneForTest = new ObservableCollection<TestItemClass>() 
            { 
                new TestItemClass()
                {
                    Name = "Test_one",
                    Id = 1,
                    Description = "Description_one"
                },
                new TestItemClass()
                {
                    Name = "Test_two",
                    Id = 1,
                    Description = "Description_two"
                },
                new TestItemClass()
                {
                    Name = "Test_three",
                    Id = 1,
                    Description = "Description_three"
                }
            };
        }
    }
}
