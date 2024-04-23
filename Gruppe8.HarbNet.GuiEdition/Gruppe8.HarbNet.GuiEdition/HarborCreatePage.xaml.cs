using Gruppe8.HarbNet.GuiEdition.ViewModel;

namespace Gruppe8.HarbNet.GuiEdition;

public partial class HarborCreatePage : ContentPage
{
	HarborCreateView viewModel;
	public HarborCreatePage()
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
				Console.WriteLine("harbor created");
                string harborInfo = $"Harbor created with ID: {createdHarbor.ID}, Name:, etc.";
				ConsoleViewModel cvm = new ConsoleViewModel();
				MainPage mainPage = new MainPage(cvm);

			}

		}catch (Exception ex)
		{
			//
		}
    
}

    private void TEXTChanged(object sender, FocusEventArgs e)
    {
        if (sender is Entry entry)
        {
			if(!string.IsNullOrEmpty(entry.Text)){
				if (!int.TryParse(entry.Text, out _))
				{

					DisplayAlert("Feil type", "Gi en gyldig heltallsverdi.", "OK");
				}
			}
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
            Harbor test = new Harbor(listOfShips, listOfContainerStorageRows, numberOfSmallLoadingDocks, numberOfMediumLoadingDocks, numberOfLargeLoadingDocks,
				numberOfCranesNextToLoadingDocks, numberOfLoadsPerCranePerHour, numberOfCranesOnHarborStorageArea, numberOfSmallShipDocks,
				numberOfMediumShipDocks, numberOfLargeShipDocks, numberOfTrucksArriveAtHarborPerHour, percentageOfContainersDirectlyLoadedFromShipToTrucks,
				percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks, numberOfAdv, loadsPerAdvPerHour);

            return test;
        }
		catch(Exception ex)
		{
			//
		}
		return null;
	}
}