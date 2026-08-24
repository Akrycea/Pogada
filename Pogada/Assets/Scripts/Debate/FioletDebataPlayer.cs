using UnityEngine;

public class FioletDebataPlayer : MonoBehaviour
{
    public TurnOffCollider turnOffCollider;

    [SerializeField] private GameObject budowanieZdan1;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private DebateManager debateManager;
    [SerializeField] private GameObject UI;

    public void fioletSentenceBuilding()
    {
        debateManager.StartDebate();

        turnOffCollider.DisableAllExceptSpecificTag();
        Debug.Log("starting sentence building");
        budowanieZdan1.SetActive(true);
        UI.SetActive(true);
        Debug.Log("blocking player movement");
        playerMovement.canPlayerMove = false;
    }
}
