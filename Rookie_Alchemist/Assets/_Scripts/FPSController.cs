using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Camera _camera;
    [SerializeField] Transform _transform;
    [SerializeField] Rigidbody _rigidbody;

    [Header("Input values")]
    float inputY;
    float inputX;

    [Header("Player Stats")]
    [Range(0, 10f)] public float speed;

    private void Update()
    {
        Movement();
    }
    void Movement() // Méthode pour faire bouger le joueur.
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");


        Vector2 input = new Vector2(inputX, inputY); // Je crée un Vecteur2 qui prend en valeur les inputs du joueur

        //if (input.sqrMagnitude > 1f) input.Normalize();
    

        transform.Translate(new Vector3( inputX, 0f, inputY) * speed * Time.deltaTime); // J'applique le déplacement
         

    }


}
