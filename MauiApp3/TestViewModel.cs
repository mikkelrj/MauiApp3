using System.Collections.ObjectModel;

namespace MauiApp3
{
    public class TestViewModel
    {
        public ObservableCollection<Element> Elements { get; set; }
            = [new("1"), new("2"), new("3")];
    }

    public class Element(string name)
    {
        public string Name { get; } = name;
    }
}
