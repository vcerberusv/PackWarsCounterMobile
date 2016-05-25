using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PackWarsCounterMobile
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        void ToChooseGame(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameChoices());
        }
    }
}
