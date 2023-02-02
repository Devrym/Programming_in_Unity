using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable : IAction, IInitialization
{
    bool IsInteractable { get; }
}
