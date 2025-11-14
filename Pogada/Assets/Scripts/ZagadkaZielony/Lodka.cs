using UnityEngine;
using System.Collections;

public class Lodka : MonoBehaviour
{
    public LodkaPoruszanie lodkaPoruszanie;
    public ZolwPoruszanie zolwPoruszanie;

    private bool isRunning = false;

    void OnMouseDown()
    {
        lodkaPoruszanie.enabled = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "zolw" && isRunning == false)
        {
            StartCoroutine(WaitZolw());
        }

        IEnumerator WaitZolw()
        {
            isRunning = true;
            yield return new WaitForSeconds(0.5f);
            lodkaPoruszanie.enabled = false;
            yield return new WaitForSeconds(3f);
            //lodkaPoruszanie.numerTablicy++;
            lodkaPoruszanie.enabled = true;
            zolwPoruszanie.enabled = true;
        }
    }
}


