namespace KSMArtMauiApp
{
    using KSMArtMauiApp.Services;
    using Microsoft.Maui.Controls.Xaml;
    using Microsoft.Maui.Hosting;
    using CommunityToolkit.Maui;
    using KSMWebApi.Models;

    public partial class MainPage : ContentPage
    {
        int count = 0;
        ArtObjectRestService srv = new ArtObjectRestService();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            var result = await srv.GetDataAsync();

            //ArtObject Test = new ArtObject()
            //{
            //    Id = 0,
            //    FileName = "testme",
            //    FileType = "jpg",
            //    LastViewed = DateTime.Now,
            //    Location = "CHICAGO",
            //    Price = 50,
            //    Title = "testTitle",
            //    UserName = "BBB",
            //    Views = 20

            //};


            //var Test = await srv.DeleteArtObjectAsync(14);

            //var me = Test;

            //ArtObject updt = await srv.UpdateArtObjectAsync(result);

            if (result != null)
            {
                this.ArtObjectList.ItemsSource = result;
            }
            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
