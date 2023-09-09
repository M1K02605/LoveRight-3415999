using LoveRight.Pages;

namespace LoveRight
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ViewMemoryButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewMemoryPage());
        }
    }
}