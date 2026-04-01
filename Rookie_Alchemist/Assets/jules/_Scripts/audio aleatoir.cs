using UnityEngine;

public class AudioAleatoire : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] sons; // Liste des sons à jouer

    [Header("Temps entre les sons")]
    public float minDelay = 1f;
    public float maxDelay = 3f;

    private float timer;

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        timer = Random.Range(minDelay, maxDelay);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            JouerSonAleatoire();
            timer = Random.Range(minDelay, maxDelay);
        }
    }

    void JouerSonAleatoire()
    {
        if (sons.Length == 0) return;

        int index = Random.Range(0, sons.Length);
        audioSource.PlayOneShot(sons[index]);
    }
}