using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class plateauList : MonoBehaviour
{
    /*
   [SerializeField] public List<ObjectsToGather> objectList;
    private EmplacementCheck check;

    public List<Transform> emplacementList;
    public List<bool> occupiedList;
    //public Transform[] emplacement;


    private Rigidbody rbPlayer;
    Vector3 velo;
    int i;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            occupiedList[i] = emplacementList[i].GetComponent<EmplacementCheck>().bOccupied = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            occupiedList[i] = emplacementList[i].GetComponent<EmplacementCheck>().bOccupied = false;
        }
    }
    private void Awake()
    {
        rbPlayer = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            objectList.Add(null);
        } 

        for (int i = 0;i < transform.childCount; i++)
        {
            emplacementList.Add(transform.GetChild(i));
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            occupiedList.Add(false);
        }
    }

    public void Collide(GameObject maCollision) // Quand un objet rentre en collision avec le plateau, il vérifie s'il y a une place disponible dans la liste occupés. Si c'est le cas, il ajoute l'objet à la liste et le place sur le plateau. Il ne peut pas ajouter plusieurs fois le même objet dans la liste 
    {

        Vector3 velocity = transform.position;
        Debug.Log(velocity);


        for (i = 0; i < transform.childCount; i++)
        {
            if (objectList[i] == null)
            {
                if (objectList.Contains(maCollision.GetComponent<ObjectsToGather>()))
                {
                    //Debug.Log("L'objet est déjà sur le plateau");
                    break;
                }
                else
                {
                    //Debug.Log("L'objet a été ajouté à la liste");
                    objectList[i] = (maCollision.GetComponent<ObjectsToGather>());
                    //objectList[i].transform.SetParent(transform);
                    objectList[i].transform.rotation = Quaternion.Euler(0, 0, 0);

                    // objectList[i].gameObject.layer = 3;
                   // objectList[i] = emplacementList[i].GetComponent<EmplacementCheck>().bOccupied ? null : objectList[i]; // l'objet qui s'abonne à la liste met l'emplacement à true
                    
                    //Debug.Log(emplacementList[i].GetComponent<EmplacementCheck>().bOccupied);

                    if (occupiedList[i] = emplacementList[i].GetComponent<EmplacementCheck>().bOccupied == false)
                    {
                        objectList[i].transform.position = emplacementList[i].position + Vector3.up * 0.5f;
                       // bOccupied = true;
                        occupiedList[i] = emplacementList[i].GetComponent<EmplacementCheck>().bOccupied;
                    }
                    //occupiedList[i].transform.position = checkList[Random.Range(0, checkList.Count)].position;


                    //objectList[i].GetComponent<Rigidbody>().linearVelocity;


                    break;
                }
            }
        } 

    }

    private void OnCollisionEnter(Collision collision) //
    {
        if (collision.collider.tag == "Interactable" )
        {
            //Debug.Log("On rentre en collision avec l'objet");
            if (objectList.Contains(collision.gameObject.GetComponent<ObjectsToGather>()))
            {
               // Debug.Log("L'objet est déjà sur le plateau");
            }
            else
            {
                //Debug.Log("L'objet n'est pas encore sur le plateau");
                Collide(collision.gameObject);
            }

        }
    }

     private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Interactable")
        {
            for (i = 0; i < transform.childCount; i++)
            {
                if (objectList[i] != null)
                {
                    if (objectList[i].gameObject == collision.gameObject)
                    {
                        //Debug.Log("L'objet est toujours en collision avec le plateau");
                        // Appliquer la vélocité au plateau
                        velo = rbPlayer.linearVelocity;
                        Rigidbody rbObj = objectList[i].GetComponent<Rigidbody>();
                        //rbObj.linearVelocity.x = velo.x;
                        rbObj.linearVelocity = new Vector3(velo.x, rbObj.linearVelocity.y, velo.z);
                        break;
                    }
                }
            }
        }
    }

    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Interactable")
        {
            for (i = 0; i < transform.childCount; i++)
            {
                if (objectList[i] != null)
                {
                    if (objectList[i].gameObject == collision.gameObject)
                    {
                        Debug.Log("L'objet est sorti du plateau");
                        objectList[i] = null;
                        occupiedList[i] = false;
                        break;
                    }
                }
            }
        }
    }
    

    private void Update()
    {

        if (objectList[i] != null)
        {
              Debug.Log("On applique la vélocité au plateau");
              velo = rbPlayer.linearVelocity;
              Rigidbody rbObj = objectList[i].GetComponent<Rigidbody>();
              //rbObj.linearVelocity.x = velo.x;
              rbObj.linearVelocity = new Vector3(velo.x, rbObj.linearVelocity.y, velo.z);
            
        }



        // Appliquer la vélocité aux objets du plateau
    } */
} 
