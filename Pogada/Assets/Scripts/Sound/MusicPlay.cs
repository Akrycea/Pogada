using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public string trackName;
    public bool playAtStart;

    private MusicManager musicManager;
    
    void Start()
    {
        if (playAtStart)
        {
            MusicManager.Instance.PlayMusic(trackName);
        }
    }

    public void playNewTrack(string trackName)
    {
        MusicManager.Instance.PlayMusic(trackName);
    }
}
