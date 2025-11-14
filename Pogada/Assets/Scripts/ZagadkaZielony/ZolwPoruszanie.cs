using UnityEngine;
using System.Collections;

public class ZolwPoruszanie : MonoBehaviour
{
    public Zolw zolw;

    public Transform zolwdocelowy;

    public Vector3 orginalnaPozycja;
    public Vector3 docelowaPozycja;
    public float szybkosc;

    public bool lewoPrawo = true;

    public bool cameBack = false;


    void Start()
    {
        orginalnaPozycja = transform.position;
        docelowaPozycja = zolwdocelowy.transform.position;
    }


    void Update()
    {
        Vector3 kierunekPoruszania = docelowaPozycja - transform.position;
        kierunekPoruszania = kierunekPoruszania.normalized * Time.deltaTime * szybkosc;
        float maxDystans = Vector3.Distance(transform.position, docelowaPozycja);
        transform.position = transform.position + Vector3.ClampMagnitude(kierunekPoruszania, maxDystans);

        if(docelowaPozycja == transform.position)
        {
            Debug.Log("dotknieto");

            if (lewoPrawo == true)
            {
                StartCoroutine(WaitLewo());
            }

            if (lewoPrawo == false)
            {
                StartCoroutine(WaitPrawo());
            }

            if(lewoPrawo == false && transform.position == orginalnaPozycja)
            {
                cameBack = true;
                gameObject.tag = "ZGpassable";
            }
        }

        IEnumerator WaitLewo()
        {
            yield return new WaitForSeconds(2f);
            docelowaPozycja = orginalnaPozycja;
            lewoPrawo = false;
        }

        IEnumerator WaitPrawo()
        {
            yield return new WaitForSeconds(2f);
            docelowaPozycja = zolwdocelowy.transform.position;
            lewoPrawo = true;
        }
    }



}
