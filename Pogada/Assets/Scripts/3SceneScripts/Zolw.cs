using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Zolw : MonoBehaviour
{
    public ZolwPoruszanie zolwPoruszanie;

    void Update()
    {
        if(zolwPoruszanie.cameBack)
        {
            zolwPoruszanie.enabled = false;
        }
    }

    void OnMouseDown()
    {
        zolwPoruszanie.cameBack = false;
        zolwPoruszanie.enabled = true;
    }

    


}
