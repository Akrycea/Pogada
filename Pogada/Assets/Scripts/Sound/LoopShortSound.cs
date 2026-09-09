using System;
using System.Collections;
using UnityEngine;


public class LoopShortSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private bool playing;
    [SerializeField] float maxQuietTime;
    [SerializeField] float minQuietTime;
    public AudioClip[] sfxs;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (playing)
        {
            StartCoroutine(playSoundSometimes());
        }
    }

    IEnumerator playSoundSometimes()
    {
        playing = false;
        var waitTime = UnityEngine.Random.Range(minQuietTime, maxQuietTime);
        yield return new WaitForSeconds(waitTime);
        AudioClip randomClip = sfxs[UnityEngine.Random.Range(0, sfxs.Length)];
        audioSource.PlayOneShot(randomClip);
        yield return new WaitForSeconds(1);
        playing = true;
    }
}
