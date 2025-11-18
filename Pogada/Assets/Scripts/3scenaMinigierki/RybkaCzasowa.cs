using UnityEngine;
using System.Collections;

public class RybkaCzasowa : MonoBehaviour
{
    public Przeszkody przeszkody;


    void Start()
    {
        przeszkody.state = false;
    }

    private void OnMouseDown()
    {
        StartCoroutine(WaitRybka());
    }
    

    IEnumerator WaitRybka()
    {
        przeszkody.state = true;
        yield return new WaitForSeconds(5f);
        przeszkody.state = false;  
    }

}
