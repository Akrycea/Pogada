using UnityEngine;

public class ZolwPoruszanie : MonoBehaviour
{
    public Zolw zolw;

    public Transform ppp;

    public Vector3 orginalnaPozycja;
    public Vector3 docelowaPozycja;
    public float szybkosc;

    public bool lewoPrawo = true;

    public bool cameBack = false;


    void Start()
    {
        orginalnaPozycja = gameObject.transform.position;
    }


    void Update()
    {
        Vector3 kierunekPoruszania = docelowaPozycja - transform.position;
        kierunekPoruszania = kierunekPoruszania.normalized * Time.deltaTime * szybkosc;
        float maxDystans = Vector3.Distance(transform.position, docelowaPozycja);
        transform.position = transform.position + Vector3.ClampMagnitude(kierunekPoruszania, maxDystans);

        if(docelowaPozycja == gameObject.transform.position)
        {
            if (lewoPrawo == true)
            {
                docelowaPozycja = orginalnaPozycja;
                lewoPrawo = false;
                cameBack = false;
            }

            if (lewoPrawo == false)
            {
                docelowaPozycja = ppp.transform.position;
                lewoPrawo = true;
                cameBack = true;
            }
        }
    }

}
