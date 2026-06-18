using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DebateKidsIcons : MonoBehaviour
{
    [SerializeField]
    private Image spriteRenderer;

    // icons, going in order -> angry, angrytalk, happy, happytalk, sad, sadtalk
    [SerializeField]
    private Sprite[] Robert;
    [SerializeField]
    private Sprite[] Lute;
    [SerializeField]
    private Sprite[] Aureus;
    [SerializeField]
    private Sprite[] Viri;
    [SerializeField]
    private Sprite[] Lus;
    [SerializeField]
    private Sprite[] Liv;
    [SerializeField]
    private Sprite[] Violaceus;

    [YarnCommand("ChangeDebateIcon")]
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
        }
        if (characterIcons != null)
        {
            switch (emotion)
            {
                case "angry":
                    spriteRenderer.sprite = characterIcons[0];
                    break;
                case "angrytalk":
                    spriteRenderer.sprite = characterIcons[1];
                    break;
                case "happy":
                    spriteRenderer.sprite = characterIcons[2];
                    break;
                case "happytalk":
                    spriteRenderer.sprite = characterIcons[3];
                    break;
                case "sad":
                    spriteRenderer.sprite = characterIcons[4];
                    break;
                case "sadtalk":
                    spriteRenderer.sprite = characterIcons[5];
                    break;
            }
        }
    }
}
