using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject pickUp = null;
    public InteractableOBJ Interactable = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       DetermineInteractable();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            pickUp = other.gameObject;
            Interactable = other.GetComponent<InteractableOBJ>();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            pickUp = null;
            Interactable = null;
        }
    }
    void DetermineInteractable()
    {

    }
    void ExecuteInteractable()
    {

    }
}
