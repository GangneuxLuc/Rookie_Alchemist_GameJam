using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
    }
}

