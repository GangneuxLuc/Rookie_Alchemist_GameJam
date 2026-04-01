using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class mainscriptcube : MonoBehaviour
{
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {

            StartCoroutine(LoadEnd());

        }
    }

    IEnumerator LoadEnd()
    {
        mainscriptanimation mainanim = player.GetComponent<mainscriptanimation>();
        mainanim.animationlance();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("END");
    }
}