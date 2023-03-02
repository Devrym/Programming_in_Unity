using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PatternSwitch
{
    private enum Gender
    {
        None = 0,
        Male = 1,
        Female = 2,
        Indefined = 3
    }
    private sealed class People
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public void Deconstruct(out string name, out Gender gender, out int age)
        {
            name = Name;
            gender = Gender;
            age = Age;
        }
    }
    private void Main()
    {
        Debug.Log(Select(new People()));
    }
    private string Select(People people)
    {
        return people switch
        {
            ("Lera", Gender.Female, 18) => "Female",
            ("Roman", Gender.Male, _) => "Male",
            ("Ilya", Gender.Indefined, _) => "Dean",
            (_, _, 17) => "Minor",
            (_, Gender.Indefined, _) => "Indefined",
            _ => "Not recognized"
        };
    }
}
