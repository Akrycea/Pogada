using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class PlayerIcon : MonoBehaviour
{
    [SerializeField]
    private Image characterIcons;
    
    public StateManager stateManager;
    public ChangingIcon changingIcon;

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

    [YarnCommand("ChangePlayerIcon")]
    public void ChangePlayerIcon(string emotion)
    {
        image = gameObject.GetComponent<Image>();
        Color c = image.color;
        c.a = 100;

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
            changingIcon.HideIcon();
            gameObject.SetActive(true);
            switch (emotion)
            {
                case "angry":
                    image.sprite = characterIcons[0];
                    break;
                case "happy":
                    image.sprite = characterIcons[1];
                    break;
                case "sad":
                    image.sprite = characterIcons[2];
                    break;
            }
        }

    }
    //using transparency insteadof set acive for the demo
    private Image image;
    [YarnCommand ("HidePlayerIcon")]
    public void HidePlayerIcon()
     {
        image = gameObject.GetComponent<Image>();
        Color c = image.color;
        c.a = 0;
        //gameObject.SetActive(false);
        }
    }
