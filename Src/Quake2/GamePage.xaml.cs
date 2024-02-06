using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Quake2.WindowsUWP
{
    public sealed partial class GamePage : Page
    {
        readonly Quake2Game _game;

        public GamePage()
        {
            this.InitializeComponent();

            // Create the game.
            var launchArguments = string.Empty;
            _game = MonoGame.Framework.XamlGame<Quake2Game>.Create(
                launchArguments, Window.Current.CoreWindow, swapChainPanel);
        }
    }
}
