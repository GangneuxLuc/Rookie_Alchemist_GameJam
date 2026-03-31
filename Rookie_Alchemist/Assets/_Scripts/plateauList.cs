using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class plateauList : MonoBehaviour
{
   [SerializeField] public List<ObjectsToGather> occupiedList;
    private EmplacementCheck check;



    public List<Transform> checkList;
    public Transform[] emplacement;


    private Rigidbody rbPlayer;
    Vector3 velo;
    int i;
    private void Awake()
    {
        rbPlayer = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            occupiedList.Add(null);
        } 

        for (int i = 0;i < transform.childCount; i++)
        {
            checkList.Add(transform.GetChild(i));
        }
        
    }

    public void Collide(GameObject maCollision)
    {

        for (i = 0; i < transform.childCount; i++)
        {
            if (occupiedList[i] == null)
            {
                occupiedList[i] = (maCollision.GetComponent<ObjectsToGather>());
                occupiedList[i].transform.SetParent(transform);
                break;
            }
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Interactable" )
        {
            Debug.Log("On rentre en collision avec l'objet");
            Collide(collision.gameObject);

        }
    }
    private void Update()
    {
        velo = rbPlayer.linearVelocity;
       // Debug.Log(velo);
        //Rigidbody rbObj = occupiedList[i].GetComponent<Rigidbody>();
        
        

        // Appliquer la vélocité aux objets du plateau
    }
}
