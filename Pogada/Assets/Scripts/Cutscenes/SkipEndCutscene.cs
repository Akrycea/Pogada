using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipEndCutscene : MonoBehaviour
{
    [SerializeField] private float holdTime;
    [SerializeField] private GameObject clickImage;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            clickImage.SetActive(true);
            holdTime = holdTime + Time.deltaTime;
        }

        if(Input.GetMouseButtonUp(0))
        {
            clickImage.SetActive(false);
            holdTime = 0;
        }

        if(holdTime >= 3)
        {
            Debug.Log("laoding main menu");
            SceneManager.LoadScene(0);
        }
    }

    
}
