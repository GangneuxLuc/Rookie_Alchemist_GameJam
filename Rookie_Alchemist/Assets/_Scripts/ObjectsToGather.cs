using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Transform plateau;

    [Header("Random EMplacement")]
    public Transform[] randomEmplacements;
    public void Interact()
    {
<<<<<<< Updated upstream
        Debug.Log(Random.Range(0, 100));
        transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position;
=======
        // Fix la foce pour briser le joint et faire tomber l'objet
        // Faire une UI qui signale une interaction possible lorsqu'on est assez proche de l'objet

        foreach (Transform emplacement in randomEmplacements)
        {
            if (Vector3.Distance(transform.position, emplacement.position) < 0.5f)
            {
                transform.position = emplacement.position + Vector3.up * height;
                gameObject.layer = LayerMask.NameToLayer("Plateau");
                return;
            }
        }
    }
>>>>>>> Stashed changes

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (Random.Range(0, randomEmplacements.Length) in randomEmplacements)
            /* transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position + Vector3.up * height;
             joint = gameObject.AddComponent<FixedJoint>();
             joint.connectedBody = rbPlateau;
             joint.breakForce = float.PositiveInfinity;
             joint.breakTorque = 100f;
             //joint.enableCollision = true; */
        }
    }
}

