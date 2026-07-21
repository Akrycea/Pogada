using System.Collections;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class OwlChangingSprite : MonoBehaviour
{
    public Image spriteRenderer;
    public Sprite[] spriteArray;
    public GameObject OwlOnUI;

    public void TurnUIon()
    {
        OwlOnUI.SetActive(true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "owlcollider1")
        {
            spriteRenderer.sprite = spriteArray[0];

        }
        else if (other.gameObject.name == "owlcollider2")
        {
            spriteRenderer.sprite = spriteArray[1];
        }
        else if (other.gameObject.name == "owlcollider3")
        {
            spriteRenderer.sprite = spriteArray[2];
        }
    }
}
