using TreeEditor;
using UnityEngine;

public class CameraFps : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform player;

    [Header("Input Settings")]
    float mouseY;
    float mouseX;

    [Tooltip("Sensibilité et rotation max/min de la caméra à régler dans l'inspecteur")]
    [Header("Sensitivity + Rotation clamp")]
    [Range(0, 10f)] public float sensitivityY;
    [Range(0, 10f)] public float sensitivityX;
    [Range(-100f, 100f)] public int minRotationY;
    [Range(0, 100f)] public int maxRotationY;


    [Header("Rotation values")]
    float rotationY;
    float rotationX;

    private void Update() // Utiliser pour appler les méthodes
    {
        MouseLook();
        PlayerRotation();
    }
    void MouseLook() // Méthode pour gérer la rotation de la caméra grâce au mouvement de la souris en X et en Y
    {
        mouseY = Input.GetAxis("Mouse Y");
        mouseX = Input.GetAxis("Mouse X");

        rotationY -= mouseY * sensitivityY;
        rotationX += mouseX * sensitivityX;
        rotationY = Mathf.Clamp(rotationY, minRotationY, maxRotationY); // Avec les valeurs configurable dans l'inspecteur on peut bloquer la rotation de la caméra pour avoir feeling plus réaliste.

        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0); // Rotation de la caméra
    }

    void PlayerRotation() // Méthode pour faire rotater le joueur selon la rotation de la caméra
    {
        if (player != null)
        {
            transform.localRotation = Quaternion.Euler(rotationY, 0f, 0f);
            player.Rotate(Vector3.up * mouseX * sensitivityX);
        }
    }


}
