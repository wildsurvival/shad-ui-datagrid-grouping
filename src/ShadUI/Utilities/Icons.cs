using Avalonia.Media;

// ReSharper disable once CheckNamespace
namespace ShadUI;

/// <summary>
///     Collection of icons used in the application.
/// </summary>
public static class Icons
{
    // arrow up down
    /// <summary>
    ///     Arrow up and down icon.
    /// </summary>
    public static readonly StreamGeometry ArrowDown = Parse("M15.71,8.71l-7,7c-.1.09-.21.16-.32.21-.05.02-.09.04-.14.04-.08.03-.16.04-.25.04s-.17-.01-.25-.04c-.05,0-.09-.02-.14-.04-.11-.05-.22-.12-.32-.21L.29,8.71c-.39-.39-.39-1.03,0-1.42s1.03-.39,1.42,0l5.29,5.3V1c0-.55.45-1,1-1s1,.45,1,1v11.59l5.29-5.3c.39-.39,1.03-.39,1.42,0s.39,1.03,0,1.42Z");
    
    /// <summary>
    ///     Calendar icon.
    /// </summary>
    public static readonly StreamGeometry Calendar = Parse(
        "M17,2h-2v-1c0-.55-.45-1-1-1s-1,.45-1,1v1h-6v-1c0-.55-.45-1-1-1s-1,.45-1,1v1h-2c-1.65,0-3,1.35-3,3v14c0,1.65,1.35,3,3,3h14c1.65,0,3-1.35,3-3V5c0-1.65-1.35-3-3-3ZM18,19c0,.55-.45,1-1,1H3c-.55,0-1-.45-1-1v-9h16v9ZM18,8H2v-3c0-.55.45-1,1-1h2v1c0,.55.45,1,1,1s1-.45,1-1v-1h6v1c0,.55.45,1,1,1s1-.45,1-1v-1h2c.55,0,1,.45,1,1v3Z");

    /// <summary>
    ///     Checkmark icon.
    /// </summary>
    public static readonly StreamGeometry Check =
        Parse(
            "M9,18c-.26,0-.51-.1-.71-.29l-5-5c-.39-.39-.39-1.02,0-1.41s1.02-.39,1.41,0l4.29,4.29,10.29-10.29c.39-.39,1.02-.39,1.41,0s.39,1.02,0,1.41l-11,11c-.2.2-.45.29-.71.29Z");

    /// <summary>
    ///     Chevron pointing down icon.
    /// </summary>
    public static readonly StreamGeometry ChevronDown = Parse("M7.41,8.58L12,13.17L16.59,8.58L18,10L12,16L6,10L7.41,8.58Z");

    /// <summary>
    ///     Chevron pointing up icon.
    /// </summary>
    public static readonly StreamGeometry ChevronUp = Parse("M7.41,15.41L12,10.83L16.59,15.41L18,14L12,8L6,14L7.41,15.41Z");

    /// <summary>
    ///     Chevron pointing left icon.
    /// </summary>
    public static readonly StreamGeometry ChevronLeft = Parse("M15.41,16.58L10.83,12L15.41,7.41L14,6L8,12L14,18L15.41,16.58Z");

    /// <summary>
    ///     Chevron pointing right icon.
    /// </summary>
    public static readonly StreamGeometry ChevronRight = Parse("M8.59,16.58L13.17,12L8.59,7.41L10,6L16,12L10,18L8.59,16.58Z");

    /// <summary>
    ///     Up and down chevron combination icon.
    /// </summary>
    public static readonly StreamGeometry ChevronUpDown = Parse(
        "M6,18c-.26,0-.51-.1-.71-.29L.29,12.71c-.39-.39-.39-1.02,0-1.41s1.02-.39,1.41,0l4.29,4.29,4.29-4.29c.39-.39,1.02-.39,1.41,0s.39,1.02,0,1.41l-5,5c-.2.2-.45.29-.71.29ZM11.71,6.71c.39-.39.39-1.02,0-1.41L6.71.29c-.39-.39-1.02-.39-1.41,0L.29,5.29c-.39.39-.39,1.02,0,1.41s1.02.39,1.41,0L6,2.41l4.29,4.29c.2.2.45.29.71.29s.51-.1.71-.29Z");

