using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Transform plateau;

    [Header("Random EMplacement")]
    public Transform[] randomEmplacements;
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position;

    }
}

