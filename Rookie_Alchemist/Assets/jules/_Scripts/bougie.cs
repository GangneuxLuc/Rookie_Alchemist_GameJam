using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public Light lumiere;

    [Header("Intensité")]
    public float intensiteMin = 0.8f;
    public float intensiteMax = 1.2f;

    [Header("Vitesse du scintillement")]
    public float vitesse = 5f;

    private float intensiteCible;

    void Start()
    {
        if (lumiere == null)
            lumiere = GetComponent<Light>();

        intensiteCible = lumiere.intensity;
    }

    void Update()
    {
        // Choisir une nouvelle intensité aléatoire
        intensiteCible = Random.Range(intensiteMin, intensiteMax);

        // Lisser la transition pour un effet naturel
        lumiere.intensity = Mathf.Lerp(lumiere.intensity, intensiteCible, Time.deltaTime * vitesse);
    }
}