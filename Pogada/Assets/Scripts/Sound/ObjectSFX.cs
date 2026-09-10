using UnityEngine;
using Yarn.Unity;

public class ObjectSFX : MonoBehaviour
{
    private AudioSource audioSource;
    private bool hasPlayed = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    [YarnCommand("playSFX")]
    public void playSFX()
    {
        if (!hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
}
