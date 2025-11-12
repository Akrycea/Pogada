using UnityEngine;

public class ZolwPoruszanie : MonoBehaviour
{
    public Zolw zolw;

    private Vector3 orginalnaPozycja;
    public Vector3 docelowaPozycja;
    public float szybkosc;


    void Start()
    {
        orginalnaPozycja = gameObject.transform.position;
        //skomentowane poniewaz powodowalo problemy z kompilacja i nie dalo sie pracowac
        //docelowaPozycja = przeszkody.transform.position;
    }


    void Update()
    {
        Vector3 kierunekPoruszania = docelowaPozycja - transform.position;
        kierunekPoruszania = kierunekPoruszania.normalized * Time.deltaTime * szybkosc;
        float maxDystans = Vector3.Distance(transform.position, docelowaPozycja);
        transform.position = transform.position + Vector3.ClampMagnitude(kierunekPoruszania, maxDystans);
    }

}
