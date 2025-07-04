﻿using System;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace ShadUI.Demo.ViewModels;

public sealed partial class ToggleViewModel : ViewModelBase, INavigable
{
    private readonly IMessenger _messenger;

    public ToggleViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        var path = Path.Combine(AppContext.BaseDirectory, "views", "TogglePage.axaml");
        DefaultCode = path.ExtractByLineRange(61, 66).CleanIndentation();
        OutlineCode = path.ExtractByLineRange(72, 77).CleanIndentation();
        WithTextCode = path.ExtractByLineRange(83, 91).CleanIndentation();
        DisableCode = path.ExtractByLineRange(97, 103).CleanIndentation();
    }

    [RelayCommand]
    private void BackPage()
    {
        _messenger.Send(new PageChangedMessage { PageType = typeof(ToastViewModel) });
    }

    [RelayCommand]
    private void NextPage()
    {
        _messenger.Send(new PageChangedMessage { PageType = typeof(ToolTipViewModel) });
    }

    [ObservableProperty]
    private string _defaultCode = string.Empty;

    [ObservableProperty]
    private string _outlineCode = string.Empty;

    [ObservableProperty]
    private string _withTextCode = string.Empty;

    [ObservableProperty]
    private string _disableCode = string.Empty;

    public string Route => "toggle";
}