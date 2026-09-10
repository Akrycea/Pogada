using UnityEngine;
using Yarn.Unity;

public class ObjectSFX : MonoBehaviour
{
    private AudioSource audioSource;
    public bool hasPlayed = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void playSFX()
    {
        if (!hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
}
