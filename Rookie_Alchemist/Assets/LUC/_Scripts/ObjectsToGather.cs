using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToGather : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody rbPlateau;
    public plateauManager plateauManager;

    public List<Transform> _List;

    bool canInteract = true;
    public float height;


    public bool isPlaced = false; // Indique si l'objet est actuellement placé sur le plateau
    private void Awake()
    {
        plateauManager = GameObject.FindWithTag("Plateau").GetComponent<plateauManager>();
    }

    private void Start()
    {
        if (plateauManager != null)
            _List = plateauManager.emplacementList;
    }

    // Lors d'une interaction, on demande au plateau de placer l'objet en respectant l'occupation.
    public void Interact()
    {
        if (plateauManager == null)
        {
            return;
        }
        if (canInteract)
        {
            isPlaced = plateauManager.TryPlace(this);
            canInteract = false;
            if (!isPlaced)
            {
                Debug.Log("Aucun emplacement libre sur le plateau.");
            }
        }
        else return;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Interact();
        }
    }


    private void OnCollisionEnter(Collision collision) // Quand on rentre en collision, si on n'est plus placé sur le plateau, on lance DestroyObj
    {
        if (!isPlaced && !canInteract && !collision.gameObject.CompareTag("Plateau")) 
        {
            Debug.Log("Destruction de l'objet");
            StartCoroutine(DestroyObj());
        }
    }

    private IEnumerator DestroyObj() // Comportement pour jouer les FX, désactiver le meshRenderer et la collision puis de mettre à jour l'UI avant de détruir l'objet
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}

