using UnityEngine;
using UnityEngine.UI;

public class ParcheminAnim : MonoBehaviour
{
    public Sprite[] sprites;
    public float fps = 12f;
    private Image image;
    private int currentFrame = 0;
    private float timer = 0f;
    private bool playing = false;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void Play()
    {
        currentFrame = 0;
        playing = true;
    }

    void Update()
    {
        if (!playing) return;

        timer += Time.deltaTime;
        if (timer >= 1f / fps)
        {
            timer = 0f;
            currentFrame++;
            if (currentFrame >= sprites.Length)
            {
                playing = false;
                return;
            }
            image.sprite = sprites[currentFrame];
        }
    }
}