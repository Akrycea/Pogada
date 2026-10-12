using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BlackBeggining : MonoBehaviour
{
    [SerializeField] private GameObject blackoutCanvas;
    [SerializeField] private Animator anim;
    [SerializeField] private YarnCommands yarn;
    void Start()
    {
        yarn.blockPlayerMovement();
        StartCoroutine(BlackIn());
    }
    IEnumerator BlackIn()
    {
        yield return new WaitForSeconds(5);
        anim.Play("BlackoutOu");
        yarn.unblockPlayerMovement();
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
