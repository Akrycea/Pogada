using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class Zolw : MonoBehaviour
{
    ZolwPoruszanie zolwPoruszanie;

    void Update()
    {
        if(zolwPoruszanie.cameBack == true)
        {
            zolwPoruszanie.enabled = false;
        }
    }

    void OnMouseDown()
    {
        zolwPoruszanie.enabled = true;
    }

    


}
