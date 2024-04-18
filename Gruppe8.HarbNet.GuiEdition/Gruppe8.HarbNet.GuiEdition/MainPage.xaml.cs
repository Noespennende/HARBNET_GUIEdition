
using Gruppe8.HarbNet.GuiEdition.ViewModel;

namespace Gruppe8.HarbNet.GuiEdition
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Harbor harbor;

        public MainPage(ConsoleViewModel cvm)
        {
            InitializeComponent();
            BindingContext = cvm;
        
        }

        private void OnSimulationClicked(object sender, EventArgs e)
        {
            try
            {
                Guid numberOfSmallLoadingDocks = harbor.ID;
                Simulation sim = new(harbor, new DateTime(2024, 4, 4), new DateTime(2024, 4, 20));
                SimulationClick.Text = $"Du kjører nå simuleringen i 16 dager {numberOfSmallLoadingDocks}";

                SemanticScreenReader.Announce(SimulationClick.Text);
                
            }
            catch (Exception ex)
            {
                //
                //
            }
            
        }
        private async void OnNextPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HarborCreatePage());
        }

    }
}
