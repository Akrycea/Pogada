using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuShortcut : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(0);
        }
    }

}
