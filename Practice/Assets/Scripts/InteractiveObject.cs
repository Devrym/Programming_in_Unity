using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour, IInteractable
{
    public bool IsInteractable { get; } = true;
    public Collider player;
    protected abstract void Interaction();
    private void Start()
    {
        ((IAction)this).Action();
        ((IInitialization)this).Action();
    }
    void IAction.Action()
    {
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = Random.ColorHSV();
        }
    }
    void IInitialization.Action()
    {
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = Random.ColorHSV();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other;
            Interaction();
            Destroy(gameObject);
        }
        
    }

}

