using System;
using System.Linq;
using System.Collections.Generic;

public class Robot
{
    private static string _CHARS = "ABCDEFKHIJKLMNOPQRSTUVWXYZ";
    private static List<string> _NAMES = new List<string>();

    private string _name;

    public Robot()
    {
        Reset();
    }

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public void Reset()
    {
        string newName = GenerateName();

        while (_NAMES.Contains(newName))
        {
            newName = GenerateName();
        }

        _name = newName;
        _NAMES.Add(newName);
    }

    private string GenerateName()
    {
        var random = new Random();
        string newName;

        newName = String.Format("{0}{1}{2:000}",
            _CHARS[random.Next(_CHARS.Length)],
            _CHARS[random.Next(_CHARS.Length)],
            random.Next(1000));

        return newName;
    }
}