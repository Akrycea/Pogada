using UnityEngine;

public class DecorationsScript : MonoBehaviour
{
    [SerializeField] private GameObject[] decorations;

    public void ShowDecorations(int index)
    {
        if (index >= 0 && index < decorations.Length)
        {
            decorations[index].SetActive(true);
        }
    }

    public void HideDecorations()
    {
        foreach (var decoration in decorations)
        {
            decoration.SetActive(false);
        }
    }
}
