using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Jab : MonoBehaviour
{
    public RectTransform SafeZoneUI;

    //for testing on scene
    private void Start()
    {
        JabbingIn();
    }

    //reference to this, when you want the Jab in the debate
    public void JabbingIn()
    {
        var pos = SafeZoneUI.localPosition;
        SafeZoneUI.localPosition = new Vector3(Random.Range(-756, -272), pos.y, pos.z);

        //SafeZoneUI.transform.anchorPosition = new Vector2(0,0);

        //to trzeba jakos madrze obliczyc i ustalic ale narazie daje randomowe numerki
        SafeZoneUI.sizeDelta = new Vector2(Random.Range(50,500), 100);

    }
}
