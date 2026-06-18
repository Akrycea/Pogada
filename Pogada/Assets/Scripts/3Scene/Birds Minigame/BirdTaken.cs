using UnityEngine;

public class BirdTaken : MonoBehaviour
{
    public ClickDialogue clickDialogue;
    public GameObject BirdOnUI;
    [SerializeField]
    private GameObject birdCameraButton;
 
    void Update()
    {
        if (clickDialogue.dialoguePlayed == true)
        {
            BirdOnUI.SetActive(true);
            gameObject.SetActive(false);
            birdCameraButton.SetActive(true);
        }
    }
    private BirdsWin bMinigame;
}
