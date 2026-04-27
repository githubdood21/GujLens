using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GujLens.Models;
using System.Collections.ObjectModel;

namespace GujLens.ViewModels;

/// <summary>
/// Main view model for the application. Handles the primary state and commands.
/// </summary>
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _appName = "GujLens";

    [ObservableProperty]
    private string _statusText = "Ready";

    [ObservableProperty]
    private bool _isProcessing;

    [ObservableProperty]
    private ObservableCollection<DetectedObject> _detectedObjects = new();

    [ObservableProperty]
    private ObservableCollection<TextRegion> _textRegions = new();

    [ObservableProperty]
    private string _extractedText = string.Empty;

    [ObservableProperty]
    private string _translatedText = string.Empty;

    [ObservableProperty]
    private string _targetLanguage = "en";

    public MainViewModel()
    {
    }

    [RelayCommand]
    private void ClearResults()
    {
        DetectedObjects.Clear();
        TextRegions.Clear();
        ExtractedText = string.Empty;
        TranslatedText = string.Empty;
        StatusText = "Ready";
    }

    [RelayCommand]
    private void TranslateText()
    {
        if (string.IsNullOrWhiteSpace(ExtractedText))
        {
            StatusText = "No text to translate";
            return;
        }

        StatusText = $"Translating to {TargetLanguage}...";
        // Translation will be done by the service
        StatusText = "Translation complete (placeholder)";
    }
}