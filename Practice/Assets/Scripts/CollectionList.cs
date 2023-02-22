using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CollectionList : MonoBehaviour
{
    internal static void listCollection()
    {
        List<int> a = new List<int> { 1, 2, 4, 3, 5, 4, 4, 2, 6 };
        foreach (int val in a.Distinct())
        {
            Debug.Log(val + " - " + a.Where(x => x == val).Count() + " раз");
        }
    }
}
