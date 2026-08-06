using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlaying : MonoBehaviour
{
    private VideoPlayer vidPlayer;
    [SerializeField] private float cutsceneDuration;
    void Start()
    {
        vidPlayer = gameObject.GetComponent<VideoPlayer>();
    }

    public void PlayCutscene()
    {
        vidPlayer.Play();
        StartCoroutine(awaitCutsceneEnd());
    }
    
    public IEnumerator awaitCutsceneEnd()
    {
        yield return new WaitForSeconds(cutsceneDuration + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
