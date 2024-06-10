using CommunityToolkit.Mvvm.ComponentModel;

namespace TestApp.Views;

public partial class TestViewModel : ObservableObject
{
    public TestViewModel()
    {
        Value1 = Guid.NewGuid().ToString().Substring(0, 6);
        Value2 = Guid.NewGuid().ToString().Substring(0, 6);
        Value3 = Guid.NewGuid().ToString().Substring(0, 6);
        Value4 = Guid.NewGuid().ToString().Substring(0, 6);
        Value5 = Guid.NewGuid().ToString().Substring(0, 6);
        Value6 = Guid.NewGuid().ToString().Substring(0, 6);
    }

    public string Value1 { get; set; }
    public string Value2 { get; set; }
    public string Value3 { get; set; }
    public string Value4 { get; set; }
    public string Value5 { get; set; }
    public string Value6 { get; set; }
}
