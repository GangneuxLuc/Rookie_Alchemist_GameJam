using UnityEngine;


public class interactionDetection : MonoBehaviour
{

    bool showtext = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
           Canvas canva = other.gameObject.GetComponentInChildren<Canvas>();
            bool isPlaced = other.gameObject.GetComponent<ObjectsToGather>().isPlaced;
           
            if (!isPlaced)
            {
                if (showtext)
                {
                    canva.transform.rotation = Camera.main.transform.rotation;
                    canva.enabled = true;
                }
            }
            if (isPlaced)
            {
                showtext = false;
                Debug.Log(isPlaced);
                canva.enabled=false;
            }

            if (Input.GetKey(KeyCode.E))
            {
                
                // ObjectsToGather script = other.gameObject.GetComponent<ObjectsToGather>().Interact();
                other.gameObject.GetComponent<ObjectsToGather>().Interact();
            }
            if(Input.GetButtonDown("Fire3"))
            {
                other.gameObject.GetComponent<ObjectsToGather>().Interact();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            other.gameObject.GetComponentInChildren<Canvas>().enabled = false;
        }
    }
}
