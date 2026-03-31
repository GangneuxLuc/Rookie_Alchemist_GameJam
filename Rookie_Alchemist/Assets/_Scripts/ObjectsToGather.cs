using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Rigidbody rbPlateau;
    
    Joint joint;

    [Header("Random EMplacement")]
    public Transform[] randomEmplacements;
    public float height;
    public void Interact()
    {
        // Fix la foce pour briser le joint et faire tomber l'objet
        // Faire une UI qui signale une interaction possible lorsqu'on est assez proche de l'objet

        transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position + Vector3.up * height;
        joint = gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = rbPlateau;
        joint.breakForce = float.PositiveInfinity;
        joint.breakTorque = 100f;
        joint.enableCollision = true; 
    }


    void Update()
    {
       
    }
}

