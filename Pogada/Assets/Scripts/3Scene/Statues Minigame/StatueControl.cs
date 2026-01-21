using TMPro.Examples;
using UnityEngine;

public class StatueControl : MonoBehaviour
{
    public GameObject ground;
    public GameObject[] sunParts;
    public GameObject[] moonParts;

    [SerializeField]
    private int sunNumber = 0;
    [SerializeField]
    private int moonNumber = 0;

    public DebataPlayer debataPlayer;

    //gameObject.CompareTag("")

    public void Status()
    {
        //if (ground.gameObject.CompareTag("CZplaceable"))
        //{
        //    sunParts[0].SetActive(true);
        //    moonParts[0].SetActive(true);
        //}

        if (sunParts[sunNumber].CompareTag("CZplaceable") && sunNumber < sunParts.Length - 1)
        {
            sunNumber++;
            sunParts[sunNumber].SetActive(true);
        }

        if (moonParts[moonNumber].CompareTag("CZplaceable") && moonNumber < moonParts.Length - 1)
        {
            moonNumber++;
            moonParts[moonNumber].SetActive(true);
        }


        if (sunNumber == sunParts.Length - 1 && moonNumber == moonParts.Length - 1)
        {
            Debug.Log("statuly wygrane");
            //debataPlayer.wygranaMinigierka = true;
        }
    }
}
