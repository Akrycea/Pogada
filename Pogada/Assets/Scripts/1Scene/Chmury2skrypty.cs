using UnityEngine;
using Unity.Burst.Intrinsics;
using UnityEngine;
using System.Collections;
using TMPro.Examples;

public class Chmury2skrypty : MonoBehaviour
{
    //uniwersalny sprite changer i przenoszenie przedmiotow razem

    // po prostu przenosi przedmioty jak je zlapiesz
    private Vector3 screenPoint;
    private Vector3 offset;

    
    public bool ZezwolPrzenoszenie = false;

    //odniesienie do gracza
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    //tablica ze sprite'ami
    public Sprite[] spriteArray;

    //liczba na ktorym sprite jestes
    int CurrentSprite;

    private bool allowSpriteChange = true;

    public bool MouseDown = false;


    private void Start()
    {
        CurrentSprite = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();

        //znowu, to wszystko do playera jest nmg z niego
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }
    void OnMouseDown()
    {
        if (allowSpriteChange)
        {
            MouseDown = true;
            if (CurrentSprite < spriteArray.Length - 1)
            {
                CurrentSprite = CurrentSprite + 1;
                spriteRenderer.sprite = spriteArray[CurrentSprite];

            }
        }

        if (ZezwolPrzenoszenie == true)
        {
            //to cos robi
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseUp()
    {
        MouseDown = false;
    }

    void OnMouseDrag()
    {
        if (ZezwolPrzenoszenie == true && MouseDown == false)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    private void Update()
    {
        if (CurrentSprite == spriteArray.Length - 1)
        {
            //StartCoroutine(Wait());
            ZezwolPrzenoszenie = true;
            allowSpriteChange = false;
        }
    }

    //IEnumerator Wait()
    //{
    //    allowSpriteChange = false;
    //    yield return new WaitForSeconds(0.5f);
    //    ZezwolPrzenoszenie = true;
    //}
}
