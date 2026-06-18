using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class DebatePlayerIcon : MonoBehaviour
{
    [SerializeField]
    private Image spriteRenderer;

    public StateManager stateManager;

    [SerializeField]
    private Sprite[] playerSzary;
    [SerializeField]
    private Sprite[] playerZielony;
    [SerializeField]
    private Sprite[] playerCzerwony;
    [SerializeField]
    private Sprite[] playerGranat;
    [SerializeField]
    private Sprite[] playerPomarancz;
    [SerializeField]
    private Sprite[] playerBlekit;
    [SerializeField]
    private Sprite[] playerFiolet;
    [SerializeField]
    private Sprite[] playerZolc;

    [YarnCommand("ChangeDebatePlayerIcon")]
    public void ChangePlayerIcon(string emotion)
    {
        Sprite[] characterIcons = null;

        if (stateManager.szary == true)
        {
            characterIcons = playerSzary;
        }
        else if (stateManager.zielony == true)
        {
            characterIcons = playerZielony;
        }
        else if (stateManager.czerwony == true)
        {
            characterIcons = playerCzerwony;
        }
        else if (stateManager.granat == true)
        {
            characterIcons = playerGranat;
        }
        else if (stateManager.pomarancz == true)
        {
            characterIcons = playerPomarancz;
        }
        else if (stateManager.niebieski == true)
        {
            characterIcons = playerBlekit;
        }
        else if (stateManager.fiolet == true)
        {
            characterIcons = playerFiolet;
        }
        else if (stateManager.zolty == true)
        {
            characterIcons = playerZolc;
        }

        if (characterIcons != null)
        {
            switch (emotion)
            {
                case "accuse":
                    spriteRenderer.sprite = characterIcons[0];
                    break;
                case "accusetalk":
                    spriteRenderer.sprite = characterIcons[1];
                    break;
                case "distress":
                    spriteRenderer.sprite = characterIcons[2];
                    break;
                case "distresstalk":
                    spriteRenderer.sprite = characterIcons[3];
                    break;
                case "understand":
                    spriteRenderer.sprite = characterIcons[4];
                    break;
                case "understandtalk":
                    spriteRenderer.sprite = characterIcons[5];
                    break;
            }
        }

    }
}
