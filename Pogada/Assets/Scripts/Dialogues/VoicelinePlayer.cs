using System;
using UnityEngine;
using Yarn.Unity;

public class VoicelinePlayer : MonoBehaviour
{
    private AudioSource MyAudioSource;

    public AudioClip[] voicelineClips;

    //public string nazwaAudio;

    void Start()
    {
        MyAudioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }

    [YarnCommand("voiceline")]
    public void VoicelinePlay(int clipNumber)
    {
        if(MyAudioSource.isPlaying)
        {
            MyAudioSource.Stop();
        }
        AudioClip clip = voicelineClips[clipNumber];
        MyAudioSource.PlayOneShot(clip);

    }

    [YarnCommand("voicelineEnd")]
    public void VoicelineEnd()
    {
        MyAudioSource.Stop();
    }
}
