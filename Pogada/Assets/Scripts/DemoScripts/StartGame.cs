using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject cutscenka;
    [SerializeField] private CutscenePlaying cutscenePlay;
    public void startGame()
    {
        gameObject.SetActive(false);
        cutscenePlay.PlayCutscene();
    }
}
