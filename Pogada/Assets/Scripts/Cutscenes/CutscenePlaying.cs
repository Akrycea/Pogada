using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlaying : MonoBehaviour
{
    [SerializeField] MusicPlay musicPlay;
    private VideoPlayer vidPlayer;
    [SerializeField] private float cutsceneDuration;
    [SerializeField] private bool isEndCutscene;

    public string trackName;
    void Start()
    {
        vidPlayer = gameObject.GetComponent<VideoPlayer>();
        if (isEndCutscene)
        {
            PlayCutscene();
        }
    }

    public void PlayCutscene()
    {
        Debug.Log("starting wait");
        musicPlay.playNewTrack(trackName);
        vidPlayer.Play();
        StartCoroutine(awaitCutsceneEnd());
    }
    
    public IEnumerator awaitCutsceneEnd()
    {
        yield return new WaitForSeconds(cutsceneDuration + 1);
        Debug.Log("finished waiting");
        if (!isEndCutscene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("laoding main menu");
            SceneManager.LoadScene(0);
        }
    }
}
