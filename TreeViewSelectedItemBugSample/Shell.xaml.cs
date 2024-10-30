using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

namespace TreeViewSelectedItemBugSample;

public partial class ShellViewModel : ObservableObject
{
    [ObservableProperty]
    private string[] _items =
        [
            "Item 1",
            "Item 2",
            "Item 3",
        ];

    [ObservableProperty]
    private string? _selectedItem;

    public ShellViewModel()
    {
        SelectedItem = Items[1];
    }

    [RelayCommand]
    private void SelectFirstItem() => SelectedItem = Items.First();

    [RelayCommand]
    private void SelectLastItem() => SelectedItem = Items.Last();
}

public sealed partial class Shell : Page
{
    public Shell()
    {
        InitializeComponent();
    }

    public ShellViewModel ViewModel { get; } = new();
}
