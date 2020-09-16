using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly SortedDictionary<int, SortedSet<string>>
        _dictionary = new SortedDictionary<int, SortedSet<string>>();

    public void Add(string student, int grade)
    {
        if (_dictionary.ContainsKey(grade))
            _dictionary[grade].Add(student);
        else
            _dictionary.Add(grade, new SortedSet<string> { student });

    }

    public IEnumerable<string> Roster()
    {
        var result = new List<string>();
        foreach (var item in _dictionary)
        {
            result.AddRange(item.Value);
        }

        return result;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (_dictionary.ContainsKey(grade))
            return _dictionary[grade];

        return Enumerable.Empty<string>();
    }
}