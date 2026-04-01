using UnityEngine;
using UnityEngine.Video;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class parcheminvideo : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public GameObject boutonsPanel; // Le panel qui contient tes boutons
    public VideoPlayer videoPlayer;
    public RawImage RawImage;

    public float delaiAvantBoutons = 4f; // Temps de latence en secondes

    private Coroutine affichageBoutonsCoroutine;

    void Start()
    {
        RawImage.enabled = false;
        boutonsPanel.SetActive(false); // Cache les boutons au départ

        RenderTexture.active = videoPlayer.targetTexture;
        GL.Clear(true, true, Color.black);
        RenderTexture.active = null;

        videoPlayer.Prepare();
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            bool isActive = pauseMenuCanvas.activeSelf;
            pauseMenuCanvas.SetActive(!isActive);

            if (!isActive)
            {
                OuvrirPause();
            }
            else
            {
                continuer();
            }
        }
    }

    void OuvrirPause()
    {
        RawImage.enabled = true;
        boutonsPanel.SetActive(false);

        videoPlayer.time = 0;
        videoPlayer.Play();

        Time.timeScale = 0;

        if (affichageBoutonsCoroutine != null)
            StopCoroutine(affichageBoutonsCoroutine);

        affichageBoutonsCoroutine = StartCoroutine(AfficherBoutonsAvecDelai());
    }

    IEnumerator AfficherBoutonsAvecDelai()
    {
        yield return new WaitForSecondsRealtime(delaiAvantBoutons);
        boutonsPanel.SetActive(true);
    }

    public void continuer()
    {
        if (affichageBoutonsCoroutine != null)
            StopCoroutine(affichageBoutonsCoroutine);

        RawImage.enabled = false;
        boutonsPanel.SetActive(false);
        videoPlayer.Pause();
        Time.timeScale = 1;
        pauseMenuCanvas.SetActive(false);
    }
}