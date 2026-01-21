using UnityEngine;

public class FishWon : MonoBehaviour
{
    public int allFish;
    public bool allFishFound;

    public GameObject allFishOnUI;

   
    void Update()
    {
        if (allFish == 4)
        {
            allFishFound = true;
            Debug.Log("Fish Minigame Won");
        }
    }
}
