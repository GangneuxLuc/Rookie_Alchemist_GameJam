using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Transform plateau;

    //[Header("Random EMplacement")]
   // []
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        transform.position = plateau.position;
    }
}

