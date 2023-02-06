using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class PlayerScript : MonoBehaviour
{
    public float Speed = 3.0f;
    private Rigidbody _rigidbody;
    public int VictoryPoint;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Victory();
    }

    public void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rigidbody.AddForce(movement * -Speed);
    }

    public void Victory()
    {
        if (VictoryPoint == 5)
        {
            Log("Победа");
        }
    }

}
