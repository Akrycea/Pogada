using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.PlayerSettings;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class JabbingInBG : MonoBehaviour
{
    public RectTransform SafeZoneUI;

    public void JabbingInZone()
    {
        var pos = SafeZoneUI.localPosition;
        SafeZoneUI.localPosition = new Vector3(Random.Range(-756, -272), pos.y, pos.z);

        SafeZoneUI.sizeDelta = new Vector2(Random.Range(50, 500), 100);
    }
}
