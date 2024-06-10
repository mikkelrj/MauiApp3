using System.Collections.ObjectModel;
using System.Diagnostics;

namespace TestApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CountEntry.Text = "50";
        }

        private async void OnOpenListClicked(object sender, EventArgs e)
        {
            var count = int.Parse(CountEntry.Text);

            var items = new ObservableCollection<TestViewModel>(
                Enumerable.Range(0, count).Select(_ => new TestViewModel()));

            var watch = new Stopwatch();
            watch.Start();
            await Navigation.PushAsync(new NewPage1(items));
            watch.Stop();

            Debug.WriteLine("Duration: {0}", watch.ElapsedMilliseconds);
            DurationLabel.Text = $"Duration: {watch.ElapsedMilliseconds} milliseconds";
        }
    }
}
