using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using SQLite;

namespace PackWarsCounterMobile
{
    public partial class GameChoices : ContentPage
    {
        private String game1 = "Hearthstone";
        private String game2 = "Magic The Gathering";
        
        public GameChoices()
        {
            InitializeComponent();

            Label Header = new Label
            {
                Text = "Choose a Game:",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            Button HS = new Button
            {
                Text = game1,
                VerticalOptions = LayoutOptions.Start,
                
                IsEnabled = true
            };
            HS.Clicked += GameChoice;

            Button MTG = new Button
            {
                Text = game2,
                VerticalOptions = LayoutOptions.Start,
                
                IsEnabled = true
            };
            MTG.Clicked += GameChoice;

            Button Custom = new Button
            {
                Text = "Add Custom",
                VerticalOptions = LayoutOptions.Start,
                
                IsEnabled = true
            };
            Custom.Clicked += CustomChoice;

            this.Content = new StackLayout
            {
                Children =
                {
                    Header,
                    HS,
                    MTG,
                    Custom
                }

            };
        }

        void GameChoice(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CounterPage());
        }

        void CustomChoice(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new CounterPage());
        }
    }
}
