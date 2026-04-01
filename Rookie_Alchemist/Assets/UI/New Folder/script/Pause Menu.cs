using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            bool isActive = pauseMenuCanvas.activeSelf;
            pauseMenuCanvas.SetActive(!isActive);
        }
    }
}