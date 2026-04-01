using System.Collections.Generic;
using UnityEngine;

public class plateauManager : MonoBehaviour
{
    // il me faut une liste qui stocke les objets présent sur le plateau  OK
    // il me faut une liste d'emplacements  OK
    // il faut que j'arrive à checker si un emplacement est occupé ou pas OK
    // il faut que j'arrive à placer un objet sur un emplacement libre OK
    // il faut que quand on objet quitte le plateau, il soit retiré de la liste des objets présents sur le plateau et que l'emplacement soit libéré OK
    // il faut que les objets soient placés de manière aléatoire sur les emplacements disponibles OK
    // il faut que les objets simulent la physique une fois placés sur le plateau
    // il faut que


    private Rigidbody rb;

    private Vector3 lastPos;
    private Vector3 currentPos;


    public List<ObjectsToGather> objectList;
    public List<Transform> emplacementList;

    [Range(-10f, 10f)]public float forceMultiplier = 1f; // Multiplieur de force pour ajuster la force appliquée aux objets
    public float heightOffset = 0.5f; // Hauteur à laquelle les objets seront placés au-dessus du plateau

    private void Awake()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            objectList.Add(null);
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            emplacementList.Add(transform.GetChild(i));
        }

        rb = GetComponent<Rigidbody>();
    }



    public bool TryPlace(ObjectsToGather obj)
    {
        for (int i = 0; i < emplacementList.Count; i++)
        {
            if (objectList[i] == null) // Si l'emplacement est libre
            {
                Debug.Log("On place l'objet dans la liste");
                objectList[i] = obj; // Place l'objet dans la liste
                obj.transform.position = emplacementList[i].position + Vector3.up * obj.height; // Place l'objet sur le plateau
                obj.transform.parent = emplacementList[i]; // Parent l'objet à l'emplacement pour qu'il suive les mouvements du plateau
                obj.isPlaced = true; // Marque l'objet comme placé
                return true; // Placement réussi
            }
        }
        return false; // Aucun emplacement libre trouvé
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            Rigidbody rbObj = other.GetComponent<Rigidbody>();
            Vector3 speed = (lastPos - currentPos) / Time.deltaTime;
           // rbObj.linearVelocity = speed;
            //rbObj.AddForceAtPosition(speed * rbObj.mass, other.ClosestPoint(transform.position), ForceMode.Impulse);
            rbObj.AddRelativeForce(speed * rbObj.mass * forceMultiplier, ForceMode.Impulse);
            Debug.Log(speed);


        }
    }
    private void FixedUpdate()
    {
        lastPos = currentPos;
        currentPos = transform.position;


    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Interactable")
        {
            ObjectsToGather obj = other.GetComponent<ObjectsToGather>();
            for (int i = 0; i < objectList.Count; i++)
            {
                if (objectList[i] == obj) // Si l'objet qui quitte le plateau est dans la liste
                {
                    Debug.Log("L'objet " + obj.name + " a quitté le plateau.");
                    objectList[i] = null; // Libère l'emplacement
                    obj.transform.parent = null; // Retire le parent de l'objet car il va être détruit
                    obj.isPlaced = false; // Marque l'objet comme non placé
                    break;
                }
            }
        }
    }
}


