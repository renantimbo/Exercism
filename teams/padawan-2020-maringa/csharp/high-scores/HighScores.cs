using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _list;
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores() => _list;

    public int Latest() => _list.LastOrDefault();

    public int PersonalBest() => _list.Max();

    public List<int> PersonalTopThree()
    {
        return _list.OrderByDescending(q => q).Take(3).ToList();
    }
}