using UnityEngine;

public class plateauScript : MonoBehaviour
{
    [Header("Plateau Follow Settings")]
    private Vector3 initialLocalPosition;
    private Quaternion initialLocalRotation;
    private Vector3 initialLocalScale;
    private Transform cam;
    public float smooth = 5f;
    [Range(0, 10f)] public float distanceForwardFromCamera = 2f;
    [Range(0, 10f)] public float distanceRightFromCamera;
    [Range(0, 10f)] public float distanceDownFromCamera;
    void Awake()
    {
        if (cam == null)
        {
            cam = Camera.main.transform;
        }
    }

    void Update()
    {
        Vector3 targetPosition = cam.position + (cam.forward * distanceForwardFromCamera) + (cam.right * distanceRightFromCamera) +( Vector3.down * distanceDownFromCamera); // Position du plateau devant la caméra
        Quaternion targetRotation = Quaternion.LookRotation(cam.forward); // Rotation du plateau pour faire face à la caméra
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth); // Lerp pour un mouvement fluide

    }
}