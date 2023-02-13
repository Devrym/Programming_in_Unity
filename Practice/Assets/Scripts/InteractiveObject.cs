using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveObject : MonoBehaviour, IExecute
{
    protected Color _color;
    private bool _isInteractable;
    protected bool IsInteractable
    {
        get { return _isInteractable; }
        private set
        {
            _isInteractable = value;
            GetComponent<Renderer>().enabled = _isInteractable;
            GetComponent<Collider>().enabled = _isInteractable;
        }
    }
    public Collider player;
    private void Start()
    {
        IsInteractable = true;
        _color = Random.ColorHSV();
        if (TryGetComponent(out Renderer renderer))
        {
            renderer.material.color = _color;
        }
    }

    protected abstract void Interaction();
    public abstract void Execute();

    private void OnTriggerEnter(Collider other)
    {
        try
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            player = other;
            Interaction();
            IsInteractable = false;
            //if (other.CompareTag("Player"))
            //{
            
            //    Interaction();
            //    Destroy(gameObject);
            //}
            //else
            //{
            //    throw new MyException("Это не игрок - ",other.tag);
            //}
        }
        catch (MyException exc)
        {
            Debug.Log($"{exc.Message}{exc.tag}");
        }
        
    }

}

