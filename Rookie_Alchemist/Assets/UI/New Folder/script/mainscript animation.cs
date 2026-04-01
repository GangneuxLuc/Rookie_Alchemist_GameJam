using UnityEngine;

public class mainscriptanimation : MonoBehaviour
{
    public Animator prendre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void animationlance()
    {
        prendre.SetTrigger("Prendre");
    }
}