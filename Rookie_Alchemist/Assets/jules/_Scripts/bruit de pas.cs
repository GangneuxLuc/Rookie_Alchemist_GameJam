using UnityEngine;

public class SonMouvement : MonoBehaviour
{
    public AudioSource audioSource;   // Le son � jouer
    public Rigidbody rb;              // Le rigidbody du joueur
    public float seuilVitesse = 0.1f; // Vitesse minimale pour consid�rer que le joueur bouge

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        if (rb == null)
            rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // V�rifie la vitesse du joueur
        float vitesse = rb.linearVelocity.magnitude;

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