    /// <summary>
    ///     Clipboard icon.
    /// </summary>
    public static readonly StreamGeometry ClipBoard = Parse(
        "M15,2h-1c0-1.1-.9-2-2-2h-6c-1.1,0-2,.9-2,2h-1c-1.65,0-3,1.35-3,3v14c0,1.65,1.35,3,3,3h12c1.65,0,3-1.35,3-3V5c0-1.65-1.35-3-3-3ZM6,2h6v2h-6v-2ZM16,19c0,.55-.45,1-1,1H3c-.55,0-1-.45-1-1V5c0-.55.45-1,1-1h1c0,1.1.9,2,2,2h6c1.1,0,2-.9,2-2h1c.55,0,1,.45,1,1v14Z");

    /// <summary>
    ///     Clipboard with checkmark icon.
    /// </summary>
    public static readonly StreamGeometry ClipBoardCheck = Parse(
        "M15,2h-1c0-1.1-.9-2-2-2h-6c-1.1,0-2,.9-2,2h-1c-1.65,0-3,1.35-3,3v14c0,1.65,1.35,3,3,3h12c1.65,0,3-1.35,3-3V5c0-1.65-1.35-3-3-3ZM6,2h6v2h-6v-2ZM16,19c0,.55-.45,1-1,1H3c-.55,0-1-.45-1-1V5c0-.55.45-1,1-1h1c0,1.1.9,2,2,2h6c1.1,0,2-.9,2-2h1c.55,0,1,.45,1,1v14ZM8,16c-.26,0-.51-.1-.71-.29l-2-2c-.39-.39-.39-1.02,0-1.41s1.02-.39,1.41,0l1.29,1.29,3.29-3.29c.39-.39,1.02-.39,1.41,0s.39,1.02,0,1.41l-4,4c-.2.2-.45.29-.71.29Z");

    /// <summary>
    ///     Cross (X) icon.
    /// </summary>
    public static readonly StreamGeometry Cross =
        Parse("M19,6.41L17.59,5L12,10.59L6.41,5L5,6.41L10.59,12L5,17.59L6.41,19L12,13.41L17.59,19L19,17.59L13.41,12L19,6.41Z");

    /// <summary>
    ///     DateTime icon.
    /// </summary>
    public static readonly StreamGeometry DateTime = Parse(
        "M20,5v1.5c0,.55-.45,1-1,1s-1-.45-1-1v-1.5c0-.55-.45-1-1-1h-2v1c0,.55-.45,1-1,1s-1-.45-1-1v-1h-6v1c0,.55-.45,1-1,1s-1-.45-1-1v-1h-2c-.55,0-1,.45-1,1v3h4c.55,0,1,.45,1,1s-.45,1-1,1H2v9c0,.55.45,1,1,1h3.5c.55,0,1,.45,1,1s-.45,1-1,1h-3.5c-1.65,0-3-1.35-3-3V5c0-1.65,1.35-3,3-3h2v-1c0-.55.45-1,1-1s1,.45,1,1v1h6v-1c0-.55.45-1,1-1s1,.45,1,1v1h2c1.65,0,3,1.35,3,3ZM16.28,17.12c.34-.43.27-1.06-.16-1.41l-1.12-.9v-1.82c0-.55-.45-1-1-1s-1,.45-1,1v2.3c0,.3.14.59.38.78l1.5,1.2c.18.15.41.22.62.22.29,0,.58-.13.78-.38ZM21,15c0-3.86-3.14-7-7-7s-7,3.14-7,7,3.14,7,7,7,7-3.14,7-7ZM19,15c0,2.76-2.24,5-5,5s-5-2.24-5-5,2.24-5,5-5,5,2.24,5,5Z");

