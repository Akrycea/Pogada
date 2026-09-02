using UnityEngine;
using Yarn.Unity;

public class GlassHintStart : MonoBehaviour
{
    [SerializeField] private GameObject hintObject;

    [YarnCommand("startGlassHints")]
    public void startGlassHints()
    {
        hintObject.SetActive(true);
    }
}
