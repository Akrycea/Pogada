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

            //bo nie dziala build
            bMinigame = GameObject.Find("BirdsMinigame").GetComponent<BirdsWin>();
            bMinigame.birdsWin = 4;
            bMinigame.GoodSpot();
        }
    }
    private BirdsWin bMinigame;
}
