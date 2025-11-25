using TMPro.Examples;
using UnityEngine;

public class StatueControl : MonoBehaviour
{
    public GameObject ground;
    public GameObject[] sunParts;
    public GameObject[] moonParts;

    private int sunNumber = 0;
    private int moonNumber = 0;

    //gameObject.CompareTag("")

    public void Update()
    {
        
    }

    public void Status()
    {
        if (ground.gameObject.CompareTag("CZplaceable"))
        {
            Debug.Log("its reading the tag");

            sunParts[0].SetActive(true);
            //moonParts[0].SetActive(true);
        }

        if (sunParts[sunNumber].CompareTag("CZplaceable") && sunNumber < sunParts.Length - 1)
        {
            sunNumber++;
            sunParts[sunNumber].SetActive(true);
        }
    }
}
