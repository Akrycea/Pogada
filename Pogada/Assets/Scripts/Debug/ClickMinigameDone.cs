using UnityEngine;

public class ClickMinigameDone : MonoBehaviour
{
    [SerializeField] private DebataPlayer debataPlayer;

    private void OnMouseDown()
    {
        debataPlayer.wygranaMinigierka = true;
    }
}
