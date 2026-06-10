using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class BacktoMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen;
    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    [YarnCommand("thankYouScreen")]
    public void openThankYouScreen()
    {
        screen.SetActive(true);
    }
}
