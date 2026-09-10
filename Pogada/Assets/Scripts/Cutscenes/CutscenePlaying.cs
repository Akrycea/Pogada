using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutscenePlaying : MonoBehaviour
{
    [SerializeField] MusicPlay musicPlay;
    private VideoPlayer vidPlayer;
    [SerializeField] private float cutsceneDuration;

    public string trackName;
    void Start()
    {
        vidPlayer = gameObject.GetComponent<VideoPlayer>();
    }

    public void PlayCutscene()
    {
        musicPlay.playNewTrack(trackName);
        vidPlayer.Play();
        StartCoroutine(awaitCutsceneEnd());
    }
    
    public IEnumerator awaitCutsceneEnd()
    {
        yield return new WaitForSeconds(cutsceneDuration + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
