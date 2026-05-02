using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneChanger : MonoBehaviour
{
    public bool load4;
    public bool unload4;
    public bool load5;
    public bool unload5;

    private void OnMouseDown()
    {
        if (unload4)
        {
            SceneManager.UnloadSceneAsync("4");
        }
        else if (load4)
        {
            SceneManager.LoadScene("4", LoadSceneMode.Additive);
        }
        else if (unload5)
        {
            SceneManager.UnloadSceneAsync("5");
        }
        else if (load5)
        {
            SceneManager.LoadScene("5", LoadSceneMode.Additive);
        }
    }
}
