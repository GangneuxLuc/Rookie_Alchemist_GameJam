using UnityEngine;


public class interactionDetection : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            // On fait appraitre une UI pour indiquer que l'objet est interactable
            // Debug.Log("détection");
            if (Input.GetKey(KeyCode.E))
            {
                // ObjectsToGather script = other.gameObject.GetComponent<ObjectsToGather>().Interact();
                other.gameObject.GetComponent<ObjectsToGather>().Interact();
            }
            
        }
    }
}
