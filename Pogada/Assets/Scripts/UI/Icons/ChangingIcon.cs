using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class ChangingIcon : MonoBehaviour
{
    public Image spriteRenderer;
 
    // icons, going in order -> angry, happy, sad 
    public Sprite[] Robert;
    public Sprite[] Lute;
    public Sprite[] Aureus;
    public Sprite[] Viri;
    public Sprite[] Lus;
    public Sprite[] Liv;
    public Sprite[] Violaceus;

    public Sprite[] Slonce;
    public Sprite[] Ksiezyc;

    [YarnCommand("ChangeIcon")]
    public void ChangeIcon(string characterName, string emotion)
    {
        Sprite[] characterIcons = null;

        switch (characterName)
        {
            case "Robert":
                characterIcons = Robert;
                break;
            case "Lute":
                characterIcons = Lute;
                break;
            case "Aureus":
                characterIcons = Aureus;
                break;
            case "Viri":
                characterIcons = Viri;
                break;
            case "Lus":
                characterIcons = Lus;
                break;
            case "Liv":
                characterIcons = Liv;
                break;
            case "Violaceus":
                characterIcons = Violaceus;
                break;
            case "Slonce":
                characterIcons = Slonce;
                break;
            case "Ksiezyc":
                characterIcons = Ksiezyc;
                break;
        }
        if (characterIcons != null)
        {
            switch (emotion)
            {
                case "angry":
                    spriteRenderer.sprite = characterIcons[0];
                    break;
                case "happy":
                    spriteRenderer.sprite = characterIcons[1];
                    break;
                case "sad":
                    spriteRenderer.sprite = characterIcons[2];
                    break;
            }
        }
    }

}
