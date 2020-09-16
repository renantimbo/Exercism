using System;

public static class ResistorColor
{
    private static string[] code = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color) => Array.IndexOf(code, color);

    public static string[] Colors() => code;
}