
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Gruppe8.HarbNet.GuiEdition.ViewModel
{
    public partial class ConsoleViewModel : ObservableObject
    {
        public ConsoleViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<String> items;

        [ObservableProperty]
        string consoleOutput;

        [RelayCommand]
        void AddToConsole()
        {
            if(string.IsNullOrWhiteSpace(consoleOutput)) { return; }
            items.Add(consoleOutput);
            consoleOutput = string.Empty;
        }
    }
}