    /// <summary>
    ///     Error indicator icon showing a circle with an exclamation mark.
    /// </summary>
    public static readonly StreamGeometry Error =
        Parse(
            "M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-8-5a.75.75 0 01.75.75v4.5a.75.75 0 01-1.5 0v-4.5A.75.75 0 0110 5zm0 10a1 1 0 100-2 1 1 0 000 2z");

    /// <summary>
    ///     Information icon showing a circle with an 'i'.
    /// </summary>
    public static readonly StreamGeometry Info =
        Parse(
            "M18 10a8 8 0 11-16 0 8 8 0 0116 0zm-7-4a1 1 0 11-2 0 1 1 0 012 0zM9 9a.75.75 0 000 1.5h.253a.25.25 0 01.244.304l-.459 2.066A1.75 1.75 0 0010.747 15H11a.75.75 0 000-1.5h-.253a.25.25 0 01-.244-.304l.459-2.066A1.75 1.75 0 009.253 9H9z");

    /// <summary>
    ///     Application logo icon.
    /// </summary>
    public static readonly StreamGeometry Logo =
        Parse(
            "M128 224c-4.1 0-8.2-1.6-11.3-4.7-6.2-6.2-6.2-16.4 0-22.6l80-80c6.2-6.2 16.4-6.2 22.6 0 6.2 6.2 6.2 16.4 0 22.6l-80 80c-3.1 3.1-7.2 4.7-11.3 4.7zM44.4 107.4l63-63c4.9-4.9 4.9-12.9 0-17.8s-12.9-4.9-17.8 0l-63 63c-4.9 4.9-4.9 12.9 0 17.8 2.5 2.5 5.7 3.7 8.9 3.7s6.4-1.2 8.9-3.7zm6.9 95.9l152-152c6.2-6.2 6.2-16.4 0-22.6-6.2-6.2-16.4-6.2-22.6 0l-152 152c-6.2 6.2-6.2 16.4 0 22.6 3.1 3.1 7.2 4.7 11.3 4.7s8.2-1.6 11.3-4.7z");

    /// <summary>
    ///     Marker icon.
    /// </summary>
    public static readonly StreamGeometry Marker = Parse(
        "M20.71,8.29c-.39-.39-1.03-.39-1.42,0l-4.59,4.6c-.38.37-1.02.37-1.39,0l-5.2-5.19c-.37-.39-.37-1.01,0-1.39L12.71,1.71c.39-.39.39-1.03,0-1.42s-1.03-.39-1.42,0l-4.6,4.61c-.74.75-1,1.8-.78,2.77L.29,13.29c-.18.19-.29.44-.29.71v3c0,.55.45,1,1,1h9c.27,0,.52-.11.71-.29l2.62-2.62c.22.05.45.07.67.07.76,0,1.52-.28,2.11-.85l4.6-4.6c.39-.39.39-1.03,0-1.42ZM9.59,16H2v-1.59l5-4.99,4.59,4.58-2,2Z");

    /// <summary>
    ///     Minus icon.
    /// </summary>
    public static readonly StreamGeometry Minus =
        Parse("M15,2H1c-.55,0-1-.45-1-1S.45,0,1,0h14c.55,0,1,.45,1,1s-.45,1-1,1Z");

    /// <summary>
    ///     Palette icon.
    /// </summary>
    public static readonly StreamGeometry Palette = Parse(
        "M11,0C4.93,0,0,4.93,0,11s4.93,11,11,11h.25c.59,0,1.18-.19,1.65-.55.59-.44.97-1.08,1.07-1.81.11-.73-.08-1.45-.52-2.04l-.3-.4c-.1-.13-.15-.29-.15-.45,0-.41.34-.75.75-.75h2.25c3.31,0,6-2.69,6-6C22,4.49,17.07,0,11,0ZM16,14h-2.25c-1.52,0-2.75,1.23-2.75,2.75,0,.59.19,1.18.55,1.65l.3.4c.12.16.17.36.14.56-.03.19-.13.37-.29.49-.13.1-.29.15-.45.15h-.25c-4.96,0-9-4.04-9-9S6.04,2,11,2s9,3.59,9,8c0,2.21-1.79,4-4,4ZM14,5.5c0,.83-.67,1.5-1.5,1.5s-1.5-.67-1.5-1.5.67-1.5,1.5-1.5,1.5.67,1.5,1.5ZM18,9.5c0,.83-.67,1.5-1.5,1.5s-1.5-.67-1.5-1.5.67-1.5,1.5-1.5,1.5.67,1.5,1.5ZM7,11.5c0,.83-.67,1.5-1.5,1.5s-1.5-.67-1.5-1.5.67-1.5,1.5-1.5,1.5.67,1.5,1.5ZM9,6.5c0,.83-.67,1.5-1.5,1.5s-1.5-.67-1.5-1.5.67-1.5,1.5-1.5,1.5.67,1.5,1.5Z");

