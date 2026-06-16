using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class ChangingIcon : MonoBehaviour
{
    [SerializeField]
    private Image spriteRenderer;

    public PlayerIcon playerIcon;

    // icons, going in order -> angry, happy, sad
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

    [SerializeField]
    private Sprite[] Slonce;
    [SerializeField]
    private Sprite[] Ksiezyc;

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
            playerIcon.HidePlayerIcon();
            gameObject.SetActive(true);
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

    [YarnCommand("HideIcon")]
    public void HideIcon()
    {
        gameObject.SetActive(false);
    }

}
