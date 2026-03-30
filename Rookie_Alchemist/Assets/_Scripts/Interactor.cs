using UnityEngine;


interface IInteractable
{
    public void Interact();
}
public class Interactor : MonoBehaviour
{
    LineRenderer lineRenderer;
    public Transform interactorSource;
    [Range(0, 100f)] public float interactorRange;

    private void Update() // gros caca
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r = new Ray(interactorSource.position, interactorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, interactorRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(new Ray(interactorSource.position, interactorSource.forward));
    }
}


