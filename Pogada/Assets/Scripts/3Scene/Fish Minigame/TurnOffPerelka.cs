using UnityEngine;

public class TurnOffPerelka : MonoBehaviour
{
    [SerializeField] private GameObject perelka;
    [SerializeField] private StateManager stateManager;

    private void OnMouseDown()
    {
        if (perelka.activeSelf && stateManager.FishMinigameWon)
        {
            perelka.SetActive(false);
        }
    }
}
