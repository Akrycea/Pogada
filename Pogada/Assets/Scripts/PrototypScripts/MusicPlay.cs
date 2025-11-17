using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public static MusicPlay Instance;
    private AudioSource audio;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void Update()
    {
        
    }
}
