using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class ScriptContenu : MonoBehaviour

{
    public GameObject contenu;
    public float delai = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AffichercréditAvecDelai()
    {
        yield return new WaitForSecondsRealtime(delai);
        contenu.SetActive(true);
    }
    public void créditenter()
    {
        AffichercréditAvecDelai();
    }
}
