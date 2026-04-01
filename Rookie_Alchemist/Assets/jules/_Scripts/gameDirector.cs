using UnityEngine;

public class gameDirector : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
                Time.timeScale = 1; // Reprend le temps
            else Time.timeScale = 0; // Met le temps en pause

        }
    }
}
