using UnityEngine;
using UnityEngine.Audio;

public class ClickSFX : MonoBehaviour
{
    private AudioSource audioSource;
    private bool hasPlayed = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
       audioSource.Play();
    }
}
