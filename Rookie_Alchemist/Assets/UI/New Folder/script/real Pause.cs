using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.Video;

public class realPause : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            pause();
        }

        else
        {
            returnpause();
        }
    }
         

        

    public void pause()
    {
    Time.timeScale = 0f;
        Debug.Log("PAUSE");
    
    
    }
    public void returnpause()
    {
        Time.timeScale = 1f;
        Debug.Log("ça reprend");


    }
}
