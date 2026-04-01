using UnityEngine;

public class SonMouvement : MonoBehaviour
{
    public AudioSource audioSource;   // Le son à jouer
    public Rigidbody rb;              // Le rigidbody du joueur
    public float seuilVitesse = 0.1f; // Vitesse minimale pour considérer que le joueur bouge

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Vérifie la vitesse du joueur
        float vitesse = rb.velocity.magnitude;

        // Si le joueur bouge
        if (vitesse > seuilVitesse)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}