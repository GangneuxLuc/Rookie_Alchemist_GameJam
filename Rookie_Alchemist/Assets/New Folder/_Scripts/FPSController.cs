using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody rb;

    [Header("Input values")]
    float inputZ;
    float inputX;

    [Header("Player Stats")]
    [Range(0, 10f)] public float speed;
    float maxMovementSpeed = 10f;

    private void Update()
    {
        Movement();
    }
    void Movement() // M�thode pour faire bouger le joueur.
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputZ = Input.GetAxisRaw("Vertical");


        Vector3 input = new Vector3(inputX, 0f, inputZ); // Je cr�e un Vecteur3 qui prend en valeur les inputs du joueur
        input = Vector3.ClampMagnitude(input, 1f); // Je limite la magnitude du vecteur d'input � 1 pour que le joueur ne puisse pas aller plus vite en diagonale.

        var targetVelocity = input * speed; // Je crée un Vecteur3 qui prend en valeur la direction et la vitesse que le joueur doit atteindre en fonction de ses inputs et de sa vitesse maximale.
        Vector3 horizontalVelocity = rb.linearVelocity; // Je crée un Vecteur3 qui prend en valeur la vitesse actuelle du joueur.
        horizontalVelocity.y = 0.0f; //Je met l'axe Y de la vitesse actuelle du joueur à 0 pour ne pas changer la vitesse verticale du joueur 
        rb.AddForce(transform.TransformDirection(targetVelocity) * (1 - (horizontalVelocity.magnitude / maxMovementSpeed))); //J'ajoute une force au joueur en accordant le déplacement à son orientation et en réduisant la force à mesure que sa vitesse actuelle approche de sa vitesse maximale.

        // envoyer sa linearVelocity au PLateau
        // Le plateau va redistribuer la vélocité et il prend la direction du joueur
    }
}
