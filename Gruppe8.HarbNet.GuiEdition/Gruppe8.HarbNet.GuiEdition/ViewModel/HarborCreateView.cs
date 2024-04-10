using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8.HarbNet.GuiEdition.ViewModel
{
    internal class HarborCreateView : INotifyPropertyChanged
    {

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

        public event PropertyChangedEventHandler? PropertyChanged;

        void onPropertyChanged(String name) =>
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
