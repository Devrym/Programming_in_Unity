using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class InputController : IExecute
{
    private readonly PlayerScript _playerBase;
    public InputController(PlayerScript player)
    {
        _playerBase = player;

    }
    public void Execute()
    {
        _playerBase.Move(Input.GetAxis("Horizontal"), 0.0f,
        Input.GetAxis("Vertical"));
    }
}
