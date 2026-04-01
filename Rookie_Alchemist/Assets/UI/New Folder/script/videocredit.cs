using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections;

public class videotourne : MonoBehaviour
{
    public GameObject MenuCanvas;
    public VideoPlayer videoPlayer;
    public RawImage RawImage;
    public GameObject contenu;
    public float delai = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RawImage.enabled = false;
        RenderTexture.active = videoPlayer.targetTexture;
        GL.Clear(true, true, Color.black);
        RenderTexture.active = null;

        videoPlayer.Prepare();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OuvrirCrédit()
    {
        bool isActive = MenuCanvas.activeSelf;
        MenuCanvas.SetActive(!isActive);
        RawImage.enabled = true;

        videoPlayer.time = 0;
        videoPlayer.Play();
        AffichercréditAvecDelai();


    }
    public void laissercredit()
    {
        RawImage.enabled = false;
        videoPlayer.Pause();
        MenuCanvas.SetActive(false);


    }
    IEnumerator AffichercréditAvecDelai()
    {
        yield return new WaitForSecondsRealtime(delai);
        contenu.SetActive(true);
    }
}
