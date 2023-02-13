using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerBall : PlayerScript
{
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public override void Move(float x, float y, float z)
    {
        _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
    }
}
