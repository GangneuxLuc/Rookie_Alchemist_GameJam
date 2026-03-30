using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody rb;

    [Header("Input values")]
    float inputY;
    float inputX;

    [Header("Player Stats")]
    [Range(0, 10f)] public float speed;

    private void Update()
    {
        Movement();
    }
    void Movement() // M�thode pour faire bouger le joueur.
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");


        Vector2 input = new Vector2(inputX, inputY); // Je cr�e un Vecteur2 qui prend en valeur les inputs du joueur
        rb.linearVelocity = rb.transform.forward * inputY * speed + rb.transform.right * inputX * speed; // J'applique le d�placement
    }
}
