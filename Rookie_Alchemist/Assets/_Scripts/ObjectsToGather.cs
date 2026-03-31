using System.Collections.Generic;
using UnityEngine;

public class ObjectsToGather : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody rbPlateau;
    public plateauList plateauList;
    private EmplacementCheck check;

    public List<Transform> _List;

    [Tooltip(" Les différents points où les pobjets peuvent atterir sur le plateau quand on les récupère.")]
    [Header("Random Emplacement")]
    public float height;



   

    private void Awake()
    {
        plateauList = GameObject.FindWithTag("Plateau").GetComponent<plateauList>();
       
    }

    private void Start()
    {
        _List = GameObject.FindWithTag("Plateau").GetComponent<plateauList>().checkList;

    }

    // je fais une liste que je mets à jour quand un objet rentre dedans.

    // Quand je récupère un objet, il s'abonne à la liste et son emplacement sur le plateau devient occupé, empêchant un nouvel objet de pouvoir apparaître au même endroit

    public void Interact()
    {
        // Faire une UI qui signale une interaction possible lorsqu'on est assez proche de l'objet
        //transform.position = Emplacements[Random.Range(0, Emplacements.Length)].position + Vector3.up * height;  
        transform.position = _List[0].position;
       
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.F))
       {
            Interact();
            
                
       }
            
    }
}

