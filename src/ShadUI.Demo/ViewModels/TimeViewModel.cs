﻿using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ShadUI.Demo.Validators;

namespace ShadUI.Demo.ViewModels;

public sealed partial class TimeViewModel : ViewModelBase, INavigable
{
    private readonly IMessenger _messenger;
    private readonly ToastManager _toastManager;

    public TimeViewModel(IMessenger messenger, ToastManager toastManager)
    {
        _messenger = messenger;
        _toastManager = toastManager;
        var path = Path.Combine(AppContext.BaseDirectory, "views", "TimePage.axaml");
        Hour12ClockTimePickerCode = path.ExtractByLineRange(62, 64).CleanIndentation();
        Hour24ClockTimePickerCode = path.ExtractByLineRange(70, 73).CleanIndentation();
        DisabledTimePickerCode = path.ExtractByLineRange(79, 81).CleanIndentation();
        FormTimePickerCode = path.ExtractByLineRange(87, 110).CleanIndentation();
        Hour12ClockTimeInputCode = path.ExtractByLineRange(116, 118).CleanIndentation();
        Hour24ClockTimeInputCode = path.ExtractByLineRange(124, 127).CleanIndentation();
        DisabledTimeInputCode = path.ExtractByLineRange(133, 135).CleanIndentation();
        FormTimeInputCode = path.ExtractByLineRange(141, 164).CleanIndentation();
    }

    [RelayCommand]
    private void BackPage()
    {
        _messenger.Send(new PageChangedMessage { PageType = typeof(TabControlViewModel) });
    }

    [RelayCommand]
    private void NextPage()
    {
        _messenger.Send(new PageChangedMessage { PageType = typeof(ToastViewModel) });
    }

    [ObservableProperty]
    private string _hour12ClockTimePickerCode = string.Empty;

    [ObservableProperty]
    private string _hour24ClockTimePickerCode = string.Empty;

    [ObservableProperty]
    private string _disabledTimePickerCode = string.Empty;

    [ObservableProperty]
    private string _formTimePickerCode = string.Empty;

    private TimeOnly? _startTime;

    [Required(ErrorMessage = "Start time is required.")]
    [StartTimeValidation(nameof(EndTime), ErrorMessage = "Start time must be less than end time")]
    public TimeOnly? StartTime
    {
        get => _startTime;
        set
        {
            SetProperty(ref _startTime, value, true);
            ValidateProperty(EndTime, nameof(EndTime));
        }
    }

    private TimeOnly? _endTime;

    [Required(ErrorMessage = "End time is required.")]
    [EndTimeValidation(nameof(StartTime), ErrorMessage = "End time must be greater than start time")]
    public TimeOnly? EndTime
    {
        get => _endTime;
        set
        {
            SetProperty(ref _endTime, value, true);
            ValidateProperty(StartTime, nameof(StartTime));
        }
    }

    [RelayCommand]
    private void SubmitTimeForm()
    {
        ClearAllErrors();

        ValidateProperty(StartTime, nameof(StartTime));
        ValidateProperty(EndTime, nameof(EndTime));
        if (HasErrors) return;

        _toastManager.CreateToast("Create schedule")
            .WithContent("Schedule created successfully.")
            .DismissOnClick()
            .ShowSuccess();
    }

    [ObservableProperty]
    private string _hour12ClockTimeInputCode = string.Empty;

    [ObservableProperty]
    private string _hour24ClockTimeInputCode = string.Empty;

    [ObservableProperty]
    private string _disabledTimeInputCode = string.Empty;

    [ObservableProperty]
    private string _formTimeInputCode = string.Empty;

    public string Route => "time";
}