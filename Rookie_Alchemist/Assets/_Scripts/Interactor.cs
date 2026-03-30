using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
interface IInteractable
{
    public void Interact();
}
public class Interactor : MonoBehaviour
{
    public Transform interactorSource;
    [Range(0, 100f)] public float interactorRange;
    LayerMask layerMask;

    private void Awake()
    {
        layerMask = LayerMask.GetMask("Interactable");
    }



    private void Update() // gros caca
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward * interactorRange);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactorRange, layerMask))
                Debug.Log(hitInfo.collider.gameObject.name);
                Debug.DrawRay(interactorSource.position, interactorSource.forward * interactorRange, Color.red, 1f);
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            }
           
        }
    }



}


