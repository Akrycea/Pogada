using UnityEngine;
using UnityEngine.UI;

public class Jab : MonoBehaviour
{
    //for testing on scene
    private void Start()
    {
        JabbingIn();
    }

    public Slider JabSlider; 

    //reference to this, when you want the Jab in the debate
    public void JabbingIn()
    {
        gameObject.transform.Rotate(0, 0, Random.Range(0, 360));
        //to trzeba jakos madrze obliczyc i ustalic ale narazie daje randomowe numerki
        JabSlider.value = Random.Range (1,9);
    }
}