    /// <summary>
    ///     Search icon.
    /// </summary>
    public static readonly StreamGeometry Search =
        Parse(
            "M19.71,18.29l-3.68-3.68c1.23-1.54,1.97-3.49,1.97-5.61C18,4.04,13.96,0,9,0S0,4.04,0,9s4.04,9,9,9c2.12,0,4.07-.74,5.61-1.97l3.68,3.68c.2.19.45.29.71.29s.51-.1.71-.29c.39-.39.39-1.03,0-1.42ZM2,9c0-3.86,3.14-7,7-7s7,3.14,7,7-3.14,7-7,7-7-3.14-7-7Z");

    /// <summary>
    ///     Settings icon.
    /// </summary>
    public static readonly StreamGeometry Settings = Parse(
        "M14,10c-1.86,0-3.43,1.27-3.87,3H2c-.55,0-1,.45-1,1s.45,1,1,1h8.13c.44,1.73,2.01,3,3.87,3,2.21,0,4-1.79,4-4s-1.79-4-4-4ZM14,16c-1.1,0-2-.9-2-2s.9-2,2-2,2,.9,2,2-.9,2-2,2ZM16,3H7.87c-.44-1.73-2.01-3-3.87-3C1.79,0,0,1.79,0,4s1.79,4,4,4c1.86,0,3.43-1.27,3.87-3h8.13c.55,0,1-.45,1-1s-.45-1-1-1ZM4,6c-1.1,0-2-.9-2-2s.9-2,2-2,2,.9,2,2-.9,2-2,2Z");

    /// <summary>
    ///     Side panel toggle icon.
    /// </summary>
    public static readonly StreamGeometry SidePanel =
        Parse(
            "M17,0H3C1.35,0,0,1.35,0,3v14c0,1.65,1.35,3,3,3h14c1.65,0,3-1.35,3-3V3c0-1.65-1.35-3-3-3ZM2,17V3c0-.55.45-1,1-1h9v16H3c-.55,0-1-.45-1-1ZM18,17c0,.55-.45,1-1,1h-3V2h3c.55,0,1,.45,1,1v14Z");

    /// <summary>
    ///     Success indicator icon showing a circle with a checkmark.
    /// </summary>
    public static readonly StreamGeometry Success =
        Parse(
            "M10 18a8 8 0 100-16 8 8 0 000 16zm3.857-9.809a.75.75 0 00-1.214-.882l-3.483 4.79-1.88-1.88a.75.75 0 10-1.06 1.061l2.5 2.5a.75.75 0 001.137-.089l4-5.5z");

    /// <summary>
    ///     Swatch icon.
    /// </summary>
    public static readonly StreamGeometry Swatch = Parse(
        "M17.08,10.01l.31-.32c.63-.66.96-1.52.95-2.43-.02-.9-.39-1.75-1.03-2.37l-1.91-1.9c-1.33-1.33-3.49-1.32-4.81,0l-.59.59v-.58c0-1.65-1.35-3-3-3H3C1.35,0,0,1.35,0,3v12c0,2.76,2.24,5,5,5h12c1.65,0,3-1.35,3-3v-4c0-1.62-1.31-2.95-2.92-2.99ZM8,15c0,1.65-1.35,3-3,3s-3-1.35-3-3V3c0-.55.45-1,1-1h4c.55,0,1,.45,1,1v12ZM10,6.42l2.01-2.01c.54-.55,1.43-.55,1.99,0l1.91,1.91c.27.26.42.61.43.98,0,.38-.13.73-.42,1.03l-5.92,5.95v-7.86ZM18,17c0,.55-.45,1-1,1h-7.88l5.97-6h1.91c.55,0,1,.45,1,1v4ZM6.01,15c0,.55-.45,1-1,1s-1.01-.45-1.01-1,.45-1,1-1h.01c.55,0,1,.45,1,1Z");

