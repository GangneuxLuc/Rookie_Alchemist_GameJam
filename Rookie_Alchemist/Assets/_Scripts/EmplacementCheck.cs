using UnityEngine;

public class EmplacementCheck : MonoBehaviour
{
    public bool bOccupied;


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            bOccupied = true;
        }
    }
}
