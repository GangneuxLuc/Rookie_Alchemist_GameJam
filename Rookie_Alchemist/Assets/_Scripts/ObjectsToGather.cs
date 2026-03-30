using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Transform plateau;
    [SerializeField] Rigidbody rbPlateau;

    [Header("Gathering settings")]
    public Transform[] randomEmplacements;
    public float height;
    private Joint joint;
    public void Interact()
    {
        // Fix la foce pour briser le joint et faire tomber l'objet
        // Faire une UI qui signale une interaction possible lorsqu'on est assez proche de l'objet
        transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position + Vector3.up * height;
        gameObject.layer = LayerMask.NameToLayer("Plateau");

        joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = rbPlateau;
        joint.breakForce = 10f;
        joint.breakTorque = 100f;
       // joint.enableCollision = true;


    }
}

