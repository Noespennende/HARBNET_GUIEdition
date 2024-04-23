using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8.HarbNet.GuiEdition.ViewModel
{
    internal class HarborCreateView : INotifyPropertyChanged
    {


        private String _SimulationStart;

        private ObservableCollection<string> items = new ObservableCollection<string>();

        public ObservableCollection<String> Items
        {
            get { return items; }
            set { 
                if(items != value)
                {
                    items = value;
                    onPropertyChanged(nameof(Items));
                }
            }
        }
        private String _NumberOfSmallShips;
        public String NumberOfSmallShips
        {
            get { return _NumberOfSmallShips; }
            set
            {
                if (_NumberOfSmallShips != value)
                {
                    _NumberOfSmallShips = value;
                    onPropertyChanged(nameof(NumberOfSmallShips));
                }
            }
        }

        private String _NumberOfMediumShips;

        public String NumberOfMediumShips
        {
            get { return _NumberOfMediumShips; }
            set
            {
                if (_NumberOfMediumShips != value)
                {
                    _NumberOfMediumShips = value;
                    onPropertyChanged(nameof(NumberOfMediumShips));
                }
            }
        }
        private String _NumberOfLargeShips;

        public String NumberOfLargeShips
        {
            get { return _NumberOfLargeShips; }
            set
            {
                if (_NumberOfLargeShips != value)
                {
                    _NumberOfLargeShips = value;
                    onPropertyChanged(nameof(NumberOfLargeShips));
                }
            }
        }

        public String SimulationStart
        {
            get { return _SimulationStart; }
            set
            {
                if (_SimulationStart != value)
                {
                    _SimulationStart = value;
                    onPropertyChanged(nameof(SimulationStart));
                }
            }
        }

        private String _SimulationEnd;
        public String SimulationEnd
        {
            get { return _SimulationEnd; }
            set
            {
                if (_SimulationEnd != value)
                {
                    _SimulationEnd = value;
                    onPropertyChanged(nameof(SimulationEnd));
                }
            }
        }

        private string _NumberOfSmallLoadingDocks;
        public string NumberOfSmallLoadingDocks

        {
            get { return _NumberOfSmallLoadingDocks; }
            set
            {
                if (_NumberOfSmallLoadingDocks != value)
                {
                    _NumberOfSmallLoadingDocks = value;
                    onPropertyChanged(nameof(NumberOfSmallLoadingDocks));
                }
            }
        }

        private string _NumberOfMediumLoadingDocks;
        public string NumberOfMediumLoadingDocks

        {
            get { return _NumberOfMediumLoadingDocks; }
            set
            {
                if (_NumberOfMediumLoadingDocks != value)
                {
                    _NumberOfMediumLoadingDocks = value;
                    onPropertyChanged(nameof(NumberOfMediumLoadingDocks));
                }
            }
        }

        private string _NumberOfLargeLoadingDocks;
        public string NumberOfLargeLoadingDocks

        {
            get { return _NumberOfLargeLoadingDocks; }
            set
            {
                if (_NumberOfLargeLoadingDocks != value)
                {
                    _NumberOfLargeLoadingDocks = value;
                    onPropertyChanged(nameof(NumberOfLargeLoadingDocks));
                }
            }
        }

        private string _NumberOfCranesNextToLoadingDocks;
        public string NumberOfCranesNextToLoadingDocks

        {
            get { return _NumberOfCranesNextToLoadingDocks; }
            set
            {
                if (_NumberOfCranesNextToLoadingDocks != value)
                {
                    _NumberOfCranesNextToLoadingDocks = value;
                    onPropertyChanged(nameof(NumberOfCranesNextToLoadingDocks));
                }
            }
        }

        private string _NumberOfLoadsPerCranePerHour;
        public string NumberOfLoadsPerCranePerHour

        {
            get { return _NumberOfLoadsPerCranePerHour; }
            set
            {
                if (_NumberOfLoadsPerCranePerHour != value)
                {
                    _NumberOfLoadsPerCranePerHour = value;
                    onPropertyChanged(nameof(NumberOfLoadsPerCranePerHour));
                }
            }
        }

        private string _NumberOfCranesOnHarborStorageArea;
        public string NumberOfCranesOnHarborStorageArea

        {
            get { return _NumberOfCranesOnHarborStorageArea; }
            set
            {
                if (_NumberOfCranesOnHarborStorageArea != value)
                {
                    _NumberOfCranesOnHarborStorageArea = value;
                    onPropertyChanged(nameof(NumberOfCranesOnHarborStorageArea));
                }
            }
        }

        private string _NumberOfSmallShipDocks;
        public string NumberOfSmallShipDocks

        {
            get { return _NumberOfSmallShipDocks; }
            set
            {
                if (_NumberOfSmallShipDocks != value)
                {
                    _NumberOfSmallShipDocks = value;
                    onPropertyChanged(nameof(NumberOfSmallShipDocks));
                }
            }
        }

        private string _NumberOfMediumShipDocks;
        public string NumberOfMediumShipDocks

        {
            get { return _NumberOfMediumShipDocks; }
            set
            {
                if (_NumberOfMediumShipDocks != value)
                {
                    _NumberOfMediumShipDocks = value;
                    onPropertyChanged(nameof(NumberOfMediumShipDocks));
                }
            }
        }

        private string _NumberOfLargeShipDocks;
        public string NumberOfLargeShipDocks

        {
            get { return _NumberOfLargeShipDocks; }
            set
            {
                if (_NumberOfLargeShipDocks != value)
                {
                    _NumberOfLargeShipDocks = value;
                    onPropertyChanged(nameof(NumberOfLargeShipDocks));
                }
            }
        }

        private string _numberOfTrucksArriveToHarborPerHour;
        public string NumberOfTrucksArriveToHarborPerHour

        {
            get { return _numberOfTrucksArriveToHarborPerHour; }
            set
            {
                if (_numberOfTrucksArriveToHarborPerHour != value)
                {
                    _numberOfTrucksArriveToHarborPerHour = value;
                    onPropertyChanged(nameof(NumberOfTrucksArriveToHarborPerHour));
                }
            }
        }

        private string _percentageOfContainersDirectlyLoadedFromShipToTrucks;
        public string PercentageOfContainersDirectlyLoadedFromShipToTrucks

        {
            get { return _percentageOfContainersDirectlyLoadedFromShipToTrucks; }
            set
            {
                if (_percentageOfContainersDirectlyLoadedFromShipToTrucks != value)
                {
                    _percentageOfContainersDirectlyLoadedFromShipToTrucks = value;
                    onPropertyChanged(nameof(PercentageOfContainersDirectlyLoadedFromShipToTrucks));
                }
            }
        }

        private string _percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks;
        public string PercentageOfContainersDirectlyLoadedFromHarborStorageToTrucks

        {
            get { return _percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks; }
            set
            {
                if (_percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks != value)
                {
                    _percentageOfContainersDirectlyLoadedFromHarborStorageToTrucks = value;
                    onPropertyChanged(nameof(PercentageOfContainersDirectlyLoadedFromHarborStorageToTrucks));
                }
            }
        }

        private string _numberOfAdv;
        public string NumberOfAdv

        {
            get { return _numberOfAdv; }
            set
            {
                if (_numberOfAdv != value)
                {
                    _numberOfAdv = value;
                    onPropertyChanged(nameof(NumberOfAdv));
                }
            }
        }

        private string _LoadsPerAdvPerHour;
        public string LoadsPerAdvPerHour

        {
            get { return _LoadsPerAdvPerHour; }
            set
            {
                if (_LoadsPerAdvPerHour != value)
                {
                    _LoadsPerAdvPerHour = value;
                    onPropertyChanged(nameof(LoadsPerAdvPerHour));
                }
            }
        }

        //Console
        public void AddToConsole(String consoleOutput)
        {
            if (string.IsNullOrWhiteSpace(consoleOutput)) { return; }
            items.Add(consoleOutput);
        }

        public void ClearConsole() { items.Clear(); }

        public event PropertyChangedEventHandler? PropertyChanged;

        void onPropertyChanged(String name) =>
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
