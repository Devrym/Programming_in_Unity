using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyException : Exception
{
   public string tag { get; }
   public MyException(string message, string tag) : base(message)
    {
        this.tag = tag;
    }
}
