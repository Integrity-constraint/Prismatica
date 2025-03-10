using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactble : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promptMessage;


    public virtual string OnLook()
    {
        return promptMessage;
    }
   
    public void BaseInteract()
    {
        if (useEvents) { 

            GetComponent<InteractionEvent>().Oninteract.Invoke();
        }
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
