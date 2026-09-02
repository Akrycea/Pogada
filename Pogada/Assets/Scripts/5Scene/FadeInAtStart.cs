using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeInAtStart : MonoBehaviour
{
    [SerializeField] private Animator anim;
    void Start()
    {
        StartCoroutine(changeScene());
    }

    IEnumerator changeScene()
    {
        anim.Play("BlackoutOut");
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
