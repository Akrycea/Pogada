using System.Collections;
using Unity.Burst.Intrinsics;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class OwlChangingSprite : MonoBehaviour
{
    public Image spriteRenderer;
    public Sprite[] spriteArray;
    public GameObject OwlOnUI;
    [SerializeField]private GameObject audioSource1;
    [SerializeField] private GameObject audioSource2;
    [SerializeField] private GameObject audioSource3;

    public bool PlayOwlSound = true;

    private bool play1;
    public void TurnUIon()
    {
        OwlOnUI.SetActive(true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "owlcollider1")
        {
            Debug.Log("owl collider 1");
            spriteRenderer.sprite = spriteArray[0];
            play1 = true;
        }
        else if (other.gameObject.name == "owlcollider2")
        {
            Debug.Log("owl collider 2");
            spriteRenderer.sprite = spriteArray[1];
            play1 = false;
        }
        else if (other.gameObject.name == "owlcollider3")
        {
            Debug.Log("owl collider 3");
            spriteRenderer.sprite = spriteArray[2];
            play1 = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "owlcollider1")
        {
            audioSource1.GetComponent<AudioSource>().Stop();
            play1 = false;
        }
    }

    private void Update()
    {
        if(spriteRenderer.sprite == spriteArray[0] && play1 == true && PlayOwlSound)
        {
            audioSource1.SetActive(true);
            audioSource2.SetActive(false);
            if (!audioSource1.GetComponent<AudioSource>().isPlaying)
            {
                audioSource1.GetComponent<AudioSource>().Play();
            }
            audioSource3.SetActive(false);
        }
        else if (spriteRenderer.sprite == spriteArray[1] && PlayOwlSound)
        {
            audioSource1.SetActive(false);
            audioSource2.SetActive(true);
            if (!audioSource2.GetComponent<AudioSource>().isPlaying)
            {
                audioSource2.GetComponent<AudioSource>().Play();
            }
            audioSource3.SetActive(false);
        }
        else if (spriteRenderer.sprite == spriteArray[2] && PlayOwlSound)
        {
            audioSource1.SetActive(false);
            audioSource2.SetActive(false);
            if (!audioSource3.GetComponent<AudioSource>().isPlaying)
            {
                audioSource3.GetComponent<AudioSource>().Play();
            }
            audioSource3.SetActive(true);
        }
        else if (!PlayOwlSound)
        {
            audioSource1.SetActive(false);
            audioSource2.SetActive(false);
            audioSource3.SetActive(false);
        }
    }

}
