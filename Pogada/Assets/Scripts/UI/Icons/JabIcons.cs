using Unity.VisualScripting;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class JabIcons : MonoBehaviour
{ 
    [SerializeField]
    private Image spriteRenderer;

    [SerializeField]
    private Sprite Robert;
    [SerializeField]
    private Sprite Lute;
    [SerializeField]
    private Sprite Aureus;
    [SerializeField]
    private Sprite Viri;
    [SerializeField]
    private Sprite Lus;
    [SerializeField]
    private Sprite Liv;
    [SerializeField]
    private Sprite Violaceus;

    [YarnCommand("ChangeJabIcon")]
    public void ChangeJabIcon(string characterName)
    {
        Sprite characterIcon = null;
        switch (characterName)
        {
            case "Robert":
                characterIcon = Robert;
                break;
            case "Lute":
                characterIcon = Lute;
                break;
            case "Aureus":
                characterIcon = Aureus;
                break;
            case "Viri":
                characterIcon = Viri;
                break;
            case "Lus":
                characterIcon = Lus;
                break;
            case "Liv":
                characterIcon = Liv;
                break;
            case "Violaceus":
                characterIcon = Violaceus;
                break;
        }

        if (characterIcon != null)
        {
            spriteRenderer.sprite = characterIcon;
        }
    }


    [YarnCommand("HideJabIcon")]
    public void HideIcon()
    {
        gameObject.SetActive(false);
    }
}
