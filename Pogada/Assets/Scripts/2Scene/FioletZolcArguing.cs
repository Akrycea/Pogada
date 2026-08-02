using UnityEngine;
using Yarn.Unity;

public class FioletZolcArguing : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    [YarnCommand("fightCloudDisable")]
    public void fightCloudDisable()
    {
        gameObject.SetActive(false);
    }

    private SpriteRenderer spriteRenderer;
    [YarnCommand("fightCloudDisappear")]
    public void fightCloudDisappear()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
}
