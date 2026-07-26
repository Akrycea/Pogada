using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip sound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(sound);
    }
}

