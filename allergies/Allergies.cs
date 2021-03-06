using System;
using System.Collections.Generic;

public class Allergies
{    
    List<string> _allergies;

    public Allergies(int mask)
    {
        _allergies = new List<string>();

        foreach(KeyValuePair<string, int> pair in AllergyList)
        {
            if ((mask & pair.Value) == pair.Value)
            {
                _allergies.Add(pair.Key);
            }
        }

    }

    public bool IsAllergicTo(string allergy)
    {
        return (_allergies.Contains(allergy));
    }

    public IList<string> List()
    {
        List<string> allergyList = new List<string>(_allergies);
        return allergyList;
    }

    public static Dictionary<string, int> AllergyList = new Dictionary<string, int>()
    {
        {"eggs", 1},
        {"peanuts", 2},
        {"shellfish", 4},
        {"strawberries", 8},
        {"tomatoes", 16},
        {"chocolate", 32},
        {"pollen", 64},
        {"cats", 128}
    };

}