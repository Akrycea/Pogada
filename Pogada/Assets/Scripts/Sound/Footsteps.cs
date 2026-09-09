using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class Footsteps : MonoBehaviour
{
    private PlayerMovement pMovement;
    public bool isWalking;

    private AudioSource audioSource;
    public bool playing;
    [SerializeField] float maxQuietTime;
    [SerializeField] float minQuietTime;
    public AudioClip[] sfxsRock;
    public AudioClip[] sfxsGrass;
    public AudioClip[] sfxsCloud;

    public bool rock;
    public bool grass;
    public bool cloud;
    void Start()
    {
        pMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (pMovement.speedX > 0 || pMovement.speedX < 0)
        {
            isWalking = true;
        }

        if (pMovement.speedX == 0)
        {
            isWalking = false;
        }

        if (isWalking)
        {
            if (playing)
            {
                audioSource.volume = 1;
                StartCoroutine(playSoundSometimes());
            }
        }
    }


    IEnumerator playSoundSometimes()
    {
        if (rock)
        {
            playing = false;
            AudioClip randomClip = sfxsRock[UnityEngine.Random.Range(0, sfxsRock.Length)];
            audioSource.PlayOneShot(randomClip);
            var waitTime = UnityEngine.Random.Range(minQuietTime, maxQuietTime);
            yield return new WaitForSeconds(waitTime);
            playing = true;
        }
        else if (grass)
        {
            playing = false;
            audioSource.volume = 0.3f;
            AudioClip randomClip = sfxsGrass[UnityEngine.Random.Range(0, sfxsGrass.Length)];
            audioSource.PlayOneShot(randomClip);
            var waitTime = UnityEngine.Random.Range(minQuietTime, maxQuietTime);
            yield return new WaitForSeconds(waitTime);
            playing = true;
        }
        else if (cloud)
        {
            playing = false;
            AudioClip randomClip = sfxsCloud[UnityEngine.Random.Range(0, sfxsCloud.Length)];
            audioSource.PlayOneShot(randomClip);
            var waitTime = UnityEngine.Random.Range(minQuietTime, maxQuietTime);
            yield return new WaitForSeconds(waitTime);
            playing = true;
        }
    }
}
