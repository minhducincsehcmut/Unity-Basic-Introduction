using UnityEngine;
using UnityEngine.UI;

public class PlayStopSoundOnClick : MonoBehaviour
{
    public Button button; // Biến đại diện cho nút
    public AudioSource audioSource;
    public AudioClip soundToPlay;
    private bool isPlaying = false;

    void Start()
    {
        // Gắn sự kiện cho button
        button.onClick.AddListener(ToggleSound);

        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("No AudioSource found on this GameObject or in the inspector.");
            }
        }
    }

    public void ToggleSound()
    {
        if (isPlaying)
        {
            audioSource.Stop();
            isPlaying = false;
        }
        else
        {
            audioSource.clip = soundToPlay;
            audioSource.Play();
            isPlaying = true;
        }
    }
}
