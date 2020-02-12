namespace DevCampAssignment
{
    internal static class Constants
    {
        internal const int LogoMinWidth = 2;
        internal const int LogoMaxWidth = 10000;

        internal const string InvalidCharacter = "Main character should be exactly one character long!";

        internal const string InvalidSpace = "Space character should be exactly one character long!";

        internal static string InvalidWidthRange = $"Width should be an odd integer between {LogoMinWidth} and {LogoMaxWidth}!";
        internal const string InvalidWidthType = "Width should be an integer!";
        internal const string InvalidEvenWidth = "Width should be odd!";

    }
}
