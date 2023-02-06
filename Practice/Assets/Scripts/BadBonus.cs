using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BadBonus : InteractiveObject, IFly, IRotation
{
    private float _lengthFlay;
    private float _speedRotation;

    public delegate void CaughtPlayerChangeBad();
    public CaughtPlayerChangeBad CaughtPlayerBad;

    private void Awake()
    {
        _lengthFlay = Random.Range(1.0f, 5.0f);
        _speedRotation = Random.Range(10.0f, 50.0f);
    }
    protected override void Interaction()
    {
        player.TryGetComponent(out PlayerScript playerScript);
        playerScript.Speed -= 1;
        CaughtPlayerBad();
    }
    public void Fly()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFlay),
        transform.localPosition.z );
    }
    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation),
        Space.World);
    }
}
