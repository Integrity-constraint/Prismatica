using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactble
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
       doorOpen =!doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen",doorOpen);
    }
}
