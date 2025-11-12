using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LodkaPoruszanie : MonoBehaviour
{
    public Transform[] przeszkody;

    private Vector3 orginalnaPozycja;
    public Vector3 docelowaPozycja;
    public float szybkosc;

    public int numerTablicy = 0;


    void Start()
    {
        orginalnaPozycja = gameObject.transform.position;
        docelowaPozycja = przeszkody[0].transform.position;
    }

  
    void Update()
    {
        Vector3 kierunekPoruszania = docelowaPozycja - transform.position;
        kierunekPoruszania = kierunekPoruszania.normalized * Time.deltaTime * szybkosc;
        float maxDystans = Vector3.Distance(transform.position, docelowaPozycja);
        transform.position = transform.position + Vector3.ClampMagnitude(kierunekPoruszania, maxDystans);

        if(gameObject.transform.position == docelowaPozycja)
        {
            numerTablicy ++;
            docelowaPozycja = przeszkody[numerTablicy].transform.position;
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "zolw")
        {
            if (collision.CompareTag("ZGpassable"))
            {
                
            }

            if (collision.CompareTag("ZGnotpassable"))
            {
                transform.position = orginalnaPozycja;
                docelowaPozycja = przeszkody[0].transform.position;
                numerTablicy = 0;
                enabled = false;
            }
        }
        else if (collision.gameObject.name == "zolw")
        {
            StartCoroutine(WaitZolw());
        }
        else if (collision.gameObject.name == "koniec")
        {
            Debug.Log("koniec, done");
        }
    }

    IEnumerator WaitRybka()
    {
        przeszkody.state = true;
        yield return new WaitForSeconds(5f);
        przeszkody.state = false;
    }
}
