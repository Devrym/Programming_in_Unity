using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GoodBonus : InteractiveObject, IRotation, IFlicker
{
    [SerializeField] bool Need;
    private Material _material;
    private float _speedRotation;
    private DisplayBonuses _displayBonuses;
    public delegate void CaughtPlayerChangeGood();
    public CaughtPlayerChangeGood CaughtPlayerGood;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _speedRotation = Random.Range(10.0f, 50.0f);
        _displayBonuses = new DisplayBonuses();
    }
    protected override void Interaction()
    {
        if (Need)
        {
            player.TryGetComponent(out PlayerScript playerScript);
            playerScript.VictoryPoint += 1;
            playerScript.Speed += 1;
            CaughtPlayerGood();
        }
        else
        {
            player.TryGetComponent(out PlayerScript playerScript);
            playerScript.Speed += 1;
            CaughtPlayerGood();
        }
    }

    public void Flicker()
    {
        _material.color = new Color(_material.color.r, _material.color.g,
        _material.color.b,
        Mathf.PingPong(Time.time, 1.0f));
    }

    public void Rotation()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation),
        Space.World);
    }

}
