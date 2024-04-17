
using Gruppe8.HarbNet.GuiEdition.ViewModel;

namespace Gruppe8.HarbNet.GuiEdition
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Harbor harbor;
        HarborCreateView viewModel;
        

        public MainPage()
        {
            InitializeComponent();
            viewModel = new HarborCreateView();
            BindingContext = viewModel;
        }

        private async void OnCreateHarborClicked(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("du klikket meg");
                Harbor createdHarbor = CreateHarborViewModel();

                if (createdHarbor != null)
                {

                    harborClick.Text = $"Du har laget en havn med ID: {harbor.ID}";
                    



                }

            }
            catch (Exception ex)
            {
                //
            }

        }

        private Harbor CreateHarborViewModel()
        {
            try
            {
                int numberOfSmallLoadingDocks = int.Parse(viewModel.NumberOfSmallLoadingDocks);
                int numberOfMediumLoadingDocks = int.Parse(viewModel.NumberOfMediumLoadingDocks);
                int numberOfLargeLoadingDocks = int.Parse(viewModel.NumberOfLargeLoadingDocks);
                int numberOfCranesNextToLoadingDocks = int.Parse(viewModel.NumberOfCranesNextToLoadingDocks);
                int numberOfLoadsPerCranePerHour = int.Parse(viewModel.NumberOfLoadsPerCranePerHour);
                int numberOfCranesOnHarborStorageArea = int.Parse(viewModel.NumberOfCranesOnHarborStorageArea);
                int numberOfSmallShipDocks = int.Parse(viewModel.NumberOfSmallShipDocks);
                int numberOfMediumShipDocks = int.Parse(viewModel.NumberOfMediumShipDocks);
                int numberOfLargeShipDocks = int.Parse(viewModel.NumberOfLargeShipDocks);
                int numberOfTrucksArriveAtHarborPerHour = int.Parse(viewModel.NumberOfTrucksArriveToHarborPerHour);
                int percentageOfContainersDirectlyLoadedFromShipToTrucks = int.Parse(viewModel.PercentageOfContainersDirectlyLoadedFromShipToTrucks);
                int percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks = int.Parse(viewModel.PercentageOfContainersDirectlyLoadedFromHarborStorageToTrucks);
                int numberOfAdv = int.Parse(viewModel.NumberOfAdv);
                int loadsPerAdvPerHour = int.Parse(viewModel.LoadsPerAdvPerHour);

                List<Ship> listOfShips = new List<Ship>(5);
                List<ContainerStorageRow> listOfContainerStorageRows = new List<ContainerStorageRow>(5);
                harbor = new Harbor(listOfShips, listOfContainerStorageRows, numberOfSmallLoadingDocks, numberOfMediumLoadingDocks, numberOfLargeLoadingDocks,
                    numberOfCranesNextToLoadingDocks, numberOfLoadsPerCranePerHour, numberOfCranesOnHarborStorageArea, numberOfSmallShipDocks,
                    numberOfMediumShipDocks, numberOfLargeShipDocks, numberOfTrucksArriveAtHarborPerHour, percentageOfContainersDirectlyLoadedFromShipToTrucks,
                    percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks, numberOfAdv, loadsPerAdvPerHour);

                return harbor;
            }
            catch (Exception ex)
            {
                //
            }
            return null;
        }

        private void TextChanged(object sender, FocusEventArgs e)
        {
            if (sender is Entry entry)
            {
                if (!string.IsNullOrEmpty(entry.Text))
                {
                    if (!int.TryParse(entry.Text, out _))
                    {

                        DisplayAlert("Feil type", "Gi en gyldig heltallsverdi.", "OK");
                    }
                }
            }
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



  

        private void NumberOfSmallLoadingDocks_Unfocused(object sender, FocusEventArgs e)
        {

        }

        private void NumberOfMediumLoadingDocks_Unfocused(object sender, FocusEventArgs e)
        {

        }
    }
}
