using UnityEngine;

public class ObjectsToGather : MonoBehaviour, IInteractable
{
    [Header("References")]
    [SerializeField] Rigidbody rbPlateau;
    GameObject plateau;
    
    Joint joint;

    [Header("Random EMplacement")]
    public Transform[] randomEmplacements;
    public float height;

    public void Awake()
    {
       plateau = GameObject.FindWithTag("Plateau"); 
       rbPlateau = plateau.GetComponent<Rigidbody>();


       // randomEmplacements = 
    }
    public void Interact()
    {
        // Fix la foce pour briser le joint et faire tomber l'objet
        // Faire une UI qui signale une interaction possible lorsqu'on est assez proche de l'objet

        transform.position = randomEmplacements[Random.Range(0, randomEmplacements.Length)].position + Vector3.up * height;
       
    }


    void Update()
    {
       
    }
}

