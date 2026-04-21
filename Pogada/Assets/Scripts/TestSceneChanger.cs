using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneChanger : MonoBehaviour
{
    public bool unload;

    private void OnMouseDown()
    {
        if (unload)
        {
            SceneManager.UnloadSceneAsync("4");
        }
        else
        {
            SceneManager.LoadScene("4", LoadSceneMode.Additive);
        }
    }
}
