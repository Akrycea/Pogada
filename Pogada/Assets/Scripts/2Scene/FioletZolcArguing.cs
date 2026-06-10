using UnityEngine;
using Yarn.Unity;

public class FioletZolcArguing : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    [YarnCommand("fightCloudDisappear")]
    public void fightCloudDisappear()
    {
        gameObject.SetActive(false);
    }
}
