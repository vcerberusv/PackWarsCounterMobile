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
            welcomeLabel.Text = "Welcome to the Pack Wars Counter!";
            chooseButton.Text = "Choose Your Game!!!";
            descriptionPW.Text = "Pack Wars is game to be played among friends where each player has a certain number of card packs of the same game and depending on the cards recieved, gets points depending on the rarity of the card.";
            descriptionPWC.Text = "With this counter, you choose the game you wish to play and and how many packs you are opening then it will give you a counter to add up your score of the cards you have opened.";
        }

        void ToChooseGame(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameChoices());
        }
    }
}