    /// <summary>
    ///     Warning indicator icon showing a triangle with an exclamation mark.
    /// </summary>
    public static readonly StreamGeometry Warning = Parse(
        "M14.82,12.34L9.22,1.02C8.87.36,8.31.03,7.62,0c-.7-.02-1.11.21-1.48.64-.09.11-.14.17-.25.37L.18,12.32c-.61,1.27.42,2.7,1.67,2.72h11.29c1.38-.02,2.22-1.56,1.68-2.7ZM8,12.21c-.12.13-.29.19-.51.19s-.39-.06-.51-.19c-.12-.12-.18-.27-.18-.46s.07-.34.19-.47c.12-.12.29-.19.5-.19s.39.07.51.19c.12.13.18.28.18.47s-.06.34-.18.46ZM6.84,5.04h1.28l-.12,5.14h-1.05l-.11-5.14Z");

    /// <summary>
    ///     Minimize window icon.
    /// </summary>
    public static readonly StreamGeometry WindowMinimize = Parse(
        "M3.59,7.21A3.56,3.56,0,0,1,2.2,6.93a3.66,3.66,0,0,1-1.15-.78A3.88,3.88,0,0,1,.28,5,3.42,3.42,0,0,1,0,3.62,3.45,3.45,0,0,1,.28,2.23a4.12,4.12,0,0,1,.77-1.16A3.52,3.52,0,0,1,2.2.28,3.39,3.39,0,0,1,3.59,0H68.41A3.39,3.39,0,0,1,69.8.28,3.52,3.52,0,0,1,71,1.07a4.12,4.12,0,0,1,.77,1.16A3.45,3.45,0,0,1,72,3.62,3.42,3.42,0,0,1,71.72,5,3.88,3.88,0,0,1,71,6.15a3.66,3.66,0,0,1-1.15.78,3.56,3.56,0,0,1-1.39.28Z");

    /// <summary>
    ///     Restore window icon.
    /// </summary>
    public static readonly StreamGeometry WindowRestore = Parse(
        "M10.62,72a9.92,9.92,0,0,1-4-.86A11.15,11.15,0,0,1,.86,65.43,9.92,9.92,0,0,1,0,61.38V25A9.86,9.86,0,0,1,.86,21,11.32,11.32,0,0,1,3.18,17.6a11,11,0,0,1,3.38-2.32,9.68,9.68,0,0,1,4.06-.87H47a9.84,9.84,0,0,1,4.08.87A11,11,0,0,1,56.72,21,9.84,9.84,0,0,1,57.59,25V61.38a9.68,9.68,0,0,1-.87,4.06,11,11,0,0,1-2.32,3.38A11.32,11.32,0,0,1,51,71.14,9.86,9.86,0,0,1,47,72Zm36.17-7.21a3.39,3.39,0,0,0,1.39-.28,3.79,3.79,0,0,0,1.16-.77,3.47,3.47,0,0,0,1.07-2.53v-36a3.55,3.55,0,0,0-.28-1.41,3.51,3.51,0,0,0-.77-1.16,3.67,3.67,0,0,0-1.16-.77,3.55,3.55,0,0,0-1.41-.28h-36a3.45,3.45,0,0,0-1.39.28,3.59,3.59,0,0,0-1.14.79,3.79,3.79,0,0,0-.77,1.16,3.39,3.39,0,0,0-.28,1.39v36a3.45,3.45,0,0,0,.28,1.39A3.62,3.62,0,0,0,9.4,64.51a3.45,3.45,0,0,0,1.39.28Zm18-43.45a13.14,13.14,0,0,0-1.16-5.5,14.41,14.41,0,0,0-3.14-4.5,15,15,0,0,0-4.61-3,14.14,14.14,0,0,0-5.5-1.1H15A10.73,10.73,0,0,1,21.88.51,10.93,10.93,0,0,1,25.21,0H50.38a20.82,20.82,0,0,1,8.4,1.71A21.72,21.72,0,0,1,70.29,13.18,20.91,20.91,0,0,1,72,21.59v25.2a10.93,10.93,0,0,1-.51,3.33A10.71,10.71,0,0,1,70,53.05a10.84,10.84,0,0,1-2.28,2.36,10.66,10.66,0,0,1-3,1.58Z");

