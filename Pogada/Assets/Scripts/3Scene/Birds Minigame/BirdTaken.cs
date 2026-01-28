using UnityEngine;

public class BirdTaken : MonoBehaviour
{
    public ClickDialogue clickDialogue;
    public GameObject BirdOnUI;
 
    void Update()
    {
        if (clickDialogue.dialoguePlayed == true)
        {
            BirdOnUI.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
