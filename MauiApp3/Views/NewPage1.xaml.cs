using System.Collections.ObjectModel;

namespace TestApp.Views;

public partial class NewPage1 : ContentPage
{
    public NewPage1(ObservableCollection<TestViewModel> items)
	{
		InitializeComponent();

        listView.ItemsSource = items;
    }
}