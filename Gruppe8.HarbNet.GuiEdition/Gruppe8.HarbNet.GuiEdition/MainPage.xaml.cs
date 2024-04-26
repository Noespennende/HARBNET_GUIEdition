
using Gruppe8.HarbNet.GuiEdition.ViewModel;
using System.Threading;


namespace Gruppe8.HarbNet.GuiEdition
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Harbor harbor;
        HarborCreateView viewModel;
        ShipViewModel shipViewModel;

        int ContainersEnteredHarbor = 0;
        int ContainersExitedHarborOnTrucks = 0;
        int ContainersExitedHarborOnShips = 0;
        int shipsDocked = 0;
        int hoursPassed = 0;
        DateTime currenttime = DateTime.Now;
        List<Ship> ships = new List<Ship>();



        public MainPage(ConsoleViewModel cvm)
        {
            InitializeComponent();
            

            shipViewModel = new ShipViewModel();
            viewModel = new HarborCreateView();
            BindingContext = cvm;
            BindingContext = viewModel;
            
        }

        private List<Ship> CreateShipsViewModel()
        {
            try
            {   
                
                int numberOfSmallShips = int.Parse(viewModel.NumberOfSmallShips);
                int numberOfMediumShips = int.Parse(viewModel.NumberOfMediumShips);
                int numberOfLargeShips = int.Parse(viewModel.NumberOfLargeShips);
                DateTime startTime = new DateTime(2024, 4, 24);

                ships.Clear();

                for (int i = 0; i < numberOfSmallShips; i++)
                {

                    ships.Add(new Ship("ShipSmall "+i, ShipSize.Small, currenttime.AddDays(1), false, 1, 5, 5));
                    
                }

                for (int i = 0; i < numberOfMediumShips; i++)
                {
                    ships.Add(new Ship("ShipMedium" +i, ShipSize.Medium, currenttime.AddDays(1), false, 1, 5, 5));
                }

                for (int i = 0; i < numberOfLargeShips; i++)
                {
                    ships.Add(new Ship("ShipLarge "+ i, ShipSize.Large, currenttime.AddDays(1), false, 1, 5, 5));
                }

                DisplayAlert("Ship creation", $"number of ships: {ships.Count}", "ok");


            }
            catch (Exception ex)
            {
                //
            }
            return ships;
        }

        private async void OnCreateShipsClicked(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("du klikket meg");
                List<Ship> shipList = CreateShipsViewModel();

                if (ships != null)
                {

                    DisplayAlert("Ship creation", $"number of ships: {ships.Count}", "ok");




                }

            }
            catch (Exception ex)
            {
                //
            }

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

                List<ContainerStorageRow> listOfContainerStorageRows = new List<ContainerStorageRow>(100);
                ContainerStorageRow storage = new ContainerStorageRow(100);
                listOfContainerStorageRows.Add(storage);

                harbor = new Harbor(ships, listOfContainerStorageRows, numberOfSmallLoadingDocks, numberOfMediumLoadingDocks, numberOfLargeLoadingDocks,
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
                
                int SimulationStart = int.Parse(viewModel.SimulationStart);
                int SimulationEnd = int.Parse(viewModel.SimulationEnd);
                int numberOfDaysSimulated = SimulationEnd - SimulationStart;
                Guid numberOfSmallLoadingDocks = harbor.ID;
                viewModel.ClearConsole();
                Simulation sim = new(harbor, currenttime.AddDays(SimulationStart) , currenttime.AddDays(SimulationEnd));

                //abonerer på events
                sim.SimulationStarting += (sender, e) =>
                {
                    SimulationStartingEventArgs args = (SimulationStartingEventArgs)e;
                    viewModel.AddToConsole($"▶️ SIMULATION STARTING 🖥️\n" +
                        $"Simulating from day {SimulationStart} to day {SimulationEnd}");
                };
                sim.ShipAnchored += (sender, e) =>
                {
                    ShipAnchoredEventArgs args = (ShipAnchoredEventArgs)e;
                    viewModel.AddToConsole($"🚢 ⚓\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} anchored to anchorage");
                };
                sim.ShipDockedtoLoadingDock += (sender, e) =>
                {
                    ShipDockedToLoadingDockEventArgs args = (ShipDockedToLoadingDockEventArgs)e;
                    viewModel.AddToConsole($"🚢 ⚓ 🏗\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} docked to loading dock");
                    shipsDocked++;
                };
                sim.ShipDockedToShipDock += (sender, e) =>
                {
                    ShipDockedToShipDockEventArgs args = (ShipDockedToShipDockEventArgs)e;
                    viewModel.AddToConsole($"🚢 ⚓ 🛳️\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} docked to ship dock");
                    shipsDocked++;
                };
                sim.ShipUndocking += (sender, e) =>
                {
                    ShipUndockingEventArgs args = (ShipUndockingEventArgs)e;
                    viewModel.AddToConsole($"🚢 ⬅️ 🏗\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} undocking.");
                };
                sim.ShipLoadedContainer += (sender, e) =>
                {
                    ShipLoadedContainerEventArgs args = (ShipLoadedContainerEventArgs)e;
                    ContainersExitedHarborOnShips++;
                };


                sim.ShipStartingLoading += (sender, e) =>
                {
                    ShipStartingLoadingEventArgs args = (ShipStartingLoadingEventArgs)e;
                    viewModel.AddToConsole($"🏗 ➡️ 📦 🚢\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} started loading containers from harbor to its cargohold.");
                };

                sim.ShipDoneLoading += (sender, e) =>
                {
                    ShipDoneLoadingEventArgs args = (ShipDoneLoadingEventArgs)e;
                    int half = 0;
                    int full = 0;
                    foreach (Container c in args.Ship.ContainersOnBoard)
                    {
                        if (c.Size == ContainerSize.Half)
                        {
                            half++;
                        } else
                        {
                            full++;
                        }
                    }
                    viewModel.AddToConsole($"🏗 ➡️ 📦 🚢 ✅\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} is done loading containers from harbor.\n" +
                        $"Current cargo: {full} full size containers, {half} half size containers.");

                };

                sim.ShipStartingUnloading += (sender, e) =>
                {
                    ShipStartingUnloadingEventArgs args = (ShipStartingUnloadingEventArgs)e;
                    int half = 0;
                    int full = 0;
                    foreach (Container c in args.Ship.ContainersOnBoard)
                    {
                        if (c.Size == ContainerSize.Half)
                        {
                            half++;
                        }
                        else
                        {
                            full++;
                        }
                    }
                    viewModel.AddToConsole($"🚢 ➡️ 📦 🏗️\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} has started unloading {full} size containers and {half} size containers to harbor crane.\n" +
                        $"A total of {args.Ship.ContainersOnBoard.Count} containers.");
                };

                sim.ShipDoneUnloading += (sender, e) =>
                {
                    ShipDoneUnloadingEventArgs args = (ShipDoneUnloadingEventArgs)e;
                    viewModel.AddToConsole($"🚢 ➡️ 📦 🏗️ ✅\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} is done unloading its cargo.");
                };

                sim.ShipUnloadedContainer += (sender, e) =>
                {
                    ShipUnloadedContainerEventArgs args = (ShipUnloadedContainerEventArgs)e;
                    ContainersEnteredHarbor++;
                };
                sim.ShipInTransit += (sender, e) =>
                {
                    ShipInTransitEventArgs args = (ShipInTransitEventArgs)e;
                    viewModel.AddToConsole($"🌎 ⬅️ 🚢\n" +
                        $"{args.CurrentTime}: {args.Ship.Name} is in transit");
                };
                sim.TruckLoadingFromStorage += (sender, e) =>
                {
                    TruckLoadingFromStorageEventArgs args = (TruckLoadingFromStorageEventArgs)e;
                    viewModel.AddToConsole($"🏗 ➡️ 📦 🚚\n" +
                        $"{args.CurrentTime}: A truck has loaded a container and helft the harbor");

                    ContainersExitedHarborOnTrucks++;
                };
                sim.DayEnded += (sender, e) =>
                {
                    DayOverEventArgs args = (DayOverEventArgs)e;
                    viewModel.AddToConsole($"--------------------\n" +
                        $"🌅 {args.CurrentTime} DAY OVER 🌅\n" +
                        $"\nCurrently:\n" +
                        $"-------------------------\n" +
                        $"Containers stored in harbor: {sim.History[sim.History.Count - 1].ContainersInHarbour.Count}\n" +
                        $"Ships docked to loading docks: {sim.History[sim.History.Count - 1].ShipsDockedInLoadingDocks.Count}\n" +
                        $"Ships docked to ship docks: {sim.History[sim.History.Count - 1].ShipsDockedInShipDocks.Count}\n" +
                        $"Ships anchored in anchorage: {sim.History[sim.History.Count - 1].ShipsInAnchorage.Count}\n" +
                        $"Ships in transit: {sim.History[sim.History.Count - 1].ShipsInTransit.Count}");

                };
                sim.OneHourHasPassed += (sender, e) =>
                {
                    OneHourHasPassedEventArgs args = (OneHourHasPassedEventArgs)e;
                    viewModel.AddToConsole($"🕑 New hour {args.CurrentTime.TimeOfDay.Hours} 🕑");
                    hoursPassed++;
                };

                sim.SimulationEnded += (sender, e) =>
                {
                    SimulationEndedEventArgs args = (SimulationEndedEventArgs)e;

                    viewModel.AddToConsole($"⏸️ SIMULATION OVER 🖥️\n\n" +
                        $"Harbor efficency stats:\n" +
                        $"-------------------------\n" +
                        $"Total containers entered harbor: {ContainersEnteredHarbor}\n" +
                        $"Total containers exited harbor on trucks: {ContainersExitedHarborOnTrucks}\n" +
                        $"Total containers exited harbor on ships: {ContainersExitedHarborOnShips}\n" +
                        $"Total ship dockings to harbor: {shipsDocked}\n" +
                        $"Average containers entered harbor per hour: {(float)Math.Round((float)ContainersEnteredHarbor/hoursPassed, 2)}\n" +
                        $"Average containers exited harbor per hour on ships: {(float)Math.Round((float)ContainersExitedHarborOnShips/hoursPassed, 2)}\n" +
                        $"Average containers exited harbor per hour on trucks: {(float)Math.Round((float)ContainersExitedHarborOnTrucks/hoursPassed, 2)}\n" +
                        $"\nCurrently:\n" +
                        $"-------------------------\n" +
                        $"Containers stored in harbor: {sim.History[sim.History.Count - 1].ContainersInHarbour.Count}\n" +
                        $"Ships docked to loading docks: {sim.History[sim.History.Count - 1].ShipsDockedInLoadingDocks.Count}\n" +
                        $"Ships docked to ship docks: {sim.History[sim.History.Count - 1].ShipsDockedInShipDocks.Count}\n" +
                        $"Ships anchored in anchorage: {sim.History[sim.History.Count - 1].ShipsInAnchorage.Count}\n" +
                        $"Ships in transit: {sim.History[sim.History.Count - 1].ShipsInTransit.Count}");
                };




                    SimulationClick.Text = $"Du kjører nå simuleringen i {numberOfDaysSimulated} dager {numberOfSmallLoadingDocks}";
                SemanticScreenReader.Announce(SimulationClick.Text);
                sim.Run();

                
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
