using UnityEngine;


public class interactionDetection : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            Debug.Log("détection");
            if (Input.GetKey(KeyCode.E))
            {
                // ObjectsToGather script = other.gameObject.GetComponent<ObjectsToGather>().Interact();
                other.gameObject.GetComponent<ObjectsToGather>().Interact();
            }
            
        }
    }
}
