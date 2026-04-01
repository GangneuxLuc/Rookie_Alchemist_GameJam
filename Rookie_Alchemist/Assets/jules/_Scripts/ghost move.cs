using UnityEngine;
using UnityEngine.AI;

public class DeplacementAleatoire : MonoBehaviour
{
    public float rayon = 10f; // Rayon autour de l'IA pour choisir un point
    public float tempsEntrePoints = 2f; // Temps avant de choisir un nouveau point

    private NavMeshAgent agent;
    private float timer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ChoisirNouveauPoint();
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Si l'agent a atteint sa destination ou si le timer expire
        if (!agent.pathPending && agent.remainingDistance < 0.5f || timer >= tempsEntrePoints)
        {
            ChoisirNouveauPoint();
        }
    }

    void ChoisirNouveauPoint()
    {
        timer = 0f;

        // Choisir un point aléatoire dans une sphère
        Vector3 pointAlea = Random.insideUnitSphere * rayon + transform.position;

        NavMeshHit hit;

        // Trouver le point le plus proche sur le NavMesh
        if (NavMesh.SamplePosition(pointAlea, out hit, rayon, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
}