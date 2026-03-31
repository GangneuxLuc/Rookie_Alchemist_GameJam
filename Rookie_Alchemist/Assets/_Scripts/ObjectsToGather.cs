using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Rigidbody rbPlateau;
    
    Joint joint;

    [Tooltip(" Les différents points où les pobjets peuvent atterir sur le plateau quand on les récupère.")]
    [Header("Random Emplacement")]
    public Transform[] randomEmplacements;
    public float height;




    
   // je fais une liste que je mets à jour quand un objet rentre dedans.
    


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