    /// <summary>
    ///     Maximize window icon.
    /// </summary>
    public static readonly StreamGeometry WindowMaximize = Parse(
        "M10.62,72a9.92,9.92,0,0,1-4-.86A11.15,11.15,0,0,1,.86,65.43,9.92,9.92,0,0,1,0,61.38V10.62a9.92,9.92,0,0,1,.86-4A11.15,11.15,0,0,1,6.57.86a9.92,9.92,0,0,1,4-.86H61.38a9.92,9.92,0,0,1,4.05.86,11.15,11.15,0,0,1,5.71,5.71,9.92,9.92,0,0,1,.86,4V61.38a9.92,9.92,0,0,1-.86,4.05,11.15,11.15,0,0,1-5.71,5.71,9.92,9.92,0,0,1-4.05.86Zm50.59-7.21a3.45,3.45,0,0,0,1.39-.28,3.62,3.62,0,0,0,1.91-1.91,3.45,3.45,0,0,0,.28-1.39V10.79a3.45,3.45,0,0,0-.28-1.39A3.62,3.62,0,0,0,62.6,7.49a3.45,3.45,0,0,0-1.39-.28H10.79a3.45,3.45,0,0,0-1.39.28A3.62,3.62,0,0,0,7.49,9.4a3.45,3.45,0,0,0-.28,1.39V61.21a3.45,3.45,0,0,0,.28,1.39A3.62,3.62,0,0,0,9.4,64.51a3.45,3.45,0,0,0,1.39.28Z");

    /// <summary>
    ///     Close window icon.
    /// </summary>
    public static readonly StreamGeometry WindowClose = Parse(
        "M36,41.1,6.15,71a3.44,3.44,0,0,1-2.53,1A3.55,3.55,0,0,1,0,68.38a3.44,3.44,0,0,1,1.05-2.53L30.9,36,1.05,6.15A3.49,3.49,0,0,1,0,3.59,3.51,3.51,0,0,1,.28,2.18,3.42,3.42,0,0,1,1.05,1,3.82,3.82,0,0,1,2.21.28,3.58,3.58,0,0,1,3.62,0,3.44,3.44,0,0,1,6.15,1.05L36,30.9,65.85,1.05a3.49,3.49,0,0,1,2.56-1A3.39,3.39,0,0,1,69.8.28,3.8,3.8,0,0,1,71,1.05a3.8,3.8,0,0,1,.77,1.15A3.39,3.39,0,0,1,72,3.59a3.49,3.49,0,0,1-1,2.56L41.1,36,71,65.85a3.44,3.44,0,0,1,1,2.53,3.58,3.58,0,0,1-.28,1.41A3.82,3.82,0,0,1,71,71a3.42,3.42,0,0,1-1.14.77,3.66,3.66,0,0,1-4-.77Z");

    /// <summary>
    ///     Parses the given path string into a <see cref="StreamGeometry" />.
    /// </summary>
    /// <param name="path">The path string to parse.</param>
    /// <returns>A <see cref="StreamGeometry" /> object representing the parsed path.</returns>
    public static StreamGeometry Parse(string path) => StreamGeometry.Parse(path);
}