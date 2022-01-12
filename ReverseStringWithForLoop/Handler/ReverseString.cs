namespace ReverseStringWithForLoop.Handler;

public static class StringExtensionMethods
{
    public static string ReverseString(this string? str)
    {
        var reversedString = "";
        if (str == null) return reversedString;
        for (var i = str.Length - 1; i >= 0; i--) reversedString += str[i];
        return reversedString;
    }
}