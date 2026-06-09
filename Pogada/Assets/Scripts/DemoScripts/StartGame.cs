using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject cutscenka;
    public void startGame()
    {
        cutscenka.SetActive(true);
        gameObject.SetActive(false);
    }
}